using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class locker : MonoBehaviour
{
    public GameObject input;
    public GameObject submit;
    private void OnMouseDown() {
        input.SetActive(!input.activeSelf);
        submit.SetActive(!submit.activeSelf);
    }
}
