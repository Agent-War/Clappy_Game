using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject column;

    public float Minh, Maxh;

    float timer;
    public float maxt;
    // Start is called before the first frame update
    void Start()
    {
        SpawnCol();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>maxt)
        {
            SpawnCol();
            timer = 0;
        }
    }

    void SpawnCol()
    {
        float height = Random.Range(Minh, Maxh);

        GameObject NewColumn = Instantiate(column);
        NewColumn.transform.position = new Vector2(
            transform.position.x, height);
    }
}
