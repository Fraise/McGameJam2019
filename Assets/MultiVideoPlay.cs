using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MultiVideoPlay : MonoBehaviour
{
    public VideoPlayer vp1, vp2;
    public bool condition = false;
    

    public void OnClick(){
        if(!condition){
            vp1.Play();
        }else{
            vp2.Play();
        }
    }
}
