using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Users;
using EscolaVirtual2025.Data;

namespace EscolaVirtual2025.Classes.Data
{
    public class Backup
    {
        #region Backup Lists
        public List<UserData> UsersData = new List<UserData>();
        public List<YearData> YearsData = new List<YearData>();
        public List<ClassRoomData> ClassRoomsData = new List<ClassRoomData>();
        public List<SubjectData> SubjectsData = new List<SubjectData>();
        public List<ClassSubjectData> ClassSubjectsData = new List<ClassSubjectData>();
        public List<GradeData> GradesData = new List<GradeData>();
        public List<SchoolCardData> SchoolCardsData = new List<SchoolCardData>();
        public List<ChatData> ChatsData = new List<ChatData>();
        #endregion

        public void CreateXMLBackup(string path)
        {
            UsersData.Clear();
            YearsData.Clear();
            ClassRoomsData.Clear();
            SubjectsData.Clear();
            ClassSubjectsData.Clear();
            GradesData.Clear();
            SchoolCardsData.Clear();
            ChatsData.Clear();

            foreach (var u in DataManager.Users)
            {
                var ud = new UserData
                {
                    Username = u.Username,
                    Password = u.Password,
                    Name = u.Name,
                    UserType = u.UserType
                };

                if (u is TeacherStudent ts)
                {
                    ud.NIF = ts.NIF;
                    if (u is Student s)
                    {
                        ud.ClassRoomId = s.ClassRoom?.Id ?? 0;
                        ud.SchoolCardId = s.SchoolCard?.SchoolCardId ?? 0;
                        ud.GradeIds = s.Grades.Items.Select(g => g.Id).ToList();
                    }
                    else if (u is Teacher tch)
                    {
                        ud.AssignedSubjectId = tch.AssignedSubject?.Id ?? 0;
                        ud.AssignedClassRoomIds = tch.AssignedClassRooms.Items.Select(cr => cr.Id).ToList();
                    }
                }
                UsersData.Add(ud);
            }

            foreach (var y in DataManager.Years)
            {
                YearsData.Add(new YearData
                {
                    Id = y.Id,
                    ClassRoomIds = y.ClassRooms.Items.Select(cr => cr.Id).ToList(),
                    SubjectIds = y.Subjects.Items.Select(s => s.Id).ToList()
                });
            }

            foreach (var s in DataManager.Subjects)
            {
                SubjectsData.Add(new SubjectData
                {
                    Id = s.Id,
                    Name = s.Name,
                    Abreviation = s.Abreviation,
                    YearIds = s.Years.Items.Select(y => y.Id).ToList(),
                    TeacherNIFs = s.Teachers.Items.Select(t => t.NIF).ToList()
                });
            }

            foreach (var cs in DataManager.ClassSubjects)
            {
                ClassSubjectsData.Add(new ClassSubjectData
                {
                    Id = cs.Id,
                    Name = cs.Name,
                    Abreviation = cs.Abreviation,
                    TeacherNIF = cs.Teacher?.NIF ?? 0
                });
            }

            foreach (var cr in DataManager.ClassRooms)
            {
                ClassRoomsData.Add(new ClassRoomData
                {
                    Id = cr.Id,
                    Letter = cr.Letter,
                    YearId = cr.Year.Id,
                    StudentNIFs = cr.Students.Select(s => s.NIF).ToList(),
                    ClassSubjectIds = cr.ClassSubjects.Items.Select(cs => cs.Id).ToList()
                });
            }

            foreach (var g in DataManager.Grades)
            {
                GradesData.Add(new GradeData
                {
                    Id = g.Id,
                    StudentNIF = g.Student?.NIF ?? 0,
                    SubjectId = g.GradeSubject?.Id ?? 0,
                    P_Grade = g.P_Grade,
                    Comment = g.Comment
                });
            }

            foreach (var sc in DataManager.SchoolCards)
            {
                SchoolCardsData.Add(new SchoolCardData
                {
                    Id = sc.SchoolCardId,
                    Saldo = sc.Saldo
                });
            }

            foreach (var ch in ChatManager.Chats)
            {
                var chat = new ChatData
                {
                    TeacherNIF = ch.Teacher?.NIF ?? 0,
                    StudentNIF = ch.Student?.NIF ?? 0,
                    HasAdmin = ch.HasAdmin,
                    Messages = ch.Messages.Select(m => (m.Sender, m.Text)).ToList()
                };
                ChatsData.Add(chat);
            }

            var xml = new XElement("Backup",
    new XElement("Users", UsersData.Select(u =>
        new XElement("User",
            new XAttribute("Username", u.Username),
            new XAttribute("Password", u.Password),
            new XAttribute("Name", u.Name),
            new XAttribute("UserType", u.UserType),
            new XAttribute("NIF", u.NIF),
            new XAttribute("ClassRoomId", u.ClassRoomId),
            new XAttribute("SchoolCardId", u.SchoolCardId),
            new XElement("AssignedClassRooms", u.AssignedClassRoomIds.Select(id => new XElement("ClassRoomId", id))),
            new XAttribute("AssignedSubjectId", u.AssignedSubjectId),
            new XElement("Grades", u.GradeIds.Select(id => new XElement("GradeId", id)))
        )
    )),
    new XElement("Years", YearsData.Select(y =>
        new XElement("Year",
            new XAttribute("Id", y.Id),
            new XElement("ClassRooms", y.ClassRoomIds.Select(id => new XElement("ClassRoomId", id))),
            new XElement("Subjects", y.SubjectIds.Select(id => new XElement("SubjectId", id)))
        )
    )),
    new XElement("Subjects", SubjectsData.Select(s =>
        new XElement("Subject",
            new XAttribute("Id", s.Id),
            new XAttribute("Name", s.Name),
            new XAttribute("Abreviation", s.Abreviation),
            new XElement("Years", s.YearIds.Select(id => new XElement("YearId", id))),
            new XElement("Teachers", s.TeacherNIFs.Select(nif => new XElement("TeacherNIF", nif)))
        )
    )),
    new XElement("ClassSubjects", ClassSubjectsData
    .GroupBy(cs => cs.Id)
    .Select(g => g.First())    //so o primeiro id pq havia problemas de repetiçao 
    .Select(cs =>
        new XElement("ClassSubject",
            new XAttribute("Id", cs.Id),
            new XAttribute("Name", cs.Name),
            new XAttribute("Abreviation", cs.Abreviation),
            new XAttribute("TeacherNIF", cs.TeacherNIF)
        )
        )),
    new XElement("ClassRooms", ClassRoomsData.Select(cr =>
        new XElement("ClassRoom",
            new XAttribute("Id", cr.Id),
            new XAttribute("Letter", cr.Letter),
            new XAttribute("YearId", cr.YearId),
            new XElement("Students", cr.StudentNIFs.Select(nif => new XElement("StudentNIF", nif))),
            new XElement("ClassSubjects", cr.ClassSubjectIds.Distinct().Select(id => new XElement("ClassSubjectId", id)))
        )
    )),
    new XElement("Grades", GradesData.Select(g =>
        new XElement("Grade",
            new XAttribute("Id", g.Id),
            new XAttribute("StudentNIF", g.StudentNIF),
            new XAttribute("SubjectId", g.SubjectId),
            new XElement("P_Grade", g.P_Grade.Select(v => new XElement("Value", v))),
            new XElement("Comment", g.Comment.Select(c => new XElement("Text", c ?? "")))
        )
    )),
    new XElement("SchoolCards", SchoolCardsData.Select(sc =>
        new XElement("SchoolCard",
            new XAttribute("Id", sc.Id),
            new XAttribute("Saldo", sc.Saldo)
        )
    )),
    new XElement("Chats", ChatsData.Select(ch =>
        new XElement("Chat",
            new XAttribute("TeacherNIF", ch.TeacherNIF),
            new XAttribute("StudentNIF", ch.StudentNIF),
            new XAttribute("HasAdmin", ch.HasAdmin),
            new XElement("Messages", ch.Messages.Select(m =>
                new XElement("Message",
                    new XAttribute("Sender", m.Sender),
                    new XAttribute("Text", m.Text)
                )
            ))
        )
    ))
);

            Directory.CreateDirectory(Path.GetDirectoryName(path));
            xml.Save(path);
        }

        public void LoadXMLBackup(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Backup file not found.");

            XElement backup = XElement.Load(path);

            DataManager.Users.Clear();
            DataManager.Teachers.Clear();
            DataManager.Students.Clear();
            DataManager.Years.Clear();
            DataManager.ClassRooms.Clear();
            DataManager.Subjects.Clear();
            DataManager.ClassSubjects.Clear();
            DataManager.Grades.Clear();
            DataManager.SchoolCards.Clear();
            ChatManager.Chats.Clear();

            foreach (var xsc in backup.Element("SchoolCards").Elements("SchoolCard"))
            {
                DataManager.SchoolCards.Add(new SchoolCard(int.Parse(xsc.Attribute("Id").Value))
                {
                    Saldo = int.Parse(xsc.Attribute("Saldo").Value)
                });
            }

            foreach (var xy in backup.Element("Years").Elements("Year"))
            {
                var y = new Year { Id = int.Parse(xy.Attribute("Id").Value) };
                DataManager.Years.Add(y);
            }

            foreach (var xs in backup.Element("Subjects").Elements("Subject"))
            {
                var s = new Subject(xs.Attribute("Name").Value, xs.Attribute("Abreviation").Value, int.Parse(xs.Attribute("Id").Value));
                DataManager.Subjects.Add(s);
            }

            foreach (var xcs in backup.Element("ClassSubjects").Elements("ClassSubject"))
            {
                var cs = new ClassSubject
                {
                    Id = int.Parse(xcs.Attribute("Id").Value),
                    Name = xcs.Attribute("Name").Value,
                    Abreviation = xcs.Attribute("Abreviation").Value
                };
                DataManager.ClassSubjects.Add(cs);
            }

            foreach (var xcr in backup.Element("ClassRooms").Elements("ClassRoom"))
            {
                var cr = new ClassRoom
                {
                    Id = int.Parse(xcr.Attribute("Id").Value),
                    Letter = xcr.Attribute("Letter").Value[0],
                    Year = DataManager.Years.FirstOrDefault(y => y.Id == int.Parse(xcr.Attribute("YearId").Value))
                };

                foreach (var csid in xcr.Element("ClassSubjects").Elements("ClassSubjectId"))
                {
                    int id = int.Parse(csid.Value);
                    var cs = DataManager.ClassSubjects.FirstOrDefault(c => c.Id == id);
                    if (cs != null) cr.ClassSubjects.Add(cs);
                }

                DataManager.ClassRooms.Add(cr);
            }

            foreach (var xu in backup.Element("Users").Elements("User"))
            {
                var type = (UserType)Enum.Parse(typeof(UserType), xu.Attribute("UserType").Value);
                User user;

                if (type == UserType.Teacher)
                {
                    var t = new Teacher(
                        xu.Attribute("Username").Value,
                        xu.Attribute("Password").Value,
                        xu.Attribute("Name").Value,
                        int.Parse(xu.Attribute("NIF").Value),
                        DataManager.Subjects.FirstOrDefault(s => s.Id == int.Parse(xu.Attribute("AssignedSubjectId").Value))
                    );

                    foreach (var crid in xu.Element("AssignedClassRooms").Elements("ClassRoomId"))
                    {
                        var cr = DataManager.ClassRooms.FirstOrDefault(c => c.Id == int.Parse(crid.Value));
                        if (cr != null) t.AssignedClassRooms.Add(cr);
                    }

                    user = t;
                    DataManager.Teachers.Add(t);
                }
                else if (type == UserType.Student)
                {
                    var s = new Student(
                        xu.Attribute("Username").Value,
                        xu.Attribute("Password").Value,
                        xu.Attribute("Name").Value,
                        int.Parse(xu.Attribute("NIF").Value),
                        DataManager.ClassRooms.FirstOrDefault(cr => cr.Id == int.Parse(xu.Attribute("ClassRoomId").Value)),
                        DataManager.SchoolCards.FirstOrDefault(sc => sc.SchoolCardId == int.Parse(xu.Attribute("SchoolCardId").Value))
                    );

                    foreach (var gid in xu.Element("Grades").Elements("GradeId"))
                    {
                        var g = DataManager.Grades.FirstOrDefault(gr => gr.Id == int.Parse(gid.Value));
                        if (g != null) s.Grades.Add(g);
                    }

                    user = s;
                    DataManager.Students.Add(s);
                }
                else
                {
                    user = new User
                    {
                        Username = xu.Attribute("Username").Value,
                        Name = xu.Attribute("Name").Value,
                        Password = xu.Attribute("Password").Value
                    };
                }

                DataManager.Users.Add(user);
            }

            // Métodos para associar entidades entre si (Years ↔ ClassRooms/Subjects, Subjects ↔ Years/Teachers, Alunos ↔ Turmas)
            foreach (var cr in DataManager.ClassRooms)
            {
                var studentIds = backup.Element("ClassRooms")
                                       .Elements("ClassRoom")
                                       .First(x => int.Parse(x.Attribute("Id").Value) == cr.Id)
                                       .Element("Students")
                                       .Elements("StudentNIF")
                                       .Select(x => int.Parse(x.Value))
                                       .ToList();

                foreach (var nif in studentIds)
                {
                    var s = DataManager.Students.FirstOrDefault(st => st.NIF == nif);
                    if (s != null && !cr.Students.Contains(s))
                        cr.AddStudent(s);
                }
            }

            foreach (var y in DataManager.Years)
            {
                var xy = backup.Element("Years").Elements("Year").First(x => int.Parse(x.Attribute("Id").Value) == y.Id);

                y.ClassRooms.Clear();
                foreach (var crid in xy.Element("ClassRooms").Elements("ClassRoomId"))
                {
                    var cr = DataManager.ClassRooms.FirstOrDefault(c => c.Id == int.Parse(crid.Value));
                    if (cr != null) y.ClassRooms.Add(cr);
                }

                y.Subjects.Clear();
                foreach (var sid in xy.Element("Subjects").Elements("SubjectId"))
                {
                    var s = DataManager.Subjects.FirstOrDefault(sub => sub.Id == int.Parse(sid.Value));
                    if (s != null) y.Subjects.Add(s);
                }
            }

            foreach (var s in DataManager.Subjects)
            {
                var xs = backup.Element("Subjects").Elements("Subject").First(x => int.Parse(x.Attribute("Id").Value) == s.Id);

                s.Years.Clear();
                foreach (var yid in xs.Element("Years").Elements("YearId"))
                {
                    var y = DataManager.Years.FirstOrDefault(yr => yr.Id == int.Parse(yid.Value));
                    if (y != null) s.Years.Add(y);
                }

                s.Teachers.Clear();
                foreach (var nif in xs.Element("Teachers").Elements("TeacherNIF"))
                {
                    var t = DataManager.Teachers.FirstOrDefault(tc => tc.NIF == int.Parse(nif.Value));
                    if (t != null) s.Teachers.Add(t);
                }
            }

            foreach (var xch in backup.Element("Chats").Elements("Chat"))
            {
                Chat.Chat chat;
                var tch = DataManager.Teachers.FirstOrDefault(t => t.NIF == int.Parse(xch.Attribute("TeacherNIF").Value));
                var st = DataManager.Students.FirstOrDefault(s => s.NIF == int.Parse(xch.Attribute("StudentNIF").Value));
                bool hasAdmin = bool.Parse(xch.Attribute("HasAdmin").Value);

                if (hasAdmin)
                    chat = tch != null ? new Chat.Chat(tch) : new Chat.Chat(st);
                else
                    chat = new Chat.Chat(tch, st);

                foreach (var xm in xch.Element("Messages").Elements("Message"))
                    chat.AddMessage(xm.Attribute("Sender").Value, xm.Attribute("Text").Value);

                ChatManager.Chats.Add(chat);
            }
        }
    }
}