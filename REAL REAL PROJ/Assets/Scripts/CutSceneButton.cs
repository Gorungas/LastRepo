using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutSceneButton : MonoBehaviour
{
    public KeyCode _Key;
    private Button _button;

    

    void Awake()
    {
        _button = GetComponent<Button>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(_Key))
        {
            _button.onClick.Invoke();
        }
    }
}
