using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    float timer = 0;
    float randomTime=1.5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > randomTime)
        {
            Instantiate(pipe);
            timer = 0;
            randomTime = Random.Range(1.0f, 3.5f);
        }
    }
}
