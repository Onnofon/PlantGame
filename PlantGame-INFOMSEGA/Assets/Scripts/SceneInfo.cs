using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneInfo : MonoBehaviour
{
    Scene m_Scene;
    public string sceneName;
    public TMPro.TextMeshProUGUI sceneText;

    // Start is called before the first frame update
    void Start()
    {
        m_Scene = SceneManager.GetActiveScene();
        sceneName = m_Scene.name;

        sceneText.text = sceneName;
    }

}
