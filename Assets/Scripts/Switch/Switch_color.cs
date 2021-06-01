using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_color : MonoBehaviour
{
    private Renderer _renderer;
    private int _color = 0;
    // Start is called before the first frame update
    void Start()
    {
        _renderer =  GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _color = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _color = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _color = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            _color = 3;
        }

        switch(_color)
        {
            case 0:
                _renderer.material.color = Color.red;
                break;
            case 1:
                _renderer.material.color = Color.blue;
                break;
            case 2:
                _renderer.material.color = Color.green;
                break;
            case 3: 
                _renderer.material.color = Color.black;
                break;
            default:
                _renderer.material.color = Color.gray;
                break;
        }
    }
}
