using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkInput : MonoBehaviour
{
    public Text value;
    public GameObject winUI;
    private void OnMouseDown() {
        if(value.text == "500"){
            winUI.SetActive(true);
        }
    }
}
