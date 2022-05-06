using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement pMovement;    // reference to our PlayerMovement script
    
    // public GameManager gameManager; (this will not work when the Player is removed)

    // When the Player hits something this method OnCollisionEnter will run
    void OnCollisionEnter(Collision collisionInfo)
    {

        // We get the information about the collision and call it 'collisionInfo'
        if (collisionInfo.collider.tag == "Obstacle")
        {
            pMovement.enabled = false;      // Disable player movement when hitting an obstacle

            // Find the Object (in this case the 'GameManager' object) and access the method
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
