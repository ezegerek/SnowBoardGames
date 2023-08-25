using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    [SerializeField] float CrashName;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Graund")
        {
            FindObjectOfType<Player>().DisableContols();
            Invoke("ReloadScene", CrashName);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
