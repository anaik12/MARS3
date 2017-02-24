using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlane : MonoBehaviour {
	public float scrollSpeed = 0.5F;
	// Use this for initialization
	void Start () {
		
	}



	// Update is called once per frame
	void FixedUpdate () {
		float offset = Time.time * scrollSpeed;
		//transform.Translate(0, 0, Time.deltaTime * 10);
		//print (offset);
		if((int)offset % 5 == 0 && offset % 5 < 0.01F) {
			transform.position = new Vector3 (Random.Range (-5, 5), Random.Range (-4, 4), 0);
			//print (offset);
		}
		//print(transform.position.x);
	}
}
