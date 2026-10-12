using System.IO;
using TMPro;
using UnityEngine;

public class MostrarRelatorios : MonoBehaviour
{
    public GameObject prefabRegistro;
    public Transform content;

    void Start()
    {
        CarregarRelatorios();
    }

    public void CarregarRelatorios()
    {
        // Caminho da pasta onde os relatórios realmente estão
        string pasta = Path.Combine(
            Application.persistentDataPath,
            "Relatórios"
        );

        Debug.Log("Procurando relatórios em:");
        Debug.Log(pasta);

        // Verifica se a pasta existe
        if (!Directory.Exists(pasta))
        {
            Debug.Log("A pasta de relatórios não existe!");
            return;
        }

        // Procura todos os arquivos TXT
        string[] arquivos = Directory.GetFiles(pasta, "*.txt");

        Debug.Log("Relatórios encontrados: " + arquivos.Length);

        // Cria um registro para cada arquivo
        foreach (string arquivo in arquivos)
        {
            string conteudo = File.ReadAllText(arquivo);

            GameObject novoRegistro =
                Instantiate(prefabRegistro, content);

            TextMeshProUGUI texto =
                novoRegistro.GetComponentInChildren<TextMeshProUGUI>();

            if (texto != null)
            {
                texto.text = conteudo;
            }
            else
            {
                Debug.LogWarning(
                    "O RegistroPrefab não possui um TextMeshProUGUI."
                );
            }
        }
    }
}
