using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    public Renderer rend;
    int i;

    // Start is called before the first frame update
    void Start()
    {
        i = 3;
    }

    // Update is called once per frame
    void Update()
    {
        i = i + 1;
        Debug.Log(gameObject.name + ":" + i);
    }
}