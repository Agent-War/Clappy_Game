using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{

    int sc;
    // Start is called before the first frame update
    void Start()
    {
        sc = 0;
    }

    public void scoreup()
    {
        sc++;
        GetComponent<Text>().text = sc.ToString();

    }

}