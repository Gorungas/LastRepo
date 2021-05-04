using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public LossScript loss;

    public GameObject firstClouds, secondClouds, thirdClodus;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
         switch(loss.level)
        {
            case 1:
                firstClouds.gameObject.SetActive(true);
                break;
            case 2:
                secondClouds.gameObject.SetActive(true);
                break;
            case 3:
                thirdClodus.gameObject.SetActive(true);
                break;
        }
    }
}
