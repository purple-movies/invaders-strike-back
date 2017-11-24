using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public class SceneNavigationMenu : MonoBehaviour
{
    [MenuItem("scenes/base")] public static void goToBase()
    {
        EditorSceneManager.OpenScene("Assets/scenes/base_scene.unity");
    }

    [MenuItem("scenes/start")] public static void goToStart()
    {
        EditorSceneManager.OpenScene("Assets/scenes/base_scene.unity");
        EditorSceneManager.OpenScene("Assets/scenes/start.unity", OpenSceneMode.Additive);
    }
}
