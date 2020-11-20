using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;
    public Text sceneText;


    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
        sceneText.text = Application.loadedLevelName;
    }
}
