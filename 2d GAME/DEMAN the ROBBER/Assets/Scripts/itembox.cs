using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itembox : MonoBehaviour
{
    public Transform destination;
    public int keyNumber;
    public GameController gameController;

    public void OnMouseUp()
    {   
        Debug.Log("SADASDASF");
        transform.position = destination.position;
        gameController.KeySelected(keyNumber);
    }
    
    public void OnMouseDown() {
        Debug.Log("ASF");
    }
}
