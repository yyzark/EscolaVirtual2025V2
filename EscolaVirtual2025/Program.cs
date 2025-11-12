using EscolaVirtual2025.Classes;
using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Chat;
using EscolaVirtual2025.Classes.Users;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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


        // 🔹 Caminho base na pasta "Documents"
        private static readonly string documentsPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private static readonly string saveFolder =
            Path.Combine(documentsPath, "EscolaData"); // Subpasta

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

        public static void Save()
        {
            Directory.CreateDirectory(saveFolder);

            var options = new System.Text.Json.JsonSerializerOptions
            {
                WriteIndented = true,
                ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles
            };

            File.WriteAllText(Path.Combine(saveFolder, "users.json"), System.Text.Json.JsonSerializer.Serialize(Users, options));
            File.WriteAllText(Path.Combine(saveFolder, "anos.json"), System.Text.Json.JsonSerializer.Serialize(Anos, options));
            File.WriteAllText(Path.Combine(saveFolder, "subjects.json"), System.Text.Json.JsonSerializer.Serialize(Subjects, options));
            File.WriteAllText(Path.Combine(saveFolder, "teachers.json"), System.Text.Json.JsonSerializer.Serialize(Teachers, options));
            File.WriteAllText(Path.Combine(saveFolder, "students.json"), System.Text.Json.JsonSerializer.Serialize(students, options));
            File.WriteAllText(Path.Combine(saveFolder, "classrooms.json"), System.Text.Json.JsonSerializer.Serialize(ClassRooms, options));
            ChatManager.Save();
        }

        /*public static void Load()
        {
            if (!Directory.Exists(saveFolder))
            {
                Directory.CreateDirectory(saveFolder);

                Users = new List<User>();
                Anos = new List<Year>();
                Subjects = new List<Subject>();
                Teachers = new List<Teacher>();
                students = new List<Student>();
                ClassRooms = new List<ClassRoom>();
                return;
            }

            Users = LoadList<User>("users.json");
            Anos = LoadList<Year>("anos.json");
            Subjects = LoadList<Subject>("subjects.json");
            Teachers = LoadList<Teacher>("teachers.json");
            students = LoadList<Student>("students.json");
            ClassRooms = LoadList<ClassRoom>("classrooms.json");
            ChatManager.Load();
        }

        private static List<T> LoadList<T>(string fileName)
        {
            string filePath = Path.Combine(saveFolder, fileName);
            if (!File.Exists(filePath))
                return new List<T>(); // Devolve uma lista vazia se o arquivo não existir

            string json = File.ReadAllText(filePath);
            return System.Text.Json.JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
        }*/
    }
}
