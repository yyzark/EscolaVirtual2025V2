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
        private Subject m_subject;
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

        public Subject p_Subject
        {
            get { return m_subject; }
            set { m_subject = value; }
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
            UpdateListView();
        }

        public void UpdateListView()
        {
            foreach (var classroom in Program.ClassRooms)
            {
                // Check if this classroom has the selected subject
                bool hasSubject = classroom.Subjects.Any(s => s.Subject.Id == p_Subject.Id);
                if (!hasSubject)
                    continue;

                // Create ListViewItem
                var item = new ListViewItem(classroom.Year.AnoId + "º" + classroom.Id.ToString());

                if (p_Teacher.AssignedClassRooms != null)
                {
                    // Optionally mark if the teacher already teaches in this classroom
                    bool alreadyAssigned = p_Teacher.AssignedClassRooms.Any(c => c.Id == classroom.Id);
                    if (alreadyAssigned)
                    {
                        item.Checked = true;
                    }
                }

                // Add item to list view
                lsvCheckClassRooms.Items.Add(item);
            }

            // Optional: auto-resize columns for better display
            lsvCheckClassRooms.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            TeacherClassroomsChosen = false;
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Limpa qualquer ligação anterior desse professor à disciplina em outras turmas (opcional)
            foreach (var classroom in Program.ClassRooms)
            {
                foreach (var classSubject in classroom.Subjects)
                {
                    // Se a disciplina for a mesma, e o professor for este, limpa
                    if (classSubject.Subject.Id == p_Subject.Id && classSubject.AssignedTeacher == p_Teacher)
                    {
                        classSubject.AssignedTeacher = null;
                    }
                }
            }

            // Agora atribui o professor às turmas selecionadas
            foreach (ListViewItem item in lsvCheckClassRooms.Items)
            {
                // Extrai o ID da turma a partir do texto (supondo que o texto contém o ID)
                string itemText = item.Text;
                var classroom = Program.ClassRooms.FirstOrDefault(c => itemText.Contains(c.Id.ToString()));

                if (classroom == null)
                    continue;

                // Se a turma está marcada (checked), liga o professor à disciplina
                if (item.Checked)
                {
                    var classSubject = classroom.Subjects.FirstOrDefault(s => s.Subject.Id == p_Subject.Id);
                    if (classSubject != null)
                    {
                        classSubject.AssignedTeacher = p_Teacher;

                        // Garante que o professor saiba onde ensina (caso uses esta lista em algum lugar)
                        if (!p_Teacher.AssignedClassRooms.Contains(classroom))
                            p_Teacher.AssignedClassRooms.Add(classroom);
                    }
                }
                else
                {
                    // Se desmarcada, remove a ligação (se existir)
                    var classSubject = classroom.Subjects.FirstOrDefault(s => s.Subject.Id == p_Subject.Id);
                    if (classSubject != null && classSubject.AssignedTeacher == p_Teacher)
                    {
                        classSubject.AssignedTeacher = null;
                    }

                    p_Teacher.AssignedClassRooms.RemoveAll(c => c.Id == classroom.Id);
                }
            }

            TeacherClassroomsChosen = true;
            this.Close();
        }
        private void lsvCheckClassRooms_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (lsvCheckClassRooms.CheckedItems.Count > 0)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }
    }
}
