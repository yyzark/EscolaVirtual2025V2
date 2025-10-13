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
            for (int i = 0; i < Program.Anos.Count; i++)
            {
                foreach (char idTurma in Program.Anos[i].ClassRooms.OrderBy(clsrm => clsrm.Id).Select(clsrm => clsrm.Id))
                {
                    ListViewItem itemTurma = new ListViewItem();
                    itemTurma.Text = Program.Anos[i].AnoId+ "º" + idTurma;
                    lsvCheckClassRoom.Items.Add(itemTurma);
                }
                if (lsvCheckClassRoom.Items.Count <= 0)
                {
                    btnRemove.Enabled = false;
                }
            }

            foreach (ColumnHeader col in lsvCheckClassRoom.Columns)
                col.Width = -2; // auto resize

            if( Program.Anos.Count == 0 )
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

            var selectedYear = Program.Anos.FirstOrDefault(a => a.AnoId == yearId);
            var classRoomToRemove = selectedYear.ClassRooms.FirstOrDefault(cls => cls.Id == selectedLetter);

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

                Program.Users.Remove(student);
                Program.students.Remove(student);

                // Limpa referência na turma
                classRoomToRemove.Students[i] = null;
            }

            // Remove a turma
            selectedYear.ClassRooms.Remove(classRoomToRemove);
            Program.ClassRooms.Remove(classRoomToRemove);

            selectedYear.ReorderClassLetters();

            MessageBox.Show("Turma removida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateListView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_AddClassRooms form_AddClassRooms = new Form_AddClassRooms();
            form_AddClassRooms.ShowDialog();
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
    }
}
