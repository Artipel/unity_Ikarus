using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetMovement : MonoBehaviour {

	public Rigidbody2D Star;
	public static float GravityConstant = 0.01f;

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		Vector2 dir = (Vector2)(Star.transform.position - transform.position);
		Vector2 vel = new Vector2 (dir[1],-dir[0]);
		vel.Normalize ();
		rb.velocity = vel * Mathf.Sqrt (GravityConstant * Star.mass / dir.magnitude);
	}

	void FixedUpdate(){
		Vector2 dir = (Vector2)(Star.transform.position - transform.position);
		float distance = dir.magnitude;
		//Debug.Log (distance);
		dir.Normalize();
		rb.AddForce (dir*rb.mass * Star.mass * GravityConstant / (distance * distance));
	}

	// Update is called once per frame
	void Update () {
		
	}
}
