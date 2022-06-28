using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContollerTester : MonoBehaviour
{
    public int Controller1, Controller2, Controller3, Controller4;
    //private int Joystick1Input, Joystick2Input, Joystick3Input, Joystick4Input; Not used (i think)

    List<bool> Controllers = new List<bool>();          // true = available
    List<bool> TestControllers = new List<bool>();      // true = available
    List<int> Joysticks = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            Controllers.Add(true);      
        }

        for (int i = 0; i < 16; i++)
        {
            TestControllers.Add(true);
            Joysticks.Add(-1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 16; i++)
        {
            if (TestControllers[i])
            {
                //Debug.Log($"Testing TestController {i}: {TestControllers[i]}");
                if (Input.GetButtonDown($"Axis {i + 1}")) //(Input.GetAxis("Axis 1") != 0)
                {
                    for (int c = 0; i < 4; i++)
                    {
                        // find first available controller
                        if (Controllers[c])
                        {
                            Joysticks[i] = c;
                            Debug.Log($"Joystick {i} = Controller {c}");
                            TestControllers[i] = false;
                            Controllers[c] = false;
                            break;
                        }
                    }
                }
            }
        }
    }
}
