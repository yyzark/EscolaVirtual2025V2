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
using EscolaVirtual2025.Classes.Academic;

namespace EscolaVirtual2025.Forms.Admin.AdminForms.Teachers
{
    public partial class Form_TeacherAdd : MaterialForm
    {
        private Teacher newTeacher;
        private Form_AddTeacherClassroomChose form_AddTeacherClassroomChose;
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

            newTeacher = new Teacher(null, null, null, null, null);
            form_AddTeacherClassroomChose = new Form_AddTeacherClassroomChose(newTeacher);
        }

        private void Form_TeacherAdd_Load(object sender, EventArgs e)
        {
            foreach (Subject sbjct in Program.Subjects)
            {
                cbbSubjects.Items.Add(sbjct.Id + "-" + sbjct.Name);
            }
        }

        private void cbbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSubjects.SelectedIndex != -1)
            {
                btnClassRooms.Enabled = true;
                if (Program.Subjects[cbbSubjects.SelectedIndex] != newTeacher.AssignedSubject)
                {
                    newTeacher.AssignedSubject = Program.Subjects[cbbSubjects.SelectedIndex];
                    form_AddTeacherClassroomChose.ResetListView();
                }
            }
            else
            {
                btnClassRooms.Enabled = false;
            }
        }

        private void btnClassRooms_Click(object sender, EventArgs e)
        {
            form_AddTeacherClassroomChose.p_Subject = Program.Subjects[cbbSubjects.SelectedIndex];
            form_AddTeacherClassroomChose.ShowDialog();
            ver();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            ver();
        }

        private void ver()
        {

            if (txtLogin.Text != string.Empty && txtName.Text != string.Empty && txtNIF.Text.Length == 9 && txtPassword.Text != string.Empty && form_AddTeacherClassroomChose.TeacherClassroomsChosen == true)
            {
                btnAccept.Enabled = true;
            }
            else
            {
                btnAccept.Enabled = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            ver();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            ver();
        }

        private void txtNIF_TextChanged(object sender, EventArgs e)
        {
            ver();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (Program.Users.Any(usr => usr.Username == txtLogin.Text.Trim()))
            {
                MessageBox.Show(
                "Já existe um utilizador com este nome de utilizador!",
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
                return;
            }
            else
            {
                if (txtPassword.Text.Length < 4)
                {
                    MessageBox.Show(
                    "A senha deve ter pelo menos 4 caracteres!",
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
                    bool nifExists = Program.Users.Any(u =>
                    {
                        if (u.UserType == UserType.Teacher && u is Teacher teacher)
                            return teacher.NIF == nif;

                        if (u.UserType == UserType.Student && u is Student student)
                            return student.NIF == nif;

                        return false;
                    });

                    if (nifExists)
                    {
                        MessageBox.Show("Já existe um utilizador (professor ou aluno) com este NIF.",
                                        "NIF duplicado",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        txtNIF.Focus();
                        return;
                    }

                    // Cria o professor com os dados inseridos
                    newTeacher.Name = txtName.Text.Trim();
                    newTeacher.NIF = nif;
                    newTeacher.Username = txtLogin.Text;
                    newTeacher.Password = txtPassword.Text.Trim();
                    // A disciplina foi definida no combo box

                    // Adiciona às listas globais
                    if (!Program.Teachers.Contains(newTeacher))
                        Program.Teachers.Add(newTeacher);

                    if (!Program.Users.Contains(newTeacher))
                        Program.Users.Add(newTeacher);

                    // Atualiza as turmas associadas
                    foreach (ClassRoom classroom in Program.ClassRooms)
                    {
                        foreach (ClassSubject classSubject in classroom.Subjects)
                        {
                            if (classSubject.Subject.Id == newTeacher.AssignedSubject.Id &&
                                classSubject.AssignedTeacher == newTeacher)
                            {
                                if (!newTeacher.AssignedClassRooms.Contains(classroom))
                                    newTeacher.AssignedClassRooms.Add(classroom);
                            }
                        }
                    }

                    foreach(Year yr in Program.Anos)
                    {
                        foreach(Subject sbjct in yr.Subjects)
                        {
                            if (!sbjct.Teachers.Contains(newTeacher) && sbjct == Program.Subjects[cbbSubjects.SelectedIndex])
                                sbjct.Teachers.Add(newTeacher);
                        }
                    }



                    // Sucesso
                    MessageBox.Show("Professor adicionado com sucesso!",
                                    "Sucesso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Utils.IsAllowedCharacter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Utils.IsAllowedCharacter(e.KeyChar) && !Char.IsControl(e.KeyChar))
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

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Utils.IsAllowedNameCharacter(e.KeyChar) || Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
