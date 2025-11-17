using EscolaVirtual2025;
using EscolaVirtual2025.Classes;
using EscolaVirtual2025.Classes.Chat;
using EscolaVirtual2025.Classes.Users;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

internal static class ChatManager
{
    public static List<Chat> Chats = new List<Chat>();

    private static readonly string documentsPath =
        Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    private static readonly string saveFolder =
        Path.Combine(documentsPath, "EscolaData_XML");
    private static readonly string chatFile =
        Path.Combine(saveFolder, "chats.xml");

    private static readonly DataContractSerializerSettings settings =
        new DataContractSerializerSettings
        {
            PreserveObjectReferences = true
        };

    // ---------- MÉTODOS EXISTENTES ----------
    public static Chat GetOrCreateChat(Teacher teacher, Student student)
    {
        var chat = Chats.FirstOrDefault(c => c.Teacher == teacher && c.Student == student);
        if (chat == null)
        {
            chat = new Chat(teacher, student);
            Chats.Add(chat);
        }
        return chat;
    }

    public static Chat SendGetNotificationFromAdmin(User teacherStudent)
    {
        Chat chat = null;
        User admin = Program.Users[0];

        if (teacherStudent.UserType == UserType.Student)
        {
            var student = teacherStudent as Student;
            chat = Chats.FirstOrDefault(c => c.Admin == admin && c.Student == student);
            if (chat == null)
            {
                chat = new Chat(admin, student);
                Chats.Add(chat);
            }
        }
        else if (teacherStudent.UserType == UserType.Teacher)
        {
            var teacher = teacherStudent as Teacher;
            chat = Chats.FirstOrDefault(c => c.Admin == admin && c.Teacher == teacher);
            if (chat == null)
            {
                chat = new Chat(admin, teacher);
                Chats.Add(chat);
            }
        }

        return chat;
    }

    public static List<Chat> GetChatsByStudent(Student student)
    {
        return Chats.Where(c => c.Student == student).ToList();
    }

    // ---------- NOVOS MÉTODOS XML ----------
    public static void SaveXML()
    {
        Directory.CreateDirectory(saveFolder);
        var serializer = new DataContractSerializer(typeof(List<Chat>), settings);
        using (var stream = new FileStream(chatFile, FileMode.Create))
            serializer.WriteObject(stream, Chats);
    }

    public static void LoadXML()
    {
        if (!File.Exists(chatFile))
        {
            Chats = new List<Chat>();
            return;
        }

        var serializer = new DataContractSerializer(typeof(List<Chat>), settings);
        using (var stream = new FileStream(chatFile, FileMode.Open))
            Chats = (List<Chat>)serializer.ReadObject(stream);
    }
}