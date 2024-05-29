using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorController : MonoBehaviour
{
    public MeshRenderer[] planes;
    public Button colorButton;

    private void Start()
    {
        colorButton.onClick.AddListener(() => { SetColor(); });
    }

    public void SetColor()
    {
        for (int i = 0; i < planes.Length; i++)
        {
            if (planes[i].gameObject.activeSelf)
            {
                planes[i].material = colorButton.GetComponent<ColorSettings>().material;
            }
        }
    }
}
