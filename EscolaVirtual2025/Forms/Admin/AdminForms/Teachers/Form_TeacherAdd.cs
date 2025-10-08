using EscolaVirtual2025.Classes;
using EscolaVirtual2025.Classes.Users;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaVirtual2025.Forms.Admin.AdminForms.Teachers
{
    public partial class Form_TeacherAdd : MaterialForm
    {
        private Form_AddTeacherClassroomChose classroomChose;
        private Teacher newTeacher;

        public Form_TeacherAdd()
        {
            InitializeComponent();

            #region MaterialSkin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red300,
                Primary.Red700,
                Primary.Red100,
                Accent.Orange200,
                TextShade.WHITE
            );
            #endregion

            // Criação de teacher temporário (sem parâmetros — será preenchido depois)
            newTeacher = new Teacher(null, null, null, null, null);

            // Passamos o teacher para o form de escolha de disciplinas/turmas
            classroomChose = new Form_AddTeacherClassroomChose(newTeacher);

            txtLogin.Hint = "Login";
            txtPassword.Hint = "Password";
            txtName.Hint = "Nome";
            txtNIF.Hint = "NIF";
        }

        private void Form_TeacherAdd_Load(object sender, EventArgs e)
        {
        }

        private void btnClassRooms_Click(object sender, EventArgs e)
        {
            // Antes de abrir, certifica que os campos base estão preenchidos
            if (string.IsNullOrWhiteSpace(txtLogin.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtNIF.Text))
            {
                MessageBox.Show("Preencha todos os dados do professor antes de atribuir turmas.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Preenche os dados já escritos antes de abrir o form de turmas
            newTeacher.Username = txtLogin.Text.Trim();
            newTeacher.Password = txtPassword.Text.Trim();
            newTeacher.Name = txtName.Text.Trim();
            newTeacher.NIF = txtNIF.Text.Trim();

            classroomChose.ShowDialog();
            CheckAcceptButtonState();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string nif = txtNIF.Text.Trim();

            // Verifica se o NIF já existe
            if (Program.Users.OfType<TeacherStudent>().Any(u => u.NIF == nif))
            {
                MessageBox.Show("Já existe um utilizador com este NIF.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cria o novo professor
            newTeacher.Username = txtLogin.Text.Trim();
            newTeacher.Password = txtPassword.Text.Trim();
            newTeacher.Name = txtName.Text.Trim();
            newTeacher.NIF = nif;

            Program.Teachers.Add(newTeacher);
            Program.Users.Add(newTeacher);

            // Para cada turma selecionada
            foreach (var cls in classroomChose.p_Teacher.AssignedClassRooms)
            {
                var targetClass = Program.ClassRooms.FirstOrDefault(c => c.Id == cls.Id);
                if (targetClass != null)
                {
                    // Se já existir ClassSubject com o mesmo Subject, atribui o professor
                    foreach (var cs in targetClass.Subjects)
                    {
                        if (cs.AssignedTeacher == null)
                            cs.AssignedTeacher = newTeacher;
                    }
                }
            }

            MessageBox.Show("Professor adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region TextBox Validation
        private void txtLogin_TextChanged(object sender, EventArgs e) => CheckAcceptButtonState();
        private void txtPassword_TextChanged(object sender, EventArgs e) => CheckAcceptButtonState();
        private void txtName_TextChanged(object sender, EventArgs e) => CheckAcceptButtonState();
        private void txtNIF_TextChanged(object sender, EventArgs e) => CheckAcceptButtonState();

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void txtNIF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        #endregion

        private void CheckAcceptButtonState()
        {
            bool filled = !string.IsNullOrWhiteSpace(txtLogin.Text)
                && !string.IsNullOrWhiteSpace(txtPassword.Text)
                && !string.IsNullOrWhiteSpace(txtName.Text)
                && !string.IsNullOrWhiteSpace(txtNIF.Text)
                && classroomChose.TeacherClassroomsChosen;

            btnAccept.Enabled = filled;
        }
    }
}
