using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedController : MonoBehaviour
{

    void Update() {
        if (Input.touches.Length > 0 || Input.GetButtonDown("Fire1")) {
            if (Time.timeScale == 1.0f)
                Time.timeScale = 0.25f;
            else
                Time.timeScale = 1.0f;
            // Adjust fixed delta time according to timescale
            // The fixed delta time will now be 0.02 frames per real-time second
            Time.fixedDeltaTime = 0.02f * Time.timeScale;
        }
    }
}
