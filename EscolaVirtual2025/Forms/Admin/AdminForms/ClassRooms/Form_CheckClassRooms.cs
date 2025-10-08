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
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lsvCheckClassRoom.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione uma sala para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtém o ID da sala selecionada
            char selectedId = Convert.ToChar(lsvCheckClassRoom.SelectedItems[0].Text.Split('º')[1]);

            // Procura e remove a sala correspondente
            bool removed = false;

            foreach (var ano in Program.Anos)
            {
                var classRoomToRemove = ano.ClassRooms.FirstOrDefault(cls => cls.Id == selectedId);
                if (classRoomToRemove != null)
                {
                    ano.ClassRooms.Remove(classRoomToRemove);
                    removed = true;
                    break;
                }
            }

            if (removed)
            {
                MessageBox.Show("Sala removida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateListView();
            }
            else
            {
                MessageBox.Show("Não foi possível encontrar a sala selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_AddClassRooms form_AddClassRooms = new Form_AddClassRooms();
            form_AddClassRooms.ShowDialog();
            UpdateListView();
        }

        private void lsvCheckClassRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvCheckClassRoom.SelectedItems[0].Index != -1)
            {
                btnRemove.Enabled = true;
            }
        }
    }
}
