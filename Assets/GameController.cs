using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour{

	public float tScale = 1;

	void Start(){
		Time.timeScale = tScale;
	}
}
