using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] TargetController[] targets;

	void Start ()
    {
		foreach (var target in targets)
        {
            Debug.Log("stuff : " + target);

            target.onDestroyed = onTargetDestroyed;
        }
	}

    private void onTargetDestroyed(TargetController target)
    {
        Debug.Log("target destroyed ::: " + target);
    }
}
