using UnityEngine;
using UnityEngine.SceneManagement;  // this is used whenever we are changing or reloading the 'scene'

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;
    public float restartDelay = 2f;
    public GameObject completeLevelUI;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over!");
            // Restart the Game with delay
            Invoke("Restart", restartDelay);    
            // Invoke function is to delay for seconds before calling the method
        }
    }

    public void CompleteLevel()
    {
        Debug.Log("LEVEL COMPLETE");
        completeLevelUI.SetActive(true);    // activate the complete level panel
    }

    void Restart()
    {
        // SceneManager.LoadScene("Basic01");

        // returns the current active scene's name
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);   
    }

}
