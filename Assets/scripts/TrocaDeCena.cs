using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocaDeCena : MonoBehaviour
{

    public string cena = "relatorio";

    public void TrocaCena()
    {
        SceneManager.LoadScene(cena);
    }

}
