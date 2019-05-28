using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moment : MonoBehaviour
{
    bool click=true;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    public void OnMouseDown()
    {   
        if(click)
        {
            transform.position += new Vector3(0,1,0);

        }
       
    }
    public void OnMouseUp()
    {   click=false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
