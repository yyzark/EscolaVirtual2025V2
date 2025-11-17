using EscolaVirtual2025.Classes;
using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Users;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace EscolaVirtual2025
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        //Declaração do objeto global do form de login
        public static Form_Login formLogin;

        //lista global de users
        public static List<User> Users;

        //lista global de anos
        public static List<Year> Anos;

        //lista global disciplinas
        public static List<Subject> Subjects;

        //lista global de professores
        public static List<Teacher> Teachers;

        //lista global de alunos
        public static List<Student> students;

        //lista global de turmas
        public static List<ClassRoom> ClassRooms;

        //
        public static User userAtual;

        //
        public static int SchoolCardsCounter;


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Lingua em português
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-PT");

            //objeto global do form de login
            formLogin = new Form_Login();


            //temporario para o relatorio do prof


            Application.Run(formLogin);
        }
    }
}
