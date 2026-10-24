using UnityEngine;

public class BalaColision : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        // Buscamos el GameManager en la escena
        gameManager = FindObjectOfType<GameManager>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verificamos si choca con un pato u objetivo
        if (collision.gameObject.CompareTag("Pato") || collision.gameObject.name.Contains("Pato"))
        {
            collision.gameObject.SetActive(false); // Desactiva el pato
        }

        // Llama al CheckFinish del manager si existe
        if (gameManager != null)
        {
            gameManager.CheckFinish();
        }

        // Desactiva la bala al impactar
        gameObject.SetActive(false);
    }
}