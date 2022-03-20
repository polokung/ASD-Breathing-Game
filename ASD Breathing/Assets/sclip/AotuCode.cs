using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AotuCode : MonoBehaviour
{
    Animator ani;
    int Count = 1;
    bool check = false;

    // Start is called before the first frame update

    public float timeLeft = 3.0f;
    public float timeRight = 3.0f;
    public TextMesh winText;
    public TextMesh TextPass;
    public TextMesh TextPassH;

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
        if (Count == 1)
        {

            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0)
            {
                timeLeft = 3.0f;
                ani.SetInteger("Up", 1);
                ani.SetInteger("Down", 0);
                Count = 2;
                check = true;
                TextPass.text = " ไม่ผ่าน ";
                TextPass.color = Color.red;
            }

        }

        if (check)
        {

            if (Input.GetKeyDown("w"))
            {
                print("I Key Down wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww  " + 1);
                TextPass.text = "ผ่าน";
                TextPass.color = Color.blue;
            }
            else
            {

                winText.text = " หายใจออก ".ToString();
            }
        }
        else
        {
            if (Input.GetKeyDown("s"))
            {
                print("I Key Down ssssssssssssssssssssssssssssssssssssssss  " + 0);

                TextPassH.text = "ผ่าน";
                TextPassH.color = Color.green;
            }
            else
            {
                print("Fale Count the show" + 0);
                winText.text = " หายใจเข้า ".ToString();
            }
        }

        if (Count == 2)
        {

            timeRight -= Time.deltaTime;
            if (timeRight <= 0)
            {
                timeRight = 3.0f;
                ani.SetInteger("Down", 1);
                ani.SetInteger("Up", 0);
                Count = 1;
                check = false;
                TextPassH.text = " ไม่ผ่าน ";
                TextPassH.color = Color.red;
            }
        }

    }

}
