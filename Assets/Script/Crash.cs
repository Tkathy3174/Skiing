using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Snow")
        {
            Invoke("ResetGame", 2f);
        }
    }

    void ResetGame()
    {
        SceneManager.LoadScene(0);
    }
}
