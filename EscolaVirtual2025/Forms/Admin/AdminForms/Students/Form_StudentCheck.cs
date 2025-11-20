using EscolaVirtual2025.Classes.Users;
using EscolaVirtual2025.Data;
using EscolaVirtual2025.Forms.Admin.AdminForms.Students;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Linq;
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
                    Student studentToRemove = DataManager.Students.FirstOrDefault(s => s.NIF.ToString() == NIFToRemove);

                    // Remover o aluno da lista global de alunos
                    DataManager.Students.Remove(studentToRemove);
                    var year = DataManager.Years.FirstOrDefault(y => y.Id == studentToRemove.ClassRoom.Year.Id);
                    var classRoom = year.ClassRooms.Items.FirstOrDefault(cr => cr.Id == studentToRemove.ClassRoom.Letter);
                    classRoom.RemoveStudent(studentToRemove);
                    classRoom.OrderStudentsByName();
                    // Remover o aluno da lista global de users
                    DataManager.Users.Remove(studentToRemove);
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
            foreach (Student student in DataManager.Students)
            {
                var item = new ListViewItem(student.Username);
                item.SubItems.Add(student.Name);
                item.SubItems.Add(student.NIF.ToString());
                item.SubItems.Add($"{student.ClassRoom.Year.Id}º{student.ClassRoom.Id}");

                lsvStudents.Items.Add(item);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_AddStudent formAddStudent = new Form_AddStudent();
            formAddStudent.ShowDialog();
            lsvUpdate();
        }

        private void lsvStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvStudents.SelectedItems.Count <= 0)
            {
                btnRemove.Enabled = false;
            }
            else
            {
                btnRemove.Enabled = true;
            }
        }
    }
}
