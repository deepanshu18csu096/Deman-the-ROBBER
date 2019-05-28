using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ridelsize : MonoBehaviour
{
    bool riddle;
    public Transform destination1;
void Start()
{
     riddle=false;
}
    public void OnMouseDown()
    {   
       if(riddle==false)
       {
           transform.position = destination1.position;
           transform.localScale = new Vector3(1,1,0);
           riddle=true;
       }
       else{
           transform.localScale = new Vector3(0.11f,0.175f,0);
          riddle=false;
       }

    }
}
