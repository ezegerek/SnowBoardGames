using UnityEngine;
using UnityEngine.SceneManagement;


public class FinishLine : MonoBehaviour
{
    [SerializeField] float FinishName;
    [SerializeField] ParticleSystem finish;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") 
        {
            finish.Play();
            Invoke("ReloadScene", FinishName);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
