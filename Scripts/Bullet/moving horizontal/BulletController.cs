using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Mohamed Shiha 
 * 1/2/2019
 * CaptainX
 */
public class BulletController : MonoBehaviour {
    Rigidbody2D body;
	void Start () {
        body = GetComponent<Rigidbody2D>();
	}
	
    private void FixedUpdate()
    {
        body.velocity = new Vector2(0, 2) *10;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.gameObject.tag;
        if (tag.EndsWith("Enemy")) Destroy(collision.gameObject);
        Destroy(this.gameObject);
    }


}
