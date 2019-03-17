using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class LoadImageScript : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public List<GameObject> objectsToWakeUp = new List<GameObject>();
    public List<GameObject> objectsToDeactivate = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.started += DeactivateObjects;
        videoPlayer.loopPointReached += WakeUpObjects;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DeactivateObjects(VideoPlayer vp)
    {
        foreach (GameObject obj in objectsToDeactivate)
        {
            obj.SetActive(false);
        }
    }

    // Show image when video stop loading
    void WakeUpObjects(VideoPlayer vp)
    {
        foreach (GameObject obj in objectsToWakeUp)
        {
            obj.SetActive(true);
        }
    }
}
