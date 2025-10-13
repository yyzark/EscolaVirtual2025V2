using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Chat;
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

namespace EscolaVirtual2025.Forms.TeacherForms.TeacherChat
{
    public partial class Form_TeacherChat : MaterialForm
    {
        private List<Chat> m_currentChats = new List<Chat>();
        private Teacher m_teacher;
        private List<ClassRoom> m_classRooms = new List<ClassRoom>();
        public Form_TeacherChat(Teacher teacher)
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

            m_teacher = teacher;
        }

        private void Form_TeacherChat_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;

            // Carregar as turmas atribuídas ao professor
            m_classRooms = m_teacher.AssignedClassRooms ?? new List<ClassRoom>();

            // Popular anos (exemplo: 7º, 8º, 9º)
            var anos = m_classRooms
                .Select(c => c.Year.AnoId)
                .Distinct()
                .OrderBy(a => a)
                .ToList();

            cbbAnos.Items.Clear();
            foreach (var ano in anos)
                cbbAnos.Items.Add(ano);

            listBox1.Items.Clear();
        }


        private void cbbAnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbAnos.SelectedIndex == -1)
            {
                cbbTurmas.Enabled = false;
            }
            else
            {
                string selectedYear = cbbAnos.SelectedItem.ToString();

                var turmasDoAno = m_classRooms
                    .Where(c => c.Year.AnoId.ToString() == selectedYear)
                    .Select(c => c.Id)
                    .Distinct()
                    .ToList();

                cbbTurmas.Items.Clear();
                foreach (var turma in turmasDoAno)
                    cbbTurmas.Items.Add(turma);

                cbbTurmas.Enabled = true;

                listBox1.Items.Clear();
            }
        }

        private void cbbTurmas_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }
        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            m_currentChats.Clear();

            if (cbbAnos.SelectedItem == null || cbbTurmas.SelectedItem == null) return;

            string selectedYear = cbbAnos.SelectedItem.ToString();
            string selectedClass = cbbTurmas.SelectedItem.ToString();

            var turma = m_classRooms.FirstOrDefault(c => c.Year.AnoId.ToString() == selectedYear && c.Id.ToString() == selectedClass);
            if (turma == null || turma.Students == null) return;

            // Mostra alunos dessa turma
            foreach (var student in turma.Students)
            {
                if(student == null) continue;
                // Cria ou obtém o chat
                Chat chat = ChatManager.GetOrCreateChat(m_teacher, student);
                m_currentChats.Add(chat);
                listBox1.Items.Add(student.Name);
            }
        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index < 0 || index >= m_currentChats.Count) return;

            Chat chat = m_currentChats[index];
            Form_Chat chatForm = new Form_Chat(chat);
            chatForm.ShowDialog();
        }
    }
}
