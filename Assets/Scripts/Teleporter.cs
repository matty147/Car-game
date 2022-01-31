using UnityEngine;

public class Teleporter : MonoBehaviour
{
    // where should it return
    public float x, y, z;
    // horizontal rotation on the return point
    public float rotationY;

    void OnTriggerEnter(Collider other)
    {
        //var playerSphere = GetRigidbody(other.tag);
        var playerSphere = GameObject.FindGameObjectsWithTag($"{other.tag}")[0].GetComponent<Rigidbody>(); 
        playerSphere.transform.position = new Vector3(x, y, z);

        // rotate the car properly
        var playerCar = GameObject.Find(other.tag);    // the sphere's tag is the name of the car object
        playerCar.transform.rotation = Quaternion.Euler(new Vector3(0, rotationY, 0));
    }
}