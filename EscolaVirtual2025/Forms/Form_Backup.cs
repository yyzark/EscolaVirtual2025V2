using EscolaVirtual2025.Classes.Data;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.IO;
using System.Windows.Forms;

namespace EscolaVirtual2025.Forms
{
    public partial class Form_Backup : MaterialForm
    {
        public Form_Backup()
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

        private void btnPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Escolher pasta para salvar o backup.";

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderDialog.SelectedPath;
                    txtPath.Text = folderPath;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPath.Text) || !Directory.Exists(txtPath.Text))
            {
                MessageBox.Show("Escolha uma pasta válida para salvar o backup.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string backupFile = Path.Combine(txtPath.Text, "EscolaVirtualBackup.xml");

            try
            {
                Backup backup = new Backup();
                backup.CreateXMLBackup(backupFile);

                MessageBox.Show($"Backup criado com sucesso em:\n{backupFile}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar backup: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPath.Text) || !Directory.Exists(txtPath.Text))
            {
                MessageBox.Show("Escolha uma pasta válida para carregar o backup.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string backupFilePath = Path.Combine(txtPath.Text, "EscolaVirtualBackup.xml");

            if (!File.Exists(backupFilePath))
            {
                MessageBox.Show("Arquivo de backup não encontrado na pasta selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult res = MessageBox.Show("Tem a certeza que quer carregar o backup? Todo o progresso sera perdido.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
                try
                {
                    Backup backup = new Backup();
                    backup.LoadXMLBackup(backupFilePath);

                    MessageBox.Show("Backup restaurado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar backup: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}
