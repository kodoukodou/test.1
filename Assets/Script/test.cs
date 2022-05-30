using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    float speed=5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)){
            if(transform.position.x<6){
                transform.position=transform.position+new Vector3(speed,0,0)*Time.deltaTime;
            }
        }
         if(Input.GetKey(KeyCode.LeftArrow)){
            if(transform.position.x>-6){
                transform.position=transform.position+new Vector3(-speed,0,0)*Time.deltaTime;
            }
        }
    }
}
