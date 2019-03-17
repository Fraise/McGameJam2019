using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class HorseRaceScript : MonoBehaviour
{
    //0 1 2 3
    public int state = 0;
    public VideoPlayer[] videoPlayers;
    // Start is called before the first frame update
    public void OnClick(){
        state = (state+1) % 4;
        videoPlayers[state].enabled = true;
        videoPlayers[state].Play();
    }
}
