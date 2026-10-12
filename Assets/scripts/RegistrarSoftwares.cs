using UnityEngine;
using TMPro;
using System.IO;
using System;

public class RegistrarSoftwares : MonoBehaviour
{

      public TMP_InputField registro;

      public void SalvarSoftware()
    {
        if (string.IsNullOrEmpty(registro.text))
        {
            Debug.Log(" Registro Vazio !!!");
            return;
        }

        string pasta = Path.Combine(Application.persistentDataPath, "Softwares");

        if (!Directory.Exists(pasta))
        {
            Directory.CreateDirectory(pasta);
        }

        string nomeArquivo = "Softwares" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".txt";

        string caminhoCompleto = Path.Combine(pasta, nomeArquivo);

        File.WriteAllText(caminhoCompleto, registro.text);
        Debug.Log("Registo salvo em: " + caminhoCompleto);

        registro.text = ""; 
    }

}
