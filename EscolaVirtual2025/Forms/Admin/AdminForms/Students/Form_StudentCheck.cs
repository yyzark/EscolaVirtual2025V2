using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Users;
using EscolaVirtual2025.Forms.Admin.AdminForms.Students;
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

namespace EscolaVirtual2025.Forms.Admin.AdminForms
{
    public partial class Form_StudentCheck : MaterialForm
    {
        public Form_StudentCheck()
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
        }

        private void Form_StudentCreation_Load(object sender, EventArgs e)
        {
            lsvStudents.View = View.Details;
            lsvStudents.FullRowSelect = true;
            lsvStudents.GridLines = true;

            // Adicionar alunos à ListView
            lsvUpdate();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lsvStudents.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Tem a certeza que pretende remover o aluno selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    ListViewItem selectedItem = lsvStudents.SelectedItems[0];
                    string NIFToRemove = selectedItem.SubItems[2].Text;
                    // Encontrar o aluno na lista global
                    Student studentToRemove = Program.students.FirstOrDefault(s => s.NIF == NIFToRemove);

                    // Remover o aluno da lista global de alunos
                    Program.students.Remove(studentToRemove);
                    var year = Program.Anos.FirstOrDefault(y => y.AnoId == studentToRemove.ClassRoom.Year.AnoId);
                    var classRoom = year.ClassRooms.FirstOrDefault(cr => cr.Id == studentToRemove.ClassRoom.Id);
                    classRoom.RemoveStudent(studentToRemove);
                    // Remover o aluno da lista global de users
                    Program.Users.Remove(studentToRemove);
                    // Remover o item da ListView
                    lsvStudents.Items.Remove(selectedItem);
                    MessageBox.Show("Aluno removido com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um aluno para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lsvUpdate()
        {
            lsvStudents.Items.Clear();
            foreach (Student student in Program.students)
            {
                var item = new ListViewItem(student.Username);
                item.SubItems.Add(student.Name);
                item.SubItems.Add(student.NIF);
                item.SubItems.Add($"{student.ClassRoom.Year.AnoId}º{student.ClassRoom.Id}");

                lsvStudents.Items.Add(item);
            }

            if (lsvStudents.Items.Count <= 0)
            {
                btnRemove.Enabled = false;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_AddStudent formAddStudent = new Form_AddStudent();
            formAddStudent.ShowDialog();
            lsvUpdate();
        }
    }
}
