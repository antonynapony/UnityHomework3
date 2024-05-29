using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneRotator : MonoBehaviour
{
    public Touch touch;
    public Quaternion rotationY;
    public float rotationSpeed = 0.1f;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                rotationY = Quaternion.Euler(0.0f, -touch.deltaPosition.x * rotationSpeed, 0.0f);

                transform.rotation = rotationY * transform.rotation;
            }
        }
    }
}
