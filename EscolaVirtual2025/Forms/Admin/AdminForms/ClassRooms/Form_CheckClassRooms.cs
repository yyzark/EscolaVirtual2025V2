using EscolaVirtual2025.Data;
using EscolaVirtual2025.Data.Import;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EscolaVirtual2025.Forms.Admin.AdminForms.ClassRooms
{
    public partial class Form_CheckClassRooms : MaterialForm
    {
        public Form_CheckClassRooms()
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

        private void Form_CheckClassRooms_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void UpdateListView()
        {
            lsvCheckClassRoom.Items.Clear();
            for (int i = 0; i < DataManager.Years.Count; i++)
            {
                DataManager.Years[i].ClassRooms.Reorder(clsrm => clsrm.Letter);
                foreach (char idTurma in DataManager.Years[i].ClassRooms.Items.Select(clsrm => clsrm.Letter))
                {
                    ListViewItem itemTurma = new ListViewItem();
                    itemTurma.Text = DataManager.Years[i].Id + "º" + idTurma;
                    lsvCheckClassRoom.Items.Add(itemTurma);
                }
                if (lsvCheckClassRoom.Items.Count <= 0)
                {
                    btnRemove.Enabled = false;
                }
            }

            foreach (ColumnHeader col in lsvCheckClassRoom.Columns)
                col.Width = -2; // auto resize

            if (DataManager.Years.Count == 0)
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
            if (lsvCheckClassRoom.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione uma sala para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtém o ID da sala selecionada
            string selectedText = lsvCheckClassRoom.SelectedItems[0].Text;
            string[] parts = selectedText.Split('º');

            int yearId = Convert.ToInt32(parts[0]);
            char selectedLetter = parts[1][0];

            var selectedYear = DataManager.Years.FirstOrDefault(a => a.Id == yearId);
            var classRoomToRemove = selectedYear.ClassRooms.Items.FirstOrDefault(cls => cls.Id == selectedLetter);

            DialogResult result = MessageBox.Show(
                $"Tem a certeza que deseja remover a turma \"{yearId}º{selectedLetter}\"?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
                return;

            for (int i = 0; i < classRoomToRemove.StudentsCount; i++)
            {
                var student = classRoomToRemove.Students[i];

                DataManager.Users.Remove(student);
                DataManager.Students.Remove(student);

                // Limpa referência na turma
                classRoomToRemove.Students[i] = null;
            }

            // Remove a turma
            selectedYear.ClassRooms.Remove(classRoomToRemove);
            DataManager.ClassRooms.Remove(classRoomToRemove);

            selectedYear.ReorderClassLetters();

            MessageBox.Show("Turma removida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateListView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new Form_AddClassRooms().ShowDialog();
            UpdateListView();
        }

        private void lsvCheckClassRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvCheckClassRoom.SelectedIndices.Count > 0)
            {
                btnRemove.Enabled = true;
            }
            else
            {
                btnRemove.Enabled = false;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "JSON Files (*.json)|*.json|XML Files (*.xml)|*.xml";
                dialog.Title = "Escolher ficheiro de turmas";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var importManager = new ImportManager();
                    ImportResult result;

                    if (dialog.FileName.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
                        result = importManager.ImportarTurmasJSON(dialog.FileName);
                    else
                        result = importManager.ImportarTurmasXML(dialog.FileName);

                    // Mostrar resultado
                    MessageBox.Show(
                        $"Turmas importadas: {result.ImportedCount}\nErros: {result.Errors.Count}",
                        "Resultado da Importação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    if (result.Errors.Count > 0)
                    {
                        var erros = string.Join("\n", result.Errors);
                        MessageBox.Show(erros, "Erros Detalhados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            UpdateListView();

        }
    }
}
