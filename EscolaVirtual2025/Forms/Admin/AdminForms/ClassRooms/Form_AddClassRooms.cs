using EscolaVirtual2025.Classes;
using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Data;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EscolaVirtual2025.Forms.Admin.AdminForms.ClassRooms
{
    public partial class Form_AddClassRooms : MaterialForm
    {
        public Form_AddClassRooms()
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

        private void cbbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbYear.SelectedIndex != -1)
            {
                cbbYear.ForeColor = Color.Black;
                cbbYear.DropDownStyle = ComboBoxStyle.DropDownList;
                btnAccept.Enabled = true;
            }
            else
            {
                cbbYear.Text = "Ano";
                cbbYear.ForeColor = Color.Gray;
                cbbYear.DropDownStyle = ComboBoxStyle.DropDown;
                btnAccept.Enabled = false;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            // Verifica se o utilizador selecionou um ano
            if (cbbYear.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Por favor, selecione um ano antes de adicionar uma turma.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            Year selectedYear = DataManager.Years[cbbYear.SelectedIndex];
            char classLetter = Utils.alphabet[selectedYear.ClassRooms.Items.Count];

            // Mostra a caixa de confirmação
            DialogResult result = MessageBox.Show(
                $"Tem a certeza que deseja adicionar a turma \"{classLetter}\" ao ano {selectedYear.Id}?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                ClassRoom newClassRoom = new ClassRoom(classLetter, selectedYear, DataManager.ClassRooms.Count);

                // Cria e adiciona a turma
                selectedYear.ClassRooms.Add(newClassRoom);

                MessageBox.Show(
                    $"Turma \"{classLetter}\" adicionada com sucesso ao ano {selectedYear.Id}.",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                //DataManager.Save();
                this.Close();
            }
        }

        private void Form_AddClassRooms_Shown(object sender, EventArgs e)
        {
            DataManager.Years.OrderBy(yr => yr.Id);
            cbbYear.Items.AddRange(DataManager.Years.Select(yr => yr.Id.ToString()).ToArray());
            cbbYear.Text = "Ano";
            cbbYear.ForeColor = Color.Gray;
        }
    }
}
