using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public void Play()
    {
        SceneManager.sceneLoaded += this.OnSceneLoaded;
        SceneManager.LoadScene("SampleScene");
    }

    public void BackMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Exit()
    {
        Application.Quit();
    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "SampleScene")
        {
            GameObject go = GameObject.Find("MainObject");
            SampleSceneManager _SSManager = go.AddComponent<SampleSceneManager>();
            SceneManager.sceneUnloaded += _SSManager.OnExit;
            SceneManager.MoveGameObjectToScene(go, scene);
            _SSManager.OnStart(scene, mode);
        }
    }

}
