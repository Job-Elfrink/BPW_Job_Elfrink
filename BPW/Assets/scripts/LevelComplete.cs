using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class LevelComplete : MonoBehaviour
{
    public GameObject space;

    public GameObject player;

    private void MakeSpaceAvailable()
    {
        space.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NextLevel();
        }
    }

    public void NextLevel()
    {
        GameObject.Find("RigidBodyFPSController").GetComponent<RigidbodyFirstPersonController>().mouseLook.SetCursorLock(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
