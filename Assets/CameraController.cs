using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	private Camera cam;
	// Use this for initialization
	void Start () {
		cam = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"), 0));
		float zoom = 1;
		if (Input.GetKey (KeyCode.P))
			zoom = 1.1f;
		if (Input.GetKey (KeyCode.O))
			zoom = 0.9f;
		cam.orthographicSize *= zoom; 
	}
}
