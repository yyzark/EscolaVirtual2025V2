using EscolaVirtual2025.Classes.Academic;
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
    public partial class Form_AddYear : MaterialForm
    {
        public Form_AddYear()
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

        private void Form_AddYear_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            int newYear = (int)numericUpDownYear.Value;

            // Verifica se o ano já existe
            bool exists = Program.Anos.Any(a => a.AnoId == newYear);

            if (exists)
            {
                MessageBox.Show($"O {newYear}º ano já existe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Adiciona o novo ano
            Program.Anos.Add(new Year(newYear));

            MessageBox.Show($"{newYear}º ano adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Program.Anos.Sort((a, b) => a.AnoId.CompareTo(b.AnoId));
            Program.Save();
            this.Close();
        }
    }
}
