using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Users;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EscolaVirtual2025.Forms.Admin.AdminForms.Subjects
{
    public partial class Form_SubjectsCheck : MaterialForm
    {
        private List<Year> orderedYears = Program.Anos.OrderBy(y => y.AnoId).ToList();
        public Form_SubjectsCheck()
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

        private void Form_SubjectsCheck_Load(object sender, EventArgs e)
        {
            this.clmClassRoom.Width = 90;
            this.clmClassRoomName.Width = 251;
            foreach (Year yr in orderedYears)
            {
                cbbAno.Items.Add(yr.AnoId.ToString());
            }
            cbbAno.SelectedIndex = 0;
            UpdateListView();   
        }

        private void UpdateListView()
        {
            lsvCheckSubject.Items.Clear();
            foreach (Subject sbjct in orderedYears[cbbAno.SelectedIndex].Subjects)
            {
                ListViewItem item = new ListViewItem(sbjct.Id.ToString());
                item.SubItems.Add(sbjct.Name);
                item.Tag = sbjct.Id;
                lsvCheckSubject.Items.Add(item);
            }

            foreach (ColumnHeader col in lsvCheckSubject.Columns)
                col.Width = -2; // auto resize
        }

        private void cbbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lsvCheckSubject.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor selecione uma disciplina para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selectedItem = lsvCheckSubject.SelectedItems[0];
            string nome = selectedItem.SubItems[1].Text;

            // Pergunta se remover só deste ano ou de todos os anos
            DialogResult choice = MessageBox.Show(
                $"Deseja remover a disciplina \"{nome}\" apenas deste ano?\n\n" +
                "Sim: Apenas deste ano\nNão: De todos os anos",
                "Remover Disciplina",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (choice == DialogResult.Cancel)
                return;

            bool removeFromAllYears = choice == DialogResult.No;

            // Obtém o ano atual
            Year selectedYear = orderedYears[cbbAno.SelectedIndex];

            // Obtém o Id da disciplina do Tag
            if (!(selectedItem.Tag is int subjectId))
            {
                MessageBox.Show("Id da disciplina inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (removeFromAllYears)
            {
                // Remove de todos os anos
                foreach (Year year in orderedYears)
                {
                    Subject subject = year.Subjects.FirstOrDefault(s => s.Id == subjectId);
                    if (subject != null)
                    {
                        year.Subjects.Remove(subject);

                        foreach (ClassRoom classroom in year.ClassRooms)
                        {
                            classroom.Subjects.RemoveAll(cs => cs.Subject.Id == subjectId);
                        }
                    }
                }

                // Remove da lista global
                Subject globalSubject = Program.Subjects.FirstOrDefault(s => s.Id == subjectId);
                if (globalSubject != null)
                    Program.Subjects.Remove(globalSubject);

                MessageBox.Show($"Disciplina \"{nome}\" removida de todos os anos com sucesso.", "Removida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Remove apenas do ano selecionado
                Subject subjectToRemove = selectedYear.Subjects.FirstOrDefault(sbj => sbj.Id == subjectId);
                if (subjectToRemove != null)
                {
                    selectedYear.Subjects.Remove(subjectToRemove);

                    foreach (ClassRoom classroom in selectedYear.ClassRooms)
                    {
                        classroom.Subjects.RemoveAll(cs => cs.Subject.Id == subjectId);
                    }

                    MessageBox.Show($"Disciplina \"{nome}\" removida apenas deste ano.", "Removida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível encontrar a disciplina selecionada neste ano.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            UpdateListView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_AddSubject form_AddSubject = new Form_AddSubject();
            form_AddSubject.ShowDialog();
            UpdateListView();
        }
    }
}
