using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string SceneName;
    void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(SceneName);
    }
}
