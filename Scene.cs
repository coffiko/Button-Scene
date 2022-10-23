using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void loadScene(int sceneid)
    {
        SceneManager.LoadScene(sceneid);
    }
}
