using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Renderer renderer;
    public Material[] material;
    private int index=1;
    public GameController gameController;
    public int shapeNumber,colorNumber;
    void Start() 
    {
        renderer=GetComponent<Renderer> ();
        renderer.enabled=true;    
    }
    void OnMouseDown()
    {
        if (material.Length==0)
        {
            return;
        }
        if (Input.GetMouseButtonDown (0))
        {
            index+=1;
            if(index==material.Length+1)
            {
                index = 1;
            }
            print(index);
           renderer.sharedMaterial=material [index-1];
            gameController.ColorChecker(shapeNumber,index-1);
        }
    }   
}