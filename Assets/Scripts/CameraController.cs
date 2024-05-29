using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    public Button button;
    public GameObject miniCamera;

    void Update()
    {
        button.onClick.AddListener(() =>
        {
            miniCamera.transform.localPosition = button.GetComponent<CameraSettings>().camPos;
            miniCamera.transform.localRotation = Quaternion.Euler(button.GetComponent<CameraSettings>().camRot);
        });
    }
}
