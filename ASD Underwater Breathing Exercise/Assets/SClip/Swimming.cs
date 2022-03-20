using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Swimming : MonoBehaviour
{
    Animator ani;
    public Vector3 teleportPoint;
    public Rigidbody rb;
    public float timeLeft = 3.0f;
    public float timeRight = 3.0f;

    bool CheckClick = false;
    bool CheckHool = false;

    public TextMesh winText;
    public TextMesh TestPass;
    public TextMesh TestPassH;

    int count = 0;
    int countH = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ani = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        CountFist();

        if (CheckClick)
        {
            TestPass.text = "ผ่าน";
            TestPass.color = Color.blue;
            count = 1;
        }

        if (CheckHool)
        {
            TestPassH.text = "ผ่าน";
            TestPassH.color = Color.green;
            countH = 1;
        }

        if (Input.GetKeyDown("q"))
        {
            Application.LoadLevel("Main");

        }

    }

    void CountFist() {
        timeRight -= Time.deltaTime;
        if (timeRight <= 0 && timeRight >= -2)
        {
            ani.SetInteger("Down", 1);
            ani.SetInteger("Up", 0);
            rb.MovePosition(transform.position + -transform.up * 0.05f);

            winText.text = " หายใจออก ";

            print("1");
            if (Input.GetKeyDown("s"))
            {
                print("I Key Down sssssssssssssssssssssssssssssssssssss  ");
                CheckClick = true;
                
            }
           
        }
        else if (timeRight <= -2 && timeRight >= -4)
        {
            print("2");
            winText.text = " หายใจเข้า ";
            ani.SetInteger("Down", 0);
            ani.SetInteger("Up", 1);
            rb.MovePosition(transform.position + transform.up * 0.05f);



            if (Input.GetKeyDown("w"))
            {
                print("I Key Down wwwwwwwwwwwwwwwwwwwwwwwwwwwwwww  ");
                CheckHool = true;
            }

            if (!CheckClick)
            {
                TestPass.text = "ไม่ผ่าน";
                TestPass.color = Color.red;
            }
        }
        else if (timeRight <= -4)
        {
            timeRight = 3.0f;
            if (countH==1&& CheckHool)
            {
                TestPassH.text = "ผ่าน";
                TestPassH.color = Color.green;
                CheckHool = false;
            }
            else
            {
                TestPassH.text = "ไม่ผ่าน";
                TestPassH.color = Color.yellow;
                countH = 0;
            }

            if (count==1&& CheckClick)
            {
                TestPass.text = "ผ่าน";
                TestPass.color = Color.blue;
                CheckClick = false;
            }
            else
            {
                TestPass.text = "ไม่ผ่าน";
                TestPass.color = Color.red;
                count = 0;
            }
        }
       
    }
    
}
