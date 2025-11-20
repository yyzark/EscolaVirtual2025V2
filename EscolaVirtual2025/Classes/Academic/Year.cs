using EscolaVirtual2025.Classes.InterFace;
using EscolaVirtual2025.Data;

namespace EscolaVirtual2025.Classes.Academic
{
    public class Year
    {
        private int m_yearId;
        public EntityCollection<Subject, int> Subjects = new EntityCollection<Subject, int>(DataManager.Subjects, sb => sb.Id);
        public EntityCollection<ClassRoom, int> ClassRooms = new EntityCollection<ClassRoom, int>(DataManager.ClassRooms, cl => cl.Id);

        public int Id
        {
            get { return m_yearId; }
            set { m_yearId = value; }
        }
        public Year(int yearId)
        {
            this.m_yearId = yearId;
        }

        public Year() { }

        public void ReorderClassLetters()
        {
            ClassRooms.Reorder(cr => cr.Id);
        }
    }

}
