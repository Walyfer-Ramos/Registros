using System;
using System.IO;
using TMPro;
using UnityEngine;

public class RegistrarInspecoes : MonoBehaviour
{
        public TMP_InputField registro;

     public void SalvarInspecao()
    {
        if (string.IsNullOrEmpty(registro.text))
        {
            Debug.Log("Registro Vazio ! ! !");
            return;
        }

        string pasta = Path.Combine(Application.persistentDataPath, "Inpeções");

        if (!Directory.Exists(pasta))
        {
            Directory.CreateDirectory(pasta);
        }

        string nomeDoArquivo = "Inspeção_" + DateTime.Now.ToString("yyy-MM-dd-HH-mm-ss") + ".txt";

        string completoCaminho = Path.Combine(pasta, nomeDoArquivo);

        File.WriteAllText(completoCaminho, registro.text);
        Debug.Log("Registro salvo em: " + completoCaminho);

        registro.text = "";
    }
}
