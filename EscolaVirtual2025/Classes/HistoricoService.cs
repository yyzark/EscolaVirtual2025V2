using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace EscolaVirtual2025.Classes
{
    public static class HistoricoService
    {
        private const string NOME_FICHEIRO = "HistoricoNotas.json";


        static private List<HistoricoAvaliacao> _historico = new List<HistoricoAvaliacao>();



        private static readonly JsonSerializerOptions _opcoes = new JsonSerializerOptions { WriteIndented = true };

        private static void CarregarHistorico()
        {
            if (File.Exists(NOME_FICHEIRO))
            {
                try
                {
                    string jsonString = File.ReadAllText(NOME_FICHEIRO);

                    var listaCarregada = JsonSerializer.Deserialize<List<HistoricoAvaliacao>>(jsonString);
                    _historico = listaCarregada ?? new List<HistoricoAvaliacao>();
                }
                catch (Exception ex) when (ex is JsonException || ex is IOException)
                {
                    Console.WriteLine($"Erro ao carregar histórico: {ex.Message}");
                }
            }
        }

        public static void AdicionarEGravarAlteracao(HistoricoAvaliacao novaEntrada)
        {

            _historico.Add(novaEntrada);


            string jsonString = JsonSerializer.Serialize(_historico, _opcoes);


            try
            {
                File.WriteAllText(NOME_FICHEIRO, jsonString);

            }
            catch (IOException ex)
            {
                Console.WriteLine($"Erro ao guardar histórico: {ex.Message}");
            }
        }
    }
}
