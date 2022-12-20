using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickdetector : MonoBehaviour
{
    public GameObject factoryui;

    void OnMouseDown()
    {
        print("Factory Clicked!");
        factoryui.SetActive(true);
        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(2);
        factoryui.SetActive(false);
    }
}
