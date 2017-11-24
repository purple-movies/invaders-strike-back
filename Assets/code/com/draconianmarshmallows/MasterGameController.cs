using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MasterGameController : MonoBehaviour
{
    private const int START_SCENE = 1;
    private const int PLAY_SCENE = 2;

    private const string LEVELS_DIRECTORY = "Assets/scenes/levels/";
    private const string LEVEL_1 = LEVELS_DIRECTORY + "level1.unity";

    public static MasterGameController instance { get { return sInstance; } }

    private static MasterGameController sInstance;

    private void Start()
    {
        sInstance = this;
        SceneManager.LoadScene(START_SCENE, LoadSceneMode.Additive);
	}

    public void startPlay()
    {
        SceneManager.LoadScene(PLAY_SCENE);
        SceneManager.LoadScene(LEVEL_1, LoadSceneMode.Additive);
    }
}
