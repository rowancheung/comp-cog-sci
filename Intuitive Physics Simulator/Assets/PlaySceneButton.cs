using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;


public class PlaySceneButton : MonoBehaviour {

    public Button button;
    public bool sceneRan = false;

    private void Start()
    {
        Physics.gravity = new Vector3(0, 0, 0);
    }

    public void startScene()
    {

        if (!sceneRan) {
            Physics.gravity = new Vector3(0, -10, 0);

            button.GetComponentInChildren<Text>().text = "Next Problem";
            sceneRan = true;
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
