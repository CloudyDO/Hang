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
        if (scene.name != "SampleScene") return;

        GameObject gcanvasGO = GameObject.Find("Canvas");
        simpleWord = gcanvasGO?.AddComponent<SimpleWord>();
        simpleWord.SimpleWordInit("bagettos");
        simpleWord.Parent = gcanvasGO;
        simpleWord.X = 100;
        simpleWord.Y = 100;
    }
    public void OnExit(Scene scene)
    {
        if (scene.name != "SampleScene") return;
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
