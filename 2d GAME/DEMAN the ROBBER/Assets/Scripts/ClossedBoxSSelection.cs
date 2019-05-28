using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClossedBoxSSelection : MonoBehaviour
{
    public int clossedBoxNo;
    public GameController gameController;
    public void OnMouseUp()
    {   
       gameController.ClossedBoxSelected(clossedBoxNo);
    }
}
