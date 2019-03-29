using UnityEngine.SceneManagement;
using UnityEngine;

public class Replay : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            CurrentLevel();
        }
    }

    public void CurrentLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
