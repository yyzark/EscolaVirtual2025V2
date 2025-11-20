using EscolaVirtual2025.Classes;
using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Chat;
using EscolaVirtual2025.Classes.InterFace;
using EscolaVirtual2025.Classes.Users;
using EscolaVirtual2025.Data;
using EscolaVirtual2025.Forms.Admin.AdminForms.Teachers;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace EscolaVirtual2025.Forms.TeacherForms.TeacherAccount
{
    public partial class Form_EditTeacherAccount : MaterialForm
    {
        Form_AddTeacherClassroomChose classroomChose;
        private Teacher tchr;
        private Teacher newTeacher;
        public Form_EditTeacherAccount(Teacher teacher)
        {
            InitializeComponent();

            #region MaterialSkin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Red300,    // cor principal clara
            Primary.Red700,    // cor principal escura
            Primary.Red100,    // cor de fundo ou destaque
            Accent.Orange200,  // acento laranja suave
            TextShade.WHITE    // cor do texto;
            );
            #endregion


            tchr = teacher;
            newTeacher = new Teacher
            {
                Username = tchr.Username,
                Name = tchr.Name,
                Password = tchr.Password,
                NIF = tchr.NIF,
                AssignedClassRooms = new EntityCollection<ClassRoom, int>(DataManager.ClassRooms, cl => cl.Id),
                AssignedSubject = tchr.AssignedSubject
            };

            foreach (var classroom in tchr.AssignedClassRooms.Items)
            {
                newTeacher.AssignedClassRooms.Add(new ClassRoom
                {
                    Id = classroom.Id,
                    Year = new Year(classroom.Year.Id)
                });
            }
            classroomChose = new Form_AddTeacherClassroomChose(newTeacher, true);
        }

        private void Form_EditTeacherAccount_Load(object sender, EventArgs e)
        {
            cbbSubjects.Items.AddRange(DataManager.Subjects.Select(sbjct => sbjct.Name).ToArray());

            foreach (string item in cbbSubjects.Items)
            {
                if (item == tchr.AssignedSubject.Name)
                {
                    cbbSubjects.SelectedItem = item;
                }
            }

            txtLogin.Text = tchr.Username;
            txtName.Text = tchr.Name;
            txtPassword.Text = tchr.Password;
            txtNIF.Text = tchr.NIF.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClassRooms_Click(object sender, EventArgs e)
        {
            classroomChose = new Form_AddTeacherClassroomChose(newTeacher, true);
            classroomChose.ShowDialog();
            ver();
        }

        private void ver()
        {
            bool camposPreenchidos =
                !string.IsNullOrEmpty(txtLogin.Text) &&
                !string.IsNullOrEmpty(txtName.Text) &&
                txtNIF.Text.Length == 9 &&
                !string.IsNullOrEmpty(txtPassword.Text) &&
                classroomChose != null &&
                classroomChose.TeacherClassroomsChosen;

            bool semAlteracoes =
                txtLogin.Text == tchr.Username &&
                txtName.Text == tchr.Name &&
                txtNIF.Text == tchr.NIF.ToString() &&
                txtPassword.Text == tchr.Password &&
                cbbSubjects.SelectedItem.ToString() == tchr.AssignedSubject.Name;

            btnAccept.Enabled = camposPreenchidos || !semAlteracoes;
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            ver();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show(
                "A senha deve ter pelo menos 6 caracteres!",
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
                return;
            }
            else
            {
                // Verifica se o NIF tem exatamente 9 dígitos numéricos
                string nif = txtNIF.Text;

                // Verifica duplicações de NIF em Teachers e Students
                bool nifExists = DataManager.Users.Any(u =>
                {
                    if (u.UserType == UserType.Teacher && u is Teacher teacher)
                        return teacher.NIF.ToString() == nif && nif != tchr.NIF.ToString();

                    if (u.UserType == UserType.Student && u is Student student)
                        return student.NIF == nif;

                    return false;
                });

                newTeacher.NIF = txtNIF.Text;
                newTeacher.Password = txtPassword.Text;
                newTeacher.Name = txtName.Text;
                newTeacher.Username = txtLogin.Text;
                foreach (Notification notification in DataManager.Users[0].Notifications)
                {
                    if (notification.Sender == tchr)
                        DataManager.Users[0].Notifications.Remove(notification);
                }
                DataManager.Users[0].Notifications.Add(new Request(tchr, DataManager.Users[0], newTeacher));

                MessageBox.Show(
                "O pedido foi enviado ao administrador!.",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                this.Close();
            }
        }

        private void cbbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            newTeacher.AssignedSubject = DataManager.Subjects[cbbSubjects.SelectedIndex];
            ver();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            ver();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            ver();
        }

        private void txtNIF_TextChanged(object sender, EventArgs e)
        {
            ver();
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Utils.IsAllowedCharacter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Utils.IsAllowedCharacter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Utils.IsAllowedNameCharacter(e.KeyChar) || Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNIF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
