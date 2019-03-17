using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
public class ChangeSceneAfterVideo : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string scene;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.loopPointReached += PlayVideo;
    }



    void PlayVideo(VideoPlayer vp)
    {
        SceneManager.LoadScene(scene);
    }
}
