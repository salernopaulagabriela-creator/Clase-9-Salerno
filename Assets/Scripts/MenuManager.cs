using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void Jugar()
    {
        // Cargar escena juego patitos
        SceneManager.LoadScene("JuegoPatos");
    }
}