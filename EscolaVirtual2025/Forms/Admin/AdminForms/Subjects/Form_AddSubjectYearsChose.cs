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

namespace EscolaVirtual2025.Forms.Admin.AdminForms.ClassRooms
{
    public partial class Form_AddSubjectYearsChose : MaterialForm
    {
        private  bool m_subjectYearsChosen;
        private Subject m_subject;
        public bool SubjectYearsChosen
        {
            get
            {
                return m_subjectYearsChosen;
            }
            set
            {
                m_subjectYearsChosen = value;
            }
        }

        public Subject p_Subject
        {
            get { return m_subject; }
            set { m_subject = value; }
        }
            
        public Form_AddSubjectYearsChose(Subject subject)
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

            p_Subject= subject;
            SubjectYearsChosen = false;
        }

        private void Form_AddSubjectYearsChose_Load(object sender, EventArgs e)
        {
            foreach (Year yr in Program.Anos.OrderBy(y => y.AnoId).ToList())
            {
                lsvCheckYears.Items.Add(yr.AnoId.ToString() + "º");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lsvCheckYears_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (lsvCheckYears.CheckedItems.Count > 0)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled=false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            p_Subject.Years.Clear();
            foreach (ListViewItem item in lsvCheckYears.CheckedItems)
            {
                int anoId = Convert.ToInt32(item.Text.Replace("º", ""));
                var year = Program.Anos.FirstOrDefault(y => y.AnoId == anoId);
                p_Subject.Years.Add(year);
            }
            SubjectYearsChosen = true;
            this.Close();
        }

        private void Form_AddSubjectYearsChose_VisibleChanged(object sender, EventArgs e)
        {
            lsvCheckYears.Items.Clear();
            foreach (Year yr in Program.Anos.OrderBy(y => y.AnoId).ToList())
            {
                lsvCheckYears.Items.Add(yr.AnoId.ToString() + "º");
            }

            for (int i = 0; i < p_Subject.Years.Count; i++)
            {
                for (int j = 0; j < lsvCheckYears.Items.Count; j++)
                {
                    int itemAnoId = int.Parse(lsvCheckYears.Items[j].Text.Replace("º", ""));
                    if (p_Subject.Years[i].AnoId == itemAnoId)
                    {
                        lsvCheckYears.Items[j].Checked = true;
                    }
                }
            }
        }
    }
}
