using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Invoke("ResetGame", 1f);
        }
    }

    void ResetGame()
    {
        SceneManager.LoadScene(0);
    }
}
