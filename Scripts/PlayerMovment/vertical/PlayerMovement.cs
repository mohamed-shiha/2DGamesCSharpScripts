using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 10;
    float vertical;
    Rigidbody2D body;
    // Use this for initialization
    void Start () {
        body = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        vertical  = Input.GetAxis("Vertical");
	}

    private void FixedUpdate()
    {
        body.velocity = new Vector2(0,vertical) * speed ;
    }
}
