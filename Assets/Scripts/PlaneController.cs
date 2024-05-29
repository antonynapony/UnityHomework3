using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaneController : MonoBehaviour
{
    public GameObject[] planes;
    public int currentPlane;
    public Button prevButton;
    public Button nextButton;

    public void Awake()
    {
        SelectPlane(0);
    }
    public void SelectPlane(int index)
    {
        if (index == 0)
        {
            prevButton.interactable = false;
        }
        else if (index == planes.Length - 1)
        {
            nextButton.interactable = false;
        }
        else
        {
            prevButton.interactable = true;
            nextButton.interactable = true;
        }

        for (int i = 0; i < planes.Length; i++)
        {
            planes[i].SetActive(i == index);
        }
    }

    public void ChangePlane(int change)
    {
        currentPlane += change;
        SelectPlane(currentPlane);
    }
}
