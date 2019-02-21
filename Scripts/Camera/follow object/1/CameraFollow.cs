using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform transformToFollow;
    Vector3 tempPosition;
     
    void FixedUpdate()
    {
        //keep the z position and copy x,y 
        tempPosition.x = transformToFollow.position.x;
        tempPosition.y = transformToFollow.position.y;
        tempPosition.z = transform.position.z;
        // feed the new position to the transform
        transform.position = tempPosition;
    }
}
