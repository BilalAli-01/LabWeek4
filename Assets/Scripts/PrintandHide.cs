using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    int i;
    int randomNum;

    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        randomNum = Random.Range(150,251);
    }

    // Update is called once per frame
    void Update()
    {
        i = i + 1;
        Debug.Log(gameObject.name + ":" + i);

        if (i == 100)
        {
            if (gameObject.tag == "Red")
            {
                gameObject.SetActive(false);
            }
        }

        if (gameObject.tag == "Blue")
        {
            if(i == randomNum){
            rend.enabled = false;
            }
        }
    }
}
