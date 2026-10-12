using UnityEngine;
using TMPro;
using System;
using System.IO;
public class RegistrarManutencao : MonoBehaviour
{

      public TMP_InputField registro;

      public void SalvarManutencao()
    {
        if (string.IsNullOrEmpty(registro.text))
        {
            Debug.Log(" Registro Vazio !!!");
            return;
        }

        string pasta = Path.Combine(Application.persistentDataPath, "Manutenção");

        if (!Directory.Exists(pasta))
        {
            Directory.CreateDirectory(pasta);
        }

        string nomeArquivo = "Manutenção" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".txt";

        string caminhoCompleto = Path.Combine(pasta, nomeArquivo);

        File.WriteAllText(caminhoCompleto, registro.text);
        Debug.Log("Registo salvo em: " + caminhoCompleto);

        registro.text = ""; 
    }

}
