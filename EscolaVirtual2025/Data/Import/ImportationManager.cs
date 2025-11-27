using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Users;
using EscolaVirtual2025.Data.Import.Dto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Xml.Serialization;

namespace EscolaVirtual2025.Data.Import
{
    public class ImportManager
    {
        public ImportResult ImportarAlunosJSON(string caminho)
        {
            var result = new ImportResult();

            if (!File.Exists(caminho))
            {
                result.Errors.Add($"Ficheiro não encontrado: {caminho}");
                return result;
            }

            try
            {
                var json = File.ReadAllText(caminho);
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var root = JsonSerializer.Deserialize<StudentsRootDto>(json, options);

                if (root == null || root.Alunos == null)
                {
                    result.Errors.Add("Formato inválido: não foram encontrados 'alunos' no ficheiro JSON.");
                    return result;
                }

                ProcessStudentsDtos(root.Alunos, result);
            }
            catch (Exception ex)
            {
                result.Errors.Add($"Erro ao ler/deserializar JSON: {ex.Message}");
            }

            return result;
        }

        public ImportResult ImportarAlunosXML(string caminho)
        {
            var result = new ImportResult();

            if (!File.Exists(caminho))
            {
                result.Errors.Add($"Ficheiro não encontrado: {caminho}");
                return result;
            }

            try
            {
                using (var fs = File.OpenRead(caminho))
                {
                    var serializer = new XmlSerializer(typeof(StudentsRootDto));
                    if (serializer.Deserialize(fs) is StudentsRootDto root)
                    {
                        if (root.Alunos == null)
                        {
                            result.Errors.Add("Formato inválido: não foram encontrados 'alunos' no ficheiro XML.");
                            return result;
                        }

                        ProcessStudentsDtos(root.Alunos, result);
                    }
                    else
                    {
                        result.Errors.Add("Deserialização XML devolveu null.");
                    }
                }
            }
            catch (Exception ex)
            {
                result.Errors.Add($"Erro ao ler/deserializar XML: {ex.Message}");
            }

            return result;
        }

        public ImportResult ImportarTurmasJSON(string caminho)
        {
            var result = new ImportResult();

            if (!File.Exists(caminho))
            {
                result.Errors.Add($"Ficheiro não encontrado: {caminho}");
                return result;
            }

            try
            {
                var json = File.ReadAllText(caminho);
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var root = JsonSerializer.Deserialize<ClassRoomsRootDto>(json, options);

                if (root == null || root.Turmas == null)
                {
                    result.Errors.Add("Formato inválido: não foram encontradas 'turmas' no ficheiro JSON.");
                    return result;
                }

                ProcessClassRoomDtos(root.Turmas, result);
            }
            catch (Exception ex)
            {
                result.Errors.Add($"Erro ao ler/deserializar JSON: {ex.Message}");
            }

            return result;
        }

        public ImportResult ImportarTurmasXML(string caminho)
        {
            var result = new ImportResult();

            if (!File.Exists(caminho))
            {
                result.Errors.Add($"Ficheiro não encontrado: {caminho}");
                return result;
            }

            try
            {
                using (var fs = File.OpenRead(caminho))
                {
                    var serializer = new XmlSerializer(typeof(ClassRoomsRootDto));
                    if (serializer.Deserialize(fs) is ClassRoomsRootDto root)
                    {
                        if (root.Turmas == null)
                        {
                            result.Errors.Add("Formato inválido: não foram encontradas 'turmas' no ficheiro XML.");
                            return result;
                        }

                        ProcessClassRoomDtos(root.Turmas, result);
                    }
                    else
                    {
                        result.Errors.Add("Deserialização XML devolveu null.");
                    }
                }
            }
            catch (Exception ex)
            {
                result.Errors.Add($"Erro ao ler/deserializar XML: {ex.Message}");
            }

            return result;
        }

        private void ProcessStudentsDtos(List<StudentDto> dtos, ImportResult result)
        {
            var existingNifs = new HashSet<string>(DataManager.Students.Select(s => s.NIF));
            var existingUsernames = new HashSet<string>(DataManager.Students.Select(s => s.Username));
            var existingSchoolCardIds = new HashSet<int>(DataManager.Students.Where(s => s.SchoolCard != null)
                                                                               .Select(sc => sc.SchoolCard.SchoolCardId));

            int imported = 0;
            int index = 0;

            foreach (var dto in dtos)
            {
                index++;
                var entryPrefix = $"Aluno[{index}]";

                if (string.IsNullOrWhiteSpace(dto.username) ||
                    string.IsNullOrWhiteSpace(dto.password) ||
                    string.IsNullOrWhiteSpace(dto.name) ||
                    string.IsNullOrWhiteSpace(dto.nif))
                {
                    result.Errors.Add($"{entryPrefix}: Campos obrigatórios em falta (username/password/name/nif).");
                    continue;
                }

                var username = dto.username.Trim();
                var password = dto.password.Trim();
                var name = dto.name.Trim();
                var nif = dto.nif.Trim();

                if (!System.Text.RegularExpressions.Regex.IsMatch(nif, @"^\d{9}$"))
                {
                    result.Errors.Add($"{entryPrefix}: NIF inválido, deve ter exatamente 9 dígitos ({nif})");
                    continue;
                }

                if (password.Length < 6)
                {
                    result.Errors.Add($"{entryPrefix}: Password deve ter no mínimo 6 caracteres");
                    continue;
                }

                if (existingNifs.Contains(nif))
                {
                    result.Errors.Add($"{entryPrefix}: NIF já existe no sistema ({nif}).");
                    continue;
                }

                if (existingUsernames.Contains(username))
                {
                    result.Errors.Add($"{entryPrefix}: Username já existe no sistema ({username}).");
                    continue;
                }

                SchoolCard schoolCard = null;
                if (dto.schoolCardId.HasValue)
                {
                    var scId = dto.schoolCardId.Value;
                    if (existingSchoolCardIds.Contains(scId))
                    {
                        result.Errors.Add($"{entryPrefix}: SchoolCardId duplicado ({scId}).");
                        continue;
                    }
                    schoolCard = new SchoolCard(scId);
                    existingSchoolCardIds.Add(scId);
                }

                ClassRoom classRoom = null;

                if (dto.classId.HasValue)
                {
                    classRoom = DataManager.ClassRooms.FirstOrDefault(c => c.Id == dto.classId.Value);
                    if (classRoom == null)
                    {
                        var yearId = dto.classId.Value;
                        var year = DataManager.Years.FirstOrDefault(y => y.Id == yearId);
                        if (year == null)
                        {
                            year = new Year(yearId);
                            DataManager.Years.Add(year);
                        }

                        var lettersUsed = new HashSet<char>(year.ClassRooms.Items.Select(cr => cr.Letter));
                        char newLetter = 'A';
                        while (lettersUsed.Contains(newLetter) && newLetter <= 'Z') newLetter++;
                        classRoom = new ClassRoom(newLetter, year, dto.classId.Value);
                        year.ClassRooms.Add(classRoom);
                        DataManager.ClassRooms.Add(classRoom);
                    }
                }

                try
                {
                    var student = new Student(username, password, name, nif, classRoom, schoolCard);
                    DataManager.Students.Add(student);
                    existingNifs.Add(nif);
                    existingUsernames.Add(username);
                    imported++;
                }
                catch (Exception ex)
                {
                    result.Errors.Add($"{entryPrefix}: Erro ao criar/atribuir aluno: {ex.Message}");
                }
            }

            result.ImportedCount = imported;
        }

        private void ProcessClassRoomDtos(List<ClassRoomDto> dtos, ImportResult result)
        {
            var existingClassIds = new HashSet<int>(DataManager.ClassRooms.Select(c => c.Id));
            var existingYearLetter = new HashSet<string>(DataManager.ClassRooms.Select(cr => $"{cr.Year.Id}_{char.ToUpper(cr.Letter)}"));

            var incomingClassIds = new HashSet<int>();
            var incomingYearLetter = new HashSet<string>();

            int imported = 0;
            int index = 0;

            foreach (var dto in dtos)
            {
                index++;
                var entryPrefix = $"Turma[{index}]";

                if (!dto.id.HasValue || string.IsNullOrWhiteSpace(dto.letter) || !dto.yearId.HasValue)
                {
                    result.Errors.Add($"{entryPrefix}: Campos obrigatórios em falta (id/letter/yearId).");
                    continue;
                }

                var id = dto.id.Value;
                var letterStr = dto.letter.Trim();
                if (letterStr.Length != 1)
                {
                    result.Errors.Add($"{entryPrefix}: 'letter' deve ser um único carácter (ex. 'A').");
                    continue;
                }
                var letter = char.ToUpper(letterStr[0]);
                var yearId = dto.yearId.Value;

                if (yearId < 1 || yearId > 12)
                {
                    result.Errors.Add($"{entryPrefix}: Ano inválido, deve estar entre 1 e 12 ({yearId}).");
                    continue;
                }

                // Evitar duplicação global
                if (existingClassIds.Contains(id) || !incomingClassIds.Add(id))
                {
                    result.Errors.Add($"{entryPrefix}: Id de turma duplicado ({id}).");
                    continue;
                }

                var key = $"{yearId}_{letter}";
                if (existingYearLetter.Contains(key) || !incomingYearLetter.Add(key))
                {
                    result.Errors.Add($"{entryPrefix}: Já existe uma turma para o mesmo ano e letra ({yearId} {letter}).");
                    continue;
                }

                var year = DataManager.Years.FirstOrDefault(y => y.Id == yearId);
                bool newYear = false;

                if (year == null)
                {
                    year = new Year(yearId);
                    newYear = true;
                }

                try
                {
                    // Cria a turma apenas 1 vez
                    var classRoom = new ClassRoom(letter, year, id);
                    year.ClassRooms.Add(classRoom);

                    if (newYear)
                        DataManager.Years.Add(year);

                    // Processar alunos da turma
                    if (dto.alunos != null && dto.alunos.Count > 0)
                    {
                        foreach (var s in dto.alunos)
                            s.classId = id;

                        ProcessStudentsDtos(dto.alunos, result);
                    }

                    existingClassIds.Add(id);
                    existingYearLetter.Add(key);
                    imported++;
                }
                catch (Exception ex)
                {
                    result.Errors.Add($"{entryPrefix}: Erro ao criar turma: {ex.Message}");
                }
            }

            result.ImportedCount = imported;
        }
    }
}
