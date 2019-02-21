using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    float horizontal;
    Rigidbody2D body;
    PlayerData data;
    // Use this for initialization
    void Start () {
        body = GetComponent<Rigidbody2D>();
        data = GetComponent<PlayerData>();
    }

    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontal, 0) * data.speed;
    }
}
