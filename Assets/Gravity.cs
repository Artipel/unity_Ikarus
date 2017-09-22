using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {

	public GameObject SollarSystem;
	public float GravityConstant = 0.01f;

	private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		//SollarSystem = GameObject.Find ("Sollar System");

	}


	void FixedUpdate() {
		rb.AddForce(GravityConstant * rb.mass * ResultantG(SollarSystem));
	}

	// Update is called once per frame
	void Update () {
		
	}

	Vector2 ResultantG(GameObject SS){
		Vector2 Result = new Vector2 ();
		Vector2 temp;
		Rigidbody2D[] PlanetsRB;
		PlanetsRB = SS.GetComponentsInChildren<Rigidbody2D> ();
		for (int i = 0; i < PlanetsRB.Length; ++i) {
			temp = (Vector2)PlanetsRB [i].position - (Vector2)transform.position;
			Result += temp.normalized * PlanetsRB [i].mass / temp.magnitude;
		}
		Debug.Log (Result);
		return Result;
	}
				
}
