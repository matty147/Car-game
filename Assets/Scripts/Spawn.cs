using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    
    [SerializeField]
    GameObject goCreate;

    [SerializeField]
    float fTimeIntervals;

    [SerializeField]
    float maxspawn;

    [SerializeField]
    float rnd;

    [SerializeField]
    float curentspawned;

    [SerializeField]
    Vector3 v3SpawnPosJitter;

    float fTimer = 0;
    // Start is called before the first frame update
    void Start()
    {
        fTimer = fTimeIntervals; 
    }

    // Update is called once per frame
    void Update()
    {
            fTimer -= Time.deltaTime;
        if (fTimer <= 0)
        {
            fTimer = fTimeIntervals;

            if (curentspawned <= maxspawn - 1)
            {
                Vector3 v3SpawnPos = transform.position;
                v3SpawnPos += Vector3.right * v3SpawnPosJitter.x * (Random.value - 0.5f);
                v3SpawnPos += Vector3.up * v3SpawnPosJitter.y * (Random.value - 0.5f);
                v3SpawnPos += Vector3.forward * v3SpawnPosJitter.z * (Random.value - 0.5f);
                //transform.localScale += (new Vector3(1f, 1f, 1f)* Random.value * 100);
                Instantiate(goCreate, v3SpawnPos, Quaternion.identity);
                curentspawned += 1;

            }
        }
    }
}
