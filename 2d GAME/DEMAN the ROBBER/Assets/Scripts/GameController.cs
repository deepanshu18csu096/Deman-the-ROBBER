using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public bool key1,key2,key3,key4;
    public bool clossedBox1,clossedBox2,clossedcupBoardNo1;
    int keyNumber,clossedBoxNo,clossedCupBoardNo;
    public GameObject Box1,Box2,cupBoardBox1,keyHide1,keyHide2,keyHide3,keyshow1;
    
    public bool sphere,cube,cylinder;
    int sphereAns=0,cubeAns=2,cylinderAns=3;   
    public void Start(){
        key1=key2=key3=key4=false;
        sphere=cube=cylinder=false;
    }

    public void KeySelected(int keyNumber){
        if(keyNumber==1){
            key1=true;
            key2=key3=key4=false;
        }
        else if(keyNumber==2){
            key2=true;
            key1=key3=key4=false;
        }
        if(keyNumber==3){
            key3=true;
            key2=key1=key4=false;
        }
        else if(keyNumber==4){
            key4=true;
            key1=key3=key2=false;
        }

    }
    public void ClossedBoxSelected(int clossedBoxNo)
    {
        if(clossedBoxNo==1)
        {
            // clossedBox1=true;
            // clossedBox2=false;
            if(key1)
            {
                Box1.SetActive(false);
                keyHide1.SetActive(false);
            }
        }
        else if(clossedBoxNo==2)
        {
            //clossedBox1=false;
            //clossedBox2=true;
            if(key2)
            {
                Box2.SetActive(false);
                keyHide2.SetActive(false);
            }
        }
    }
    public void ClossedCupBoardSelected(int clossedCupBoardNo)
    {
        if(clossedCupBoardNo==1)
        {
            
            if(key3)
            {
                cupBoardBox1.SetActive(false);
                keyHide3.SetActive(false);
            }
        }
    
    }

    public void ColorChecker(int shapeNumber,int colorNumber){
        if(shapeNumber==0){
            if(sphereAns==colorNumber){
                sphere=true;
            }
            else
            {
                sphere=false;
            }
        }
        if(shapeNumber==1){
            if(cubeAns==colorNumber){
                cube=true;
            }
            else
            {
                cube=false;
            }
        }
        if(shapeNumber==2){
            Debug.Log("Working");
            if(cylinderAns==colorNumber){
                cylinder=true;
            }
            else
            {
                cylinder=false;
            }
        }
        if(cube&&sphere&&cylinder){
            Debug.Log("SOLVED");
            keyshow1.SetActive(true);
        }                
    }


}
