using UnityEngine;

public class OrbitHelper : MonoBehaviour
{

    void Update() {
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.blue);
        
        Vector3 up = transform.TransformDirection(Vector3.up) * 10;
        Debug.DrawRay(transform.position, up, Color.green);

        Vector3 right = transform.TransformDirection(Vector3.right) * 10;
        Debug.DrawRay(transform.position, right, Color.red);
    }
}
