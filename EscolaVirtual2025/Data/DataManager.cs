// Adicionar este using se HistoricoService não estiver no mesmo namespace!
// Exemplo:
// using SeuProjeto.Services; 

using EscolaVirtual2025.Classes;
using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Users;
using System.Collections.Generic;

namespace EscolaVirtual2025.Data
{
    public static class DataManager
    {

        //lista global de users
        public static List<User> Users;

        //lista global de anos
        public static List<Year> Years;

        //lista global disciplinas
        public static List<Subject> Subjects;

        //lista global de professores
        public static List<Teacher> Teachers;

        //lista global de alunos
        public static List<Student> Students;

        //lista global de turmas
        public static List<ClassRoom> ClassRooms;

        public static List<SchoolCard> SchoolCards;

        //Lista global de Disciplinas para a turma
        public static List<ClassSubject> ClassSubjects;

        public static List<Grade> Grades;

        //
        public static User currentUser;

        static DataManager()
        {
            Users = new List<User>();
            Years = new List<Year>();
            Subjects = new List<Subject>();
            Teachers = new List<Teacher>();
            Students = new List<Student>();
            ClassRooms = new List<ClassRoom>();
            SchoolCards = new List<SchoolCard>();
            ClassSubjects = new List<ClassSubject>();
            Grades = new List<Grade>();
            currentUser = null;
        }

    }
}