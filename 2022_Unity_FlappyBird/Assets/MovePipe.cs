using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * Speed; 
        //Vector3.left = (-1,0,0)
        //Time.deltaTime = 지난 프레임이 완료되는 데 까지 걸린 시간
        //ex) 6프레임이면 한 프레임 당 1/6초
    }
}
