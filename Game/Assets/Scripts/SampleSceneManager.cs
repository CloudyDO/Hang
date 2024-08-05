using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SampleSceneManager : MonoBehaviour
{
    private SimpleWord simpleWord;
    private IHangKeyboard myKeyboard;
    private WordsList words = new WordsList();
    private string currentWord;
    public void OnStart(Scene scene, LoadSceneMode mode)
    {
        if (scene.name != "SampleScene") return;

        GameObject gcanvasGO = GameObject.Find("Canvas");
        simpleWord = gcanvasGO?.AddComponent<SimpleWord>();

        myKeyboard = gcanvasGO?.AddComponent<RegularKeyboard>();
        myKeyboard.OnKeyPressed += OnKeyPressed;

        currentWord = words.getRandWord();
        simpleWord.SimpleWordInit(currentWord);

        simpleWord.SimpleWordInit(words.getRandWord());
        simpleWord.Parent = gcanvasGO;
        float h = gcanvasGO.GetComponent<RectTransform>().sizeDelta.y;
        float wh = simpleWord.Height;
        simpleWord.X = 0;
        simpleWord.Y = h / 2 - wh;
    }
    public void OnExit(Scene scene)
    {
        if (scene.name != "SampleScene") return;
    }

    private void OnKeyPressed(char ch)
    {
        Debug.Log("Key " + ch + " pressed");
        simpleWord.RevealChar(ch);

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
    private List<string> words = new List<string> { "Хліба", "Москіто", "Маквіно", "Чудо" };
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
        System.Random rand = new();
        int i = rand.Next(0, words.Count);
        res = words[i];
        return res;
    }
    private void loadFromFile() { }
    private void loadToFile() { }

}
