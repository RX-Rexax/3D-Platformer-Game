using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    
    public void StartGame()
    {
        // Load the next scene from the current scene by the 'build' index
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
