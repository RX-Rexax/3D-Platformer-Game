using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;        // get Player Data in 'Transform' script
    public Text scoreText;          // Text datatypes is the value of the Text of the 'Text' script

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
        // ToString() is to convert any data types ('float' in the player position) to String
        // while ToString("0") is to remove the decimals in float data types (ex: 12.0000 to 12)
    }
}
