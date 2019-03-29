using UnityEngine.SceneManagement;
using UnityEngine;

public class ExitMenu : MonoBehaviour
{
    public void Start()
    {
        Cursor.visible = true;
    }
    public void FirstLevel()
    {
        Debug.Log("Firstlevel");
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Debug.Log("quit");
        Application.Quit();
    }
    /*
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(1);
        }

        if (Input.GetKeyDown(KeyCode.))
        {
            Application.Quit();
        }
    }
    */
}
