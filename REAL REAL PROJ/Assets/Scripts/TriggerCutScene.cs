using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TriggerCutScene : MonoBehaviour
{

    public GameObject CutScene;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            CutScene.gameObject.SetActive(true);
        }
    }

}
