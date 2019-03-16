using UnityEngine;
using System.Collections;

using System.Collections.Generic;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;
    private DetectiveManager detectiveScript;

    //Awake is always called before any Start functions
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        detectiveScript = GetComponent<DetectiveManager>();
        InitGame();
    }

    //Initializes the game for each level.
    void InitGame()
    {

    }

    //Update is called every frame.
    void Update()
    {

    }
}