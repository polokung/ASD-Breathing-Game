using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoClick : MonoBehaviour
{
    public string NameScene;
    public string NameScene2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            Application.LoadLevel(NameScene);
        }

        if (Input.GetKeyDown("b"))
        {
            Application.LoadLevel(NameScene2);
        }
    }
}
