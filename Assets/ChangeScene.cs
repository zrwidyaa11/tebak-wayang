using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void Change_Button(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }
}