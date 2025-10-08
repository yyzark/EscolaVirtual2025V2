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



namespace EscolaVirtual2025.Forms.Admin.AdminForms.YearForms
{
    public partial class Form_CheckYears : MaterialForm
    {
        public Form_CheckYears()
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

        private void Form_CheckYears_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void UpdateListView()
        {
            lsvCheckAno.Items.Clear();
            foreach (int idAno in Program.Anos.OrderBy(yr => yr.AnoId).Select(yr => yr.AnoId))
            {
                lsvCheckAno.Items.Add(new ListViewItem(idAno.ToString()));
            }
            if (lsvCheckAno.Items.Count <= 0)
            {
                btnRemove.Enabled = false;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_AddYear form_AddYear = new Form_AddYear();
            form_AddYear.ShowDialog();
            UpdateListView();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lsvCheckAno.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um ano para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            var selectedItem = lsvCheckAno.SelectedItems[0];
            int anoId = Convert.ToInt32(selectedItem.Text);

            // Confirmação
            var confirm = MessageBox.Show($"Tem certeza que deseja remover o ano {anoId}?",
                                          "Confirmação",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                // Remove da lista global
                var anoToRemove = Program.Anos.FirstOrDefault(a => a.AnoId == anoId);
                if (anoToRemove != null)
                {
                    Program.Anos.Remove(anoToRemove);
                }

                MessageBox.Show($"Ano {anoId} removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            UpdateListView();
        }
    }
}
