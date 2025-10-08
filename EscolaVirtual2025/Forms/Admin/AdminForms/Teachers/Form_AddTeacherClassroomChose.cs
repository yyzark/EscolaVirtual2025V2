using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Users;
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

namespace EscolaVirtual2025.Forms.Admin.AdminForms.Teachers
{
    public partial class Form_AddTeacherClassroomChose : MaterialForm
    {
        private Teacher m_teacher;
        private bool m_teacherClassroomsChosen;

        public bool TeacherClassroomsChosen
        {
            get { return m_teacherClassroomsChosen; }
            set { m_teacherClassroomsChosen = value; }
        }

        public Teacher p_Teacher
        {
            get { return m_teacher; }
            set { m_teacher = value; }
        }

        public Form_AddTeacherClassroomChose(Teacher teacher)
        {
            InitializeComponent();

            #region MaterialSkin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red300,
                Primary.Red700,
                Primary.Red100,
                Accent.Orange200,
                TextShade.WHITE
            );
            #endregion

            p_Teacher = teacher;
            TeacherClassroomsChosen = false;
        }

        private void Form_AddTeacherClassroomChose_Load(object sender, EventArgs e)
        {
            LoadClassSubjects();
        }

        private void LoadClassSubjects()
        {
            lsvCheckClassRooms.Items.Clear();

            // percorre todas as turmas
            foreach (var cls in Program.ClassRooms.OrderBy(c => c.Year.AnoId).ThenBy(c => c.Id))
            {
                foreach (var classSub in cls.Subjects)
                {
                    string display = $"{cls.Year.AnoId}º{cls.Id} - {classSub.Subject.Name}";
                    var item = new ListViewItem(display);
                    item.Tag = classSub;

                    // marca se já tiver este teacher atribuído
                    if (classSub.AssignedTeacher != null && classSub.AssignedTeacher == p_Teacher)
                        item.Checked = true;

                    lsvCheckClassRooms.Items.Add(item);
                }
            }
        }

        private void lsvCheckClassRooms_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            btnAdd.Enabled = lsvCheckClassRooms.CheckedItems.Count > 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Primeiro, remove o teacher das que estavam atribuídas antes
            foreach (var cls in Program.ClassRooms)
            {
                foreach (var cs in cls.Subjects)
                {
                    if (cs.AssignedTeacher == p_Teacher)
                        cs.AssignedTeacher = null;
                }
            }

            // Depois, atribui o teacher às novas selecionadas
            foreach (ListViewItem item in lsvCheckClassRooms.CheckedItems)
            {
                var classSub = (ClassSubject)item.Tag;
                classSub.AssignedTeacher = p_Teacher;
            }

            TeacherClassroomsChosen = true;
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Limpa todas as ligações deste teacher
            foreach (var cls in Program.ClassRooms)
            {
                foreach (var cs in cls.Subjects)
                {
                    if (cs.AssignedTeacher == p_Teacher)
                        cs.AssignedTeacher = null;
                }
            }

            TeacherClassroomsChosen = false;
            this.Close();
        }

        private void Form_AddTeacherClassroomChose_VisibleChanged(object sender, EventArgs e)
        {
            LoadClassSubjects();
        }
    }
    
}
