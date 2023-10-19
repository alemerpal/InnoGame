using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    public float speed;

    void Update()
    { 
        transform.position= new Vector3(transform.position.x-speed*Time.deltaTime*1f,transform.position.y,transform.position.z);
    }

}
