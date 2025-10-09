using EscolaVirtual2025.Classes.Academic;
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
    public partial class Form_CheckTeachers : MaterialForm
    {
        public Form_CheckTeachers()
        {
            InitializeComponent();

            List<Teacher> lista = new List<Teacher>
            {
                new Teacher("mferreira", "abcd", "Maria Ferreira", "987654321", Program.Subjects[1]),
                new Teacher("pcosta", "qwerty", "Pedro Costa", "456789123", Program.Subjects[0])
            };

            Program.Teachers = lista;
            Program.Subjects.ForEach(sbjct => sbjct.Teachers.AddRange(lista));

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

        private void Form_CheckTeachers_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void UpdateListView()
        {
            lsvCheckTeachers.Items.Clear();

            foreach (var teacher in Program.Teachers)
            {
                // Cria o item principal com o nome
                ListViewItem item = new ListViewItem(teacher.Name);

                // Adiciona subitens: disciplina e nif
                string subjectName = teacher.AssignedSubject.Name;
                item.SubItems.Add(subjectName);
                item.SubItems.Add(teacher.NIF);

                // Guarda o objeto completo (útil p/ remover ou editar)
                item.Tag = teacher;

                // Adiciona o item ao ListView
                lsvCheckTeachers.Items.Add(item);
            }

            // Ajusta automaticamente as colunas à largura do conteúdo
            foreach (ColumnHeader col in lsvCheckTeachers.Columns)
                col.Width = -2; // auto resize

            if(Program.ClassRooms.Count == 0)
            {
                btnAdd.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lsvCheckTeachers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor selecione um professor para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedItem = lsvCheckTeachers.SelectedItems[0];
            Teacher selectedTeacher = (Teacher)selectedItem.Tag;

            var confirm = MessageBox.Show($"Deseja remover {selectedTeacher.Name}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Program.Teachers.Remove(selectedTeacher);
                Program.Subjects.ForEach(sb => sb.Teachers.Remove(selectedTeacher));
                UpdateListView();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_TeacherAdd form_TeacherAdd = new Form_TeacherAdd();
            form_TeacherAdd.ShowDialog();
            UpdateListView();
        }

        private void Form_CheckTeachers_VisibleChanged(object sender, EventArgs e)
        {
            UpdateListView();
        }
    }
}
