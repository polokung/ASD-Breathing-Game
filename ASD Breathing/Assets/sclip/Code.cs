using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
    Animator ani;
    int Count = 0;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("q"))
        {
            Application.LoadLevel("Main");
        }
        if (Input.GetKeyDown("w"))
        {
            Count += 1;
            ani.SetInteger("Pool", Count);
            print("w the show" + Count);
        }
        else if (Input.GetKeyDown("s"))
        {
            if (Count == 1)
            {
                ani.SetInteger("Pool", 0);
                Count = 0;
            }
            else if (Count == 2)
            {
                ani.SetInteger("Pool", 1);
                Count = 1;
            }
            else if (Count >= 3)
            {
                ani.SetInteger("Pool", 2);
                Count = 2;
            }
            
            print("w the show" + Count);


        }
        
        AnimatorStateInfo stateInfo = ani.GetCurrentAnimatorStateInfo(0);

    }
}
