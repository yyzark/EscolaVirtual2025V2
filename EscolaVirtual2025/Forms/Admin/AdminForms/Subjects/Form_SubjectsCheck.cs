using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Data;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EscolaVirtual2025.Forms.Admin.AdminForms.Subjects
{
    public partial class Form_SubjectsCheck : MaterialForm
    {
        private List<Year> orderedYears = DataManager.Years.OrderBy(y => y.Id).ToList();
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
                cbbAno.Items.Add(yr.Id.ToString());
            }
            if (orderedYears.Count > 0)
                cbbAno.SelectedIndex = 0;
            UpdateListView();
        }

        private void UpdateListView()
        {
            lsvCheckSubject.Items.Clear();
            foreach (Subject sbjct in orderedYears[cbbAno.SelectedIndex].Subjects.Items)
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
                    Subject subject = year.Subjects.Items.FirstOrDefault(s => s.Id == subjectId);
                    if (subject != null)
                    {
                        year.Subjects.Remove(subject);

                        foreach (ClassRoom classroom in year.ClassRooms.Items)
                        {
                            classroom.ClassSubjects.RemoveAll(cs => cs.Id == subjectId);
                        }
                    }
                }

                // Remove da lista global
                Subject globalSubject = DataManager.Subjects.FirstOrDefault(s => s.Id == subjectId);
                if (globalSubject != null)
                    DataManager.Subjects.Remove(globalSubject);

                MessageBox.Show($"Disciplina \"{nome}\" removida de todos os anos com sucesso.", "Removida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Remove apenas do ano selecionado
                Subject subjectToRemove = selectedYear.Subjects.Items.FirstOrDefault(sbj => sbj.Id == subjectId);
                if (subjectToRemove != null)
                {
                    selectedYear.Subjects.Remove(subjectToRemove);

                    foreach (ClassRoom classroom in selectedYear.ClassRooms.Items)
                    {
                        classroom.ClassSubjects.RemoveAll(cs => cs.Id == subjectId);
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
            if (btnAdd.Text == "Adicionar")
            {
                Form_AddSubject form_AddSubject = new Form_AddSubject();
                form_AddSubject.ShowDialog();
                UpdateListView();
            }
            else
            {
                if (lsvCheckSubject.SelectedItems.Count == 0)
                    return;

                // Obtém o Id da disciplina selecionada
                int subjectId = (int)lsvCheckSubject.SelectedItems[0].Tag;

                // Busca o Subject global
                Subject subjectToEdit = DataManager.Subjects.FirstOrDefault(s => s.Id == subjectId);
                if (subjectToEdit == null)
                {
                    MessageBox.Show("Disciplina não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Abre o Form_EditSubject passando o subject
                Form_EditSubject form_EditSubject = new Form_EditSubject(subjectToEdit);
                form_EditSubject.ShowDialog();

                // Atualiza a ListView após edição
                UpdateListView();
            }
        }

        private void lsvCheckSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvCheckSubject.SelectedItems.Count > 0)
            {
                btnRemove.Enabled = true;
                btnAdd.Text = "Editar";
            }
            else
            {
                btnAdd.Text = "Adicionar";
                btnRemove.Enabled = false;
            }
        }
    }
}
