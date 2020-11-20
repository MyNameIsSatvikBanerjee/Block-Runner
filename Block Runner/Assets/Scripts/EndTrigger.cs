using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{

    public GameObject completeLevelUI;

    void OnTriggerEnter()
    {
        CompleteLevel();
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

}
