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
        // -------------------------
        // Importar Alunos - JSON
        // -------------------------
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

        // -------------------------
        // Importar Alunos - XML
        // -------------------------
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

        // -------------------------
        // Importar Turmas - JSON
        // -------------------------
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

        // -------------------------
        // Importar Turmas - XML
        // -------------------------
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

        // -------------------------
        // Helpers - processamento
        // -------------------------
        private void ProcessStudentsDtos(List<StudentDto> dtos, ImportResult result)
        {
            // Pre-checks com os existentes
            var existingNifs = new HashSet<string>(DataManager.Students.Select(s => s.NIF));
            var existingUsernames = new HashSet<string>(DataManager.Students.Select(s => s.Username));
            var existingSchoolCardIds = new HashSet<int>(DataManager.Students.Where(s => s.SchoolCard != null).Select(sc => sc.SchoolCard.SchoolCardId));

            // Também verificar IDs de turmas existentes
            var existingClassRoomIds = new HashSet<int>(DataManager.ClassRooms.Select(c => c.Id));

            // Para detectar duplicados dentro do ficheiro
            var incomingNifs = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var incomingUsernames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var incomingSchoolCardIds = new HashSet<int>();

            int imported = 0;
            int index = 0;
            foreach (var dto in dtos)
            {
                index++;
                var entryPrefix = $"Aluno[{index}]";

                // Validar campos obrigatórios
                if (string.IsNullOrWhiteSpace(dto.username) ||
                    string.IsNullOrWhiteSpace(dto.password) ||
                    string.IsNullOrWhiteSpace(dto.name) ||
                    string.IsNullOrWhiteSpace(dto.nif))
                {
                    result.Errors.Add($"{entryPrefix}: Campos obrigatórios em falta (username/password/name/nif).");
                    continue;
                }

                // Normalize
                var username = dto.username.Trim();
                var nif = dto.nif.Trim();

                // Duplicados (existentes)
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

                // Duplicados (no ficheiro)
                if (!incomingNifs.Add(nif))
                {
                    result.Errors.Add($"{entryPrefix}: NIF duplicado no ficheiro ({nif}).");
                    continue;
                }

                if (!incomingUsernames.Add(username))
                {
                    result.Errors.Add($"{entryPrefix}: Username duplicado no ficheiro ({username}).");
                    continue;
                }

                // SchoolCardId duplicado (entre existentes)
                if (dto.schoolCardId.HasValue)
                {
                    var scId = dto.schoolCardId.Value;
                    if (existingSchoolCardIds.Contains(scId) || incomingSchoolCardIds.Contains(scId))
                    {
                        result.Errors.Add($"{entryPrefix}: SchoolCardId duplicado ({scId}).");
                        continue;
                    }
                    incomingSchoolCardIds.Add(scId);
                }

                // Classroom linking (optional) -> classId must exist
                ClassRoom classRoom = null;
                if (dto.classId.HasValue)
                {
                    var cid = dto.classId.Value;
                    classRoom = DataManager.ClassRooms.FirstOrDefault(cr => cr.Id == cid);
                    if (classRoom == null)
                    {
                        result.Errors.Add($"{entryPrefix}: ClassId referenciado não existe no sistema ({cid}).");
                        continue;
                    }

                    // turma cheia?
                    if (classRoom.StudentsCount >= 20)
                    {
                        result.Errors.Add($"{entryPrefix}: A turma (Id={cid}, Letter={classRoom.Letter}) está cheia.");
                        continue;
                    }
                }

                // Criar SchoolCard (se indicado) e verificar construtor existente
                SchoolCard schoolCard = null;
                if (dto.schoolCardId.HasValue)
                {
                    schoolCard = new SchoolCard(dto.schoolCardId.Value);
                }

                try
                {
                    // Criar Student
                    var student = new Student(username, dto.password, dto.name, nif, classRoom, schoolCard);

                    // Inserir na DataManager
                    DataManager.Students.Add(student);

                    // Se turma indicada, AddStudent já é feito pelo setter do Student.ClassRoom
                    // Increment counters / sets para futuras validações
                    existingNifs.Add(nif);
                    existingUsernames.Add(username);
                    if (schoolCard != null) existingSchoolCardIds.Add(schoolCard.SchoolCardId);

                    imported++;
                }
                catch (Exception ex)
                {
                    result.Errors.Add($"{entryPrefix}: Erro ao criar/atribuir aluno: {ex.Message}");
                    // Caso de falha, não adicionamos nada
                }
            } // foreach

            result.ImportedCount = imported;
        }

        private void ProcessClassRoomDtos(List<ClassRoomDto> dtos, ImportResult result)
        {
            // Pre-checks com os existentes
            var existingClassIds = new HashSet<int>(DataManager.ClassRooms.Select(c => c.Id));
            // (para verificar "mesmo year + letter")
            var existingYearLetter = new HashSet<string>(DataManager.ClassRooms.Select(cr => $"{cr.Year.Id}_{char.ToUpper(cr.Letter)}"));

            var incomingClassIds = new HashSet<int>();
            var incomingYearLetter = new HashSet<string>();

            int imported = 0;
            int index = 0;
            foreach (var dto in dtos)
            {
                index++;
                var entryPrefix = $"Turma[{index}]";

                // Campos obrigatórios: id, letter, yearId
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

                // ID duplicado (existente)
                if (existingClassIds.Contains(id))
                {
                    result.Errors.Add($"{entryPrefix}: Id de turma já existe no sistema ({id}).");
                    continue;
                }

                // ID duplicado no ficheiro
                if (!incomingClassIds.Add(id))
                {
                    result.Errors.Add($"{entryPrefix}: Id de turma duplicado no ficheiro ({id}).");
                    continue;
                }

                // Verificar ano existe
                var year = DataManager.Years.FirstOrDefault(y => y.Id == yearId);
                if (year == null)
                {
                    result.Errors.Add($"{entryPrefix}: YearId referenciado não existe no sistema ({yearId}).");
                    continue;
                }

                // Verificar se já existe turma com mesmo year + letter (existente)
                var key = $"{yearId}_{letter}";
                if (existingYearLetter.Contains(key))
                {
                    result.Errors.Add($"{entryPrefix}: Já existe uma turma no ano {yearId} com a letra '{letter}'.");
                    continue;
                }

                // Verificar duplicado no ficheiro (mesmo year+letter)
                if (!incomingYearLetter.Add(key))
                {
                    result.Errors.Add($"{entryPrefix}: Duplicação no ficheiro: mais de uma turma para o mesmo year + letter ({yearId} {letter}).");
                    continue;
                }

                // Criar ClassRoom
                try
                {
                    var classRoom = new ClassRoom(letter, year, id);
                    // Adicionar à DataManager
                    DataManager.ClassRooms.Add(classRoom);

                    // Atualizar sets
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

