using EscolaVirtual2025.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public static class HistoricoService
{
    private static string Caminho = "historico.json"; 

    public static void AdicionarEGravarAlteracao(HistoricoAvaliacao entrada)
    {
        List<HistoricoAvaliacao> lista = new List<HistoricoAvaliacao>();

        // caso exista, vsai carregar
        if (File.Exists(Caminho))
        {
            string jsonExistente = File.ReadAllText(Caminho);
            if (!string.IsNullOrWhiteSpace(jsonExistente))
            {
                lista = JsonSerializer.Deserialize<List<HistoricoAvaliacao>>(jsonExistente);
            }
        }

        
        lista.Add(entrada);

        
        string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(Caminho, json); 
    }
}
