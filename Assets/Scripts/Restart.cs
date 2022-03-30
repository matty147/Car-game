using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    [SerializeField]
    KeyCode keyRestart;
    [SerializeField]
    KeyCode kartRestart;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(keyRestart))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Checkpoints.Reset();
        }

        if (Input.GetKey(kartRestart))
        {
            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.x = 0;
            rotationVector.z = 0;
            rotationVector.y = 0;
            transform.rotation = Quaternion.Euler(rotationVector);
        }
    }
 }
