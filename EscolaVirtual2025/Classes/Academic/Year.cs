using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual2025.Classes.Academic
{
    public class Year
    {
        private int anoId;

        private List<ClassRoom> m_turmas = new List<ClassRoom>();

        private List<Subject> m_subjects = new List<Subject>();
        public List<Subject> Subjects
        {
            get { return m_subjects; }
            set { m_subjects = value; }
        }
        public List<ClassRoom> ClassRooms
        {
            get { return m_turmas; }
            set { m_turmas = value; }
        }
        public int AnoId
        {
            get { return anoId; }
            set { anoId = value; }
        }

        public Year(int AnoId)
        {
            this.anoId = AnoId;
        }

        public void ReorderClassLetters()
        {
            ClassRooms = ClassRooms.OrderBy(c => c.Id).ToList();

            for (int i = 0; i < ClassRooms.Count; i++)
            {
                ClassRooms[i].Id = Utils.alphabet[i];
            }
        }
    }
}
