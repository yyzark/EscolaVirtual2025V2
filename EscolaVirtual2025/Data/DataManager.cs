using EscolaVirtual2025.Classes;
using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Chat;
using EscolaVirtual2025.Classes.Users;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

// Adicionar este using se HistoricoService não estiver no mesmo namespace!
// Exemplo:
// using SeuProjeto.Services; 

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
        // ADIÇÕES NECESSÁRIAS:

        // 1. Acesso ao ID do Professor Logado (valor de exemplo: 1)
        public static int CurrentProfessorId { get; set; } = 1;

        // 2. Instância do Serviço de Histórico (JSON)
        // Isso inicializa o serviço e carrega o 'historico.json' na memória.
        public static HistoricoService HistoricoManager { get; } = new HistoricoService();

        // --------------------------------------------------------------------

        public static void Save()
        {
            Directory.CreateDirectory(saveFolder);

            // O código existente continua a guardar dados em XML:
            SaveXML(Program.Users, "users.xml");
            SaveXML(Program.Anos, "anos.xml");
            SaveXML(Program.Subjects, "subjects.xml");
            SaveXML(Program.Teachers, "teachers.xml");
            SaveXML(Program.students, "students.xml");
            SaveXML(Program.ClassRooms, "classrooms.xml");

            ChatManager.SaveXML();

            // NOTA: O histórico é guardado automaticamente pelo HistoricoManager.AdicionarEGravarAlteracao()
            // por isso não precisa de uma linha extra de Save aqui.
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

            // NOTA: O Histórico é carregado automaticamente na inicialização do HistoricoManager.
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

            // Verificação de segurança (Opcional, mas útil)
            var fileInfo = new FileInfo(path);
            if (fileInfo.Length == 0)
            {
                // Se o ficheiro estiver vazio (0 bytes), retorna default
                return default;
            }

            var serializer = new DataContractSerializer(typeof(T), settings);

            // Adicione um bloco try-catch aqui para capturar o System.Xml.XmlException 
            // e retornar 'default' em caso de corrupção.
            try
            {
                using (var stream = new FileStream(path, FileMode.Open))
                    return (T)serializer.ReadObject(stream);
            }
            catch (System.Xml.XmlException ex)
            {
                Console.WriteLine($"Erro de XML no ficheiro {filename}: {ex.Message}. A carregar dados vazios.");
                return default;
            }
        }
    }
}