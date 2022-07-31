using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContollerTester : MonoBehaviour
{
    public int Controller1, Controller2, Controller3, Controller4;
    private int TestController1, TestController2, TestController3, TestController4;
    private int Joystick1, Joystick2, Joystick3, Joystick4;
    private int Joystick1Input, Joystick2Input, Joystick3Input, Joystick4Input;

    // Start is called before the first frame update
    void Start()
    {
        Controller1 = 0;
        Controller2 = 0;
        Controller3 = 0;
        Controller4 = 0;
        TestController1 = 1;
        TestController2 = 1;
        TestController3 = 1;
        TestController4 = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if ( TestController1 == 1)
        {
            if (Input.GetAxis("Axis 1") != 0)
            {
                if (Controller1 == 0)
                {
                    Joystick1 = Controller1;
                    Debug.Log("Joystick1 = Controller1");
                    TestController1 = 0;
                }
                if (Controller2 == 0)
                {
                    Joystick1 = Controller2;
                    Debug.Log("Joystick1 = Controller2");
                    TestController1 = 0;
                }
                if (Controller3 == 0)
                {
                    Joystick1 = Controller3;
                    Debug.Log("Joystick1 = Controller3");
                    TestController1 = 0;
                }
                if (Controller4 == 0)
                {
                    Joystick1 = Controller4;
                    Debug.Log("Joystick1 = Controller4");
                    TestController1 = 0;
                }

            }
        }

        if (TestController2 == 1)
        {
            if (Input.GetAxis("Axis 2") != 0)
            {
                if (Controller1 == 0)
                {
                    Joystick1 = Controller1;
                    Debug.Log("Joystick2 = Controller1");
                    TestController2 = 0;
                }
                if (Controller2 == 0)
                {
                    Joystick1 = Controller2;
                    Debug.Log("Joystick2 = Controller2");
                    TestController2 = 0;
                }
                if (Controller3 == 0)
                {
                    Joystick1 = Controller3;
                    Debug.Log("Joystick2 = Controller3");
                    TestController2 = 0;
                }
                if (Controller4 == 0)
                {
                    Joystick1 = Controller4;
                    Debug.Log("Joystick2 = Controller4");
                    TestController2 = 0;
                }

            }
        }

        if (TestController3 == 1)
        {
            if (Input.GetAxis("Axis 3") != 0)
            {
                if (Controller1 == 0)
                {
                    Joystick1 = Controller1;
                    Debug.Log("Joystick3 = Controller1");
                    TestController3 = 0;
                }
                if (Controller2 == 0)
                {
                    Joystick1 = Controller2;
                    Debug.Log("Joystick3 = Controller2");
                    TestController3 = 0;
                }
                if (Controller3 == 0)
                {
                    Joystick1 = Controller3;
                    Debug.Log("Joystick3 = Controller3");
                    TestController3 = 0;
                }
                if (Controller4 == 0)
                {
                    Joystick1 = Controller4;
                    Debug.Log("Joystick3 = Controller4");
                    TestController3 = 0;
                }

            }
        }

        if (TestController4 == 1)
        {
            if (Input.GetAxis("Axis 4") != 0)
            {
                if (Controller1 == 0)
                {
                    Joystick1 = Controller1;
                    Debug.Log("Joystick4 = Controller1");
                    TestController4 = 0;
                }
                if (Controller2 == 0)
                {
                    Joystick1 = Controller2;
                    Debug.Log("Joystick4 = Controller2");
                    TestController4 = 0;
                }
                if (Controller3 == 0)
                {
                    Joystick1 = Controller3;
                    Debug.Log("Joystick4 = Controller3");
                    TestController4 = 0;
                }
                if (Controller4 == 0)
                {
                    Joystick1 = Controller4;
                    Debug.Log("Joystick4 = Controller4");
                    TestController4 = 0;
                }

            }
        }
    }
}
