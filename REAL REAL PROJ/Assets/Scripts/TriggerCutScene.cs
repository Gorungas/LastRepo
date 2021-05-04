using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TriggerCutScene : MonoBehaviour
{

    public GameObject CutScene;


    private bool hasbeenEntered;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && hasbeenEntered == false)
        {
            hasbeenEntered = true;
            CutScene.gameObject.SetActive(true);
        }
    }

}
