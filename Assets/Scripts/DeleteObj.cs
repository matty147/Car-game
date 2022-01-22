using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObj : MonoBehaviour
{
    public float Time;

    public GameObject gameObject;
    void Start()
    {
        StartCoroutine(DeleteObject(gameObject, Time));
    }
    IEnumerator DeleteObject(GameObject Obj, float t)
    {
        yield return new WaitForSeconds(t);
        Destroy(Obj);
    }
}
