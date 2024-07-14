using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore;
using UnityEngine.UI;

public class SimpleChar : MonoBehaviour, IHangChar
{
    private float _x;
    private float _y;
    private GameObject _parent;

    private bool _isMasked;
    public char RealChar { get; set; }
    public char MaskChar { get; set; }
    public bool IsMasked
    {
        get { return _isMasked; }
        set
        {
            _isMasked = value;
            if(UText != null)
            {
                UText.text = _isMasked ? MaskChar.ToString() : RealChar.ToString();
            }
        }
    }
    public float X 
    { 
        get => _x; 
        set 
        {
            _x = value;
            Geo.transform.localPosition = new Vector3(_x, _y);
        } 
    }

    public GameObject Parent 
    { 
        get => _parent;
        set
        {
            _parent = value;
            if(Geo != null)
            {
                Geo.transform.parent = _parent.transform;
            }
        }
    }
    public float Y { get; set; }
    public float Height { get; set; }
    public float Width { get; set; } = 36;
    public GameObject Geo { get; set; }
    private Text UText { get; set; }
    public void SimpleCharInit(char realChar, char maskChar)
    {
        IsMasked = true;
        RealChar = realChar;
        MaskChar = maskChar;
        Geo = new GameObject("MyGlyph");
        UText = Geo.AddComponent<Text>();
        UText.text = maskChar.ToString();
        Geo.transform.localPosition = new Vector3(X, Y);
        UText.fontSize = 36;
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
