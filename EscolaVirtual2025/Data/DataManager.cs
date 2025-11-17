using EscolaVirtual2025.Classes;
using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Chat;
using EscolaVirtual2025.Classes.Users;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

namespace EscolaVirtual2025.Data
{
    internal static class DataManager
    {
        private static readonly string documentsPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        private static readonly string saveFolder =
            Path.Combine(documentsPath, "EscolaData_XML");

        private static readonly DataContractSerializerSettings settings =
            new DataContractSerializerSettings
            {
                PreserveObjectReferences = true
            };

        // --------------------------------------------------------------------
        public static void Save()
        {
            Directory.CreateDirectory(saveFolder);

            SaveXML(Program.Users, "users.xml");
            SaveXML(Program.Anos, "anos.xml");
            SaveXML(Program.Subjects, "subjects.xml");
            SaveXML(Program.Teachers, "teachers.xml");
            SaveXML(Program.students, "students.xml");
            SaveXML(Program.ClassRooms, "classrooms.xml");

            ChatManager.SaveXML();
        }

        public static void Load()
        {
            Directory.CreateDirectory(saveFolder);

            Program.Users = LoadXML<List<User>>("users.xml") ?? new List<User>();
            Program.Anos = LoadXML<List<Year>>("anos.xml") ?? new List<Year>();
            Program.Subjects = LoadXML<List<Subject>>("subjects.xml") ?? new List<Subject>();
            Program.Teachers = LoadXML<List<Teacher>>("teachers.xml") ?? new List<Teacher>();
            Program.students = LoadXML<List<Student>>("students.xml") ?? new List<Student>();
            Program.ClassRooms = LoadXML<List<ClassRoom>>("classrooms.xml") ?? new List<ClassRoom>();

            ChatManager.LoadXML();
        }

        // --------------------------------------------------------------------
        private static void SaveXML<T>(T data, string filename)
        {
            var path = Path.Combine(saveFolder, filename);
            var serializer = new DataContractSerializer(typeof(T), settings);

            using (var stream = new FileStream(path, FileMode.Create))
                serializer.WriteObject(stream, data);
        }

        private static T LoadXML<T>(string filename)
        {
            var path = Path.Combine(saveFolder, filename);
            if (!File.Exists(path))
                return default;

            var serializer = new DataContractSerializer(typeof(T), settings);

            using (var stream = new FileStream(path, FileMode.Open))
                return (T)serializer.ReadObject(stream);
        }
    }
}
