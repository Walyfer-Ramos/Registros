using UnityEngine;
using TMPro;
using System;
using System.IO;
public class Registrar : MonoBehaviour
{

      public TMP_InputField registro;

      public void Salvar()
    {
        if (string.IsNullOrEmpty(registro.text))
        {
            Debug.Log(" Registro Vazio !!!");
            return;
        }

        string pasta = Path.Combine(Application.persistentDataPath, "Relatórios");

        if (!Directory.Exists(pasta))
        {
            Directory.CreateDirectory(pasta);
        }

        string nomeArquivo = "Relatório_" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".txt";

        string caminhoCompleto = Path.Combine(pasta, nomeArquivo);

        File.WriteAllText(caminhoCompleto, registro.text);
        Debug.Log("Registo salvo em: " + caminhoCompleto);

        registro.text = ""; 
    }

}
