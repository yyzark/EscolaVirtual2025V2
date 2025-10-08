using EscolaVirtual2025.Classes;
using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Users;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace EscolaVirtual2025
{
    public partial class Form_Login : MaterialForm
    {
        //contador de tentativas falhadas
        int attempts = 0;

        public Form_Login()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
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

            DefaultProps();
            #region placeholders
            txtLogin.Text = "Login";
            txtLogin.ForeColor = Color.Gray;

            txtPassword.Text = "Senha";
            txtPassword.ForeColor = Color.Gray;
            txtPassword.UseSystemPasswordChar = false;

            // Eventos
            txtLogin.Enter += (s, e) =>
            {
                if (txtLogin.Text == "Nome de utilizador")
                {
                    txtLogin.Text = "";
                    txtLogin.ForeColor = Color.Black;
                }
            };

            txtLogin.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtLogin.Text))
                {
                    txtLogin.Text = "Nome de utilizador";
                    txtLogin.ForeColor = Color.Gray;
                }
            };

            txtPassword.Enter += (s, e) =>
            {
                if (txtPassword.Text == "Senha")
                {
                    txtPassword.Text = "";
                    txtPassword.ForeColor = Color.Black;
                    txtPassword.PasswordChar = '*'; // ativa a senha
                }
            };

            txtPassword.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    txtPassword.Text = "Senha";
                    txtPassword.ForeColor = Color.Gray;
                    txtPassword.PasswordChar = '*'; // mostra texto
                }
            };
            #endregion
        }

        //Propriedades por defeito
        private void DefaultProps()
        {
            lblTitle.Font = new Font("Calibri", 36F, FontStyle.Regular);
            txtLogin.Font = new Font("Calibri", 14.25F, FontStyle.Regular);
            txtPassword.Font = new Font("Calibri", 14.25F, FontStyle.Regular);
            lblLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            lblPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            btnEnter.Font = new Font("Calibri", 26.25F, FontStyle.Regular);
            lblAlert.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            lblAlert.ForeColor = Color.OrangeRed;
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            #region inicialização das listas globais
            Program.Users = new List<User>();
            Program.Anos = new List<Year>();
            Program.Subjects = new List<Subject>();
            Program.Teachers = new List<Teacher>();
            Program.students = new List<Student>();
            Program.ClassRooms = new List<ClassRoom>();
            #endregion

            #region posição e tamanho dos controlos
            //posição dos controlos no centro
            lblTitle.Location = new Point((this.Width - lblTitle.Width) / 2, 75);

            //login
            txtLogin.Location = new Point((this.Width - txtLogin.Width) / 2, 175);
            
            lblLogin.Location = new Point(txtLogin.Location.X, txtLogin.Location.Y - 30);
            //password
            txtPassword.Location = new Point((this.Width - txtPassword.Width) / 2, 245);

            lblPassword.Location = new Point(txtPassword.Location.X, txtPassword.Location.Y - 30);
            //butao entrar
            btnEnter.Location = new Point((this.Width - btnEnter.Width) / 2, (this.Height - 85));
            #endregion


            //add do admin
            Program.Users.Add(new User("JC", "GOAT","Jorge Carvalho", Classes.UserType.Admin));

            #region Credenciais Iniciais (probably apagar depois)            
            string cred = File.ReadLines("Credenciais_Admin\\Admin.txt").First();
            txtLogin.Text = cred.Split(' ')[0];
            txtPassword.Text = cred.Split(' ')[1];
            #endregion

            #region anos e disciplinas default
            //criacao dos anos
            Program.Anos.Add(new Year(10));
            Program.Anos.Add(new Year(11));

            //criacao das disciplinas
            Program.Subjects.Add(new Subject("Matemática", "MAT", 1));
            Program.Subjects.Add(new Subject("Português", "POR", 2));
            Program.Subjects.Add(new Subject("Inglês", "ING", 3));
            Program.Subjects.Add(new Subject("Física e Química", "FQ", 4));
            Program.Subjects.Add(new Subject("História", "HST", 5));

            Program.Anos[0].Subjects.AddRange(Program.Subjects);
            Program.Anos[1].Subjects.AddRange(Program.Subjects);

            #endregion
        }

        private void Form_Login_SizeChanged(object sender, EventArgs e)
        {
            //pos dos controlos no centro
            lblTitle.Location = new Point((this.Width - lblTitle.Width) / 2, 75);
            //alerta
            lblAlert.Location = new Point((this.Width - lblAlert.Width) / 2, (this.Height - 35));
            //butao
            
            if(this.WindowState == FormWindowState.Maximized)
            {
                btnEnter.Size = new Size(btnEnter.Width, btnEnter.Height + 30);
                btnEnter.Location = new Point((this.Width - btnEnter.Width) / 2, (this.Height - 115));
            }
            else
            {
                btnEnter.Size = new Size(150, 36);
                btnEnter.Location = new Point((this.Width - btnEnter.Width) / 2, (this.Height - 85));
            }
            //


        }

        private async void btnEnter_Click(object sender, EventArgs e)
        {
            //verificar se o user existe
            User user = Program.Users.FirstOrDefault(usr => usr.Username == txtLogin.Text && usr.Password == txtPassword.Text);

            if (user == null) //password ou login incorretos
            {
                txtLogin.Focus();
                //desligar butao apos 5 tentativas falhadas
                attempts++;
                if (attempts >= 5)
                {
                    btnEnterBlock();
                }
                else
                {
                    //alerta
                    lblAlert.Text = "Login ou password incorretos.";

                    lblAlert.PerformLayout();
                    lblAlert.Update();



                    lblAlert.Left = (this.ClientSize.Width - lblAlert.Width) / 2;
                    lblAlert.Top = this.ClientSize.Height - 35;
                    lblAlert.Visible = true;

                    txtLogin.Text = "";
                    txtPassword.Text = "";

                    await Task.Delay(2000);
                    lblAlert.Visible = false;
                }
            }
            else if (user.UserType == Classes.UserType.Admin)
            {
                //abrir form admin
                Program.userAtual = user;
                Forms.Admin.Form_Admin formAdmin = new Forms.Admin.Form_Admin();
                this.Hide();
                formAdmin.Show();

                //limpar campos
                txtLogin.Text = "";
                txtPassword.Text = "";
            }
            else if (user.UserType == Classes.UserType.Teacher)
            {
            }
            else if (user.UserType == Classes.UserType.Student)
            {

            }
        }

        //Bloqueio do botão entrar apos 5 tentativas falhadas
        private async void btnEnterBlock()
        {
            attempts = 0;
            btnEnter.Enabled = false;

            //alerta
            lblAlert.Text = "Muitas tentativas falhadas. Tente novamente mais tarde.";
            lblAlert.PerformLayout();
            lblAlert.Update();
            lblAlert.Left = (this.ClientSize.Width - lblAlert.Width) / 2;
            lblAlert.Top = this.ClientSize.Height - 35;

            lblAlert.Visible = true;
            await Task.Delay(6000);
            lblAlert.Visible = false;

            btnEnter.Enabled = true;
        }

        private async void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Utils.IsAllowedCharacter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                //alerta
                lblAlert.Text = "Caracteres especiais não são permitidos.";

                lblAlert.PerformLayout();
                lblAlert.Update();

                lblAlert.Left = (this.ClientSize.Width - lblAlert.Width) / 2;

                lblAlert.Top = this.ClientSize.Height - 35;

                lblAlert.Visible = true;
                await Task.Delay(2000);
                lblAlert.Visible = false;
            }
        }

        private async void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Utils.IsAllowedCharacter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                //alerta
                lblAlert.Text = "Caracteres especiais não são permitidos.";

                lblAlert.PerformLayout();
                lblAlert.Update();

                lblAlert.Left = (this.ClientSize.Width - lblAlert.Width) / 2;

                lblAlert.Top = this.ClientSize.Height - 35;

                lblAlert.Visible = true;
                await Task.Delay(2000);
                lblAlert.Visible = false;
            }
        }

        private void Form_Login_Activated(object sender, EventArgs e)
        {
            DefaultProps();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            TextBox[] txt = { txtLogin, txtPassword };
            TextBox IsEmpty = txt.FirstOrDefault(tx => tx.Text == string.Empty);
            if(IsEmpty != null)
            {                   
                btnEnter.Enabled = false;
            }
            else
            {
                btnEnter.Enabled = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            TextBox[] txt = { txtLogin, txtPassword };
            TextBox IsEmpty = txt.FirstOrDefault(tx => tx.Text == string.Empty);
            if (IsEmpty != null)
            {
                btnEnter.Enabled = false;
            }
            else
            {
                btnEnter.Enabled = true;
            }
        }

        private void Form_Login_Shown(object sender, EventArgs e)
        {
        }

        private void Form_Login_VisibleChanged(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}
