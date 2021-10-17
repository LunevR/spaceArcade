using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("StartGame", 2);
    }

    void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
