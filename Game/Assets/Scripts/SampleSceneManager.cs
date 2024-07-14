using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SampleSceneManager : MonoBehaviour
{
    private SimpleWord simpleWord;
    public void OnStart(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("Sample manager OnStart");
        if(scene.name != "SampleScene") return;
        Debug.Log("5");

        GameObject go = GameObject.Find("MainObject");
        simpleWord = go?.AddComponent<SimpleWord>();
        Debug.Log("6");
        simpleWord.SimpleWordInit("baget");
        Debug.Log("7");
        SceneManager.MoveGameObjectToScene(simpleWord.gameObject, scene);
        Debug.Log("Sample manager OnStart");
    }
    public void OnExit(Scene scene)
    {
        if(scene.name != "SampleScene") return;

        Debug.Log("Sample manager OnExit");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
