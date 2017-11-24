using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMenuController : MonoBehaviour
{
    [SerializeField] private Button startButton;

	private void Start()
    {
        startButton.onClick.AddListener(onClickStart);
	}

    private void onClickStart()
    {
        MasterGameController.instance.startPlay();
    }
}
