using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxTrigger : MonoBehaviour
{
    public Material otherSkybox;

    public GameObject oldBG;
    public GameObject newBG;


    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            RenderSettings.skybox = otherSkybox;

            Destroy(oldBG);

            newBG.SetActive(true);
        }
    }
}
