using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_manager : MonoBehaviour
{
    public string scene_name;
    public void change_scene()
    {
        SceneManager.LoadScene(scene_name);
    }
}
