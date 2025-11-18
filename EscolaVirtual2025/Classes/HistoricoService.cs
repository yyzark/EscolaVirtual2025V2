using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using EscolaVirtual2025.Classes;

namespace EscolaVirtual2025.Classes
{
    public class HistoricoService
    {
        private const string NOME_FICHEIRO = "HistoricoNotas.json";


        private List<HistoricoAvaliacao> _historico = new List<HistoricoAvaliacao>();



        private readonly JsonSerializerOptions _opcoes = new JsonSerializerOptions { WriteIndented = true };

        public HistoricoService()
        {
            CarregarHistorico();
        }

        private void CarregarHistorico()
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

        public void AdicionarEGravarAlteracao(HistoricoAvaliacao novaEntrada)
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
