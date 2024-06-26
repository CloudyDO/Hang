using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBebe : MonoBehaviour
{
    public GameObject[] bodyPart;
    private int curretnLayer = 0;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject bodyParts in bodyPart)
        {
            Renderer isVisible = bodyParts.GetComponent<Renderer>();
            if (isVisible != null)
            {
                isVisible.enabled = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (curretnLayer < bodyPart.Length)
            {
                Renderer isVisible = bodyPart[curretnLayer].GetComponent<Renderer>();
                if (isVisible != null)
                {
                    isVisible.enabled = true;
                }
                curretnLayer++;
            }
        }
    }
}
