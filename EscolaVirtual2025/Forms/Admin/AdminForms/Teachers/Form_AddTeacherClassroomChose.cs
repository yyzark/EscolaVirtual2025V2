using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Users;
using EscolaVirtual2025.Data;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EscolaVirtual2025.Forms.Admin.AdminForms.Teachers
{
    public partial class Form_AddTeacherClassroomChose : MaterialForm
    {
        private Teacher m_teacher;
        private bool m_teacherClassroomsChosen;
        private Subject m_subject;
        private bool m_edit;
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
        public Form_AddTeacherClassroomChose(Teacher teacher, bool edit)
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
            m_edit = edit;
            m_subject = teacher.AssignedSubject;
        }

        private void Form_AddTeacherClassroomChose_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        public void UpdateListView()
        {
            lsvCheckClassRooms.Items.Clear();
            foreach (var classroom in DataManager.ClassRooms)
            {
                // Check if this classroom has the selected subject
                bool hasSubject = classroom.ClassSubjects.Items.Any(s => s.Id == p_Subject.Id && s.Teacher == null || s.Teacher != m_teacher);
                if (!hasSubject)
                    continue;

                // Create ListViewItem
                var item = new ListViewItem(classroom.Year.Id + "º" + classroom.Letter);

                if (p_Teacher.AssignedClassRooms != null)
                {
                    // Optionally mark if the teacher already teaches in this classroom
                    bool alreadyAssigned = p_Teacher.AssignedClassRooms.Items.Any(c => c.Id == classroom.Id);
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
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Limpa qualquer ligação anterior desse professor à disciplina em outras turmas (opcional)
            foreach (var classroom in DataManager.ClassRooms)
            {
                foreach (var classSubject in classroom.ClassSubjects.Items)
                {
                    // Se a disciplina for a mesma, e o professor for este, limpa
                    if (classSubject.Id == p_Subject.Id && classSubject.Teacher == p_Teacher)
                    {
                        classSubject.Teacher = null;
                    }
                }
            }

            // Agora atribui o professor às turmas selecionadas
            foreach (ListViewItem item in lsvCheckClassRooms.Items)
            {
                // Extrai o ID da turma a partir do texto (supondo que o texto contém o ID)
                string itemText = item.Text;
                var classroom = DataManager.ClassRooms.FirstOrDefault(c => itemText.Contains(c.Id.ToString()));

                if (classroom == null)
                    continue;

                // Se a turma está marcada (checked), liga o professor à disciplina
                if (item.Checked)
                {
                    var classSubject = classroom.ClassSubjects.Items.FirstOrDefault(s => s.Id == p_Subject.Id);
                    if (classSubject != null)
                    {
                        classSubject.Teacher = p_Teacher;

                        // Garante que o professor saiba onde ensina (caso uses esta lista em algum lugar)
                        if (!p_Teacher.AssignedClassRooms.Items.Contains(classroom))
                            p_Teacher.AssignedClassRooms.Add(classroom);
                    }
                }
                else
                {
                    // Se desmarcada, remove a ligação (se existir)
                    var classSubject = classroom.ClassSubjects.Items.FirstOrDefault(s => s.Id == p_Subject.Id);
                    if (classSubject != null && classSubject.Teacher == p_Teacher)
                    {
                        classSubject.Teacher = null;
                    }

                    p_Teacher.AssignedClassRooms.RemoveAll(c => c.Id == classroom.Id);
                }
            }

            TeacherClassroomsChosen = true;
            this.Close();
        }
        private void lsvCheckClassRooms_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (m_edit)
            {
                bool canEnableAdd = false;

                foreach (ListViewItem lsvItem in lsvCheckClassRooms.CheckedItems)
                {
                    string[] parts = lsvItem.Text.Split('º');
                    int Id = Convert.ToInt32(parts[0].Trim());
                    string turmaNome = parts[1].Trim();

                    bool jaAtribuida = m_teacher.AssignedClassRooms.Items.Any(clsrm =>
                        clsrm.Year.Id == Id &&
                        clsrm.Id.ToString().Equals(turmaNome));

                    if (!jaAtribuida)
                    {
                        canEnableAdd = true;
                        break;
                    }
                }

                btnAdd.Enabled = canEnableAdd;
            }
            else
            {
                btnAdd.Enabled = lsvCheckClassRooms.CheckedItems.Count > 0;
            }
        }

        private void Form_AddTeacherClassroomChose_VisibleChanged(object sender, EventArgs e)
        {
            UpdateListView();
        }

        public void ResetListView()
        {
            p_Teacher.AssignedClassRooms.Clear();
            foreach (ListViewItem checkedItem in lsvCheckClassRooms.CheckedItems)
            {
                checkedItem.Checked = false;
            }
        }
    }
}
