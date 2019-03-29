using UnityEngine;

public class GunFire : MonoBehaviour
{

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            AudioSource gunsound = GetComponent<AudioSource>();
            gunsound.Play();
            GetComponent<Animation>().Play("gunshot");
        }
    }
}
