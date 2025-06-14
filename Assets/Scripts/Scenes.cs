using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void Reiniciar()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
