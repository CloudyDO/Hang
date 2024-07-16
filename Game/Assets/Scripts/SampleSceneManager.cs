using System;
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

        WordsList words = new WordsList();

        simpleWord.SimpleWordInit(words.getRandWord());
        simpleWord.Parent = gcanvasGO;
        float h = gcanvasGO.GetComponent<RectTransform>().sizeDelta.y;
        float wh = simpleWord.Height;
        simpleWord.X = 0;
        simpleWord.Y = h/2-wh;
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

public class WordsList 
{
    private List<string> words = new List<string>{"Хліба", "Москіто", "Маквіно", "Чудо"};
    public void addWord(string word)
    {
        words.Add(word);
    }
    public void removeWord(string word)
    {
        words.Remove(word);
    }
    public string getRandWord()
    {
        string res = "";
        System.Random rand = new ();
        int i = rand.Next(0,words.Count);
        res = words[i];
        return res;
    }
    private void loadFromFile(){}
    private void loadToFile(){}

}
