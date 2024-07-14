using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    // static public SampleSceneManager _SSManager;
    // static GameObject go;
    public void Play()
    {
        Debug.Log("1");
        SceneManager.sceneLoaded += this.OnSceneLoaded;
        SceneManager.LoadScene("SampleScene");
        Debug.Log("4");
    }

    public void BackMenu()
    {
        SceneManager.LoadScene("Menu");
        //_SSManager = null;
    }
    public void Exit()
    {
        Application.Quit();
        //Debug.Log("You exit game");
    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if(scene.name == "SampleScene")
        {
            GameObject go = GameObject.Find("MainObject");
            SampleSceneManager _SSManager = go.AddComponent<SampleSceneManager>();
            Debug.Log("2");
            SceneManager.sceneUnloaded += _SSManager.OnExit;
            Debug.Log("3");
            SceneManager.MoveGameObjectToScene(go, scene);
            _SSManager.OnStart(scene, mode);
        }
    }

}
