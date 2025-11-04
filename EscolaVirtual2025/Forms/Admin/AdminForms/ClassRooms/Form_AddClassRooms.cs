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
using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes;

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

        private void Form_AddClassRooms_Load(object sender, EventArgs e)
        {
            Program.Anos.Sort((a, b) => a.AnoId.CompareTo(b.AnoId));
            cbbYear.Items.AddRange(Program.Anos.Select(yr => yr.AnoId.ToString()).ToArray());
            cbbYear.Text = "Ano";
            cbbYear.ForeColor = Color.Gray;
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

            Year selectedYear = Program.Anos[cbbYear.SelectedIndex];
            char classLetter = Utils.alphabet[selectedYear.ClassRooms.Count];

            // Mostra a caixa de confirmação
            DialogResult result = MessageBox.Show(
                $"Tem a certeza que deseja adicionar a turma \"{classLetter}\" ao ano {selectedYear.AnoId}?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                ClassRoom newClassRoom = new ClassRoom(classLetter, selectedYear);

                // Cria e adiciona a turma
                selectedYear.ClassRooms.Add(newClassRoom);
                Program.ClassRooms.Add(newClassRoom);
                
                MessageBox.Show(
                    $"Turma \"{classLetter}\" adicionada com sucesso ao ano {selectedYear.AnoId}.",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                Program.Save();
                this.Close();
            }
        }
    }
}
