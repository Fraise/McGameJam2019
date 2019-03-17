using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MultiVideoPlay : MonoBehaviour
{
    public VideoPlayer vp1, vp2;
    public bool condition = false;
    public GameObject[] toHide;
    
 // Start is called before the first frame update
    
    public void onClick(){
        if(condition){
            vp1.enabled = true;
            vp1.Play();
        }else{
            vp2.enabled = true;
            vp2.Play();
        }
    }

}
