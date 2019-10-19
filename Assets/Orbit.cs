using UnityEngine;

class Orbit : MonoBehaviour {
    
    public Transform rotationOrigin;
    public float speed = 20;
    
    void Update() {
        transform.RotateAround(rotationOrigin.position, rotationOrigin.up, speed * Time.deltaTime);
    }

}
