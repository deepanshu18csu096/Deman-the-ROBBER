using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClossedCupBoard : MonoBehaviour
{
    public int clossedCupBoardNo;
    public GameController gameController;
    public void OnMouseUp()
    {   
       gameController.ClossedCupBoardSelected(clossedCupBoardNo);
    }
}
