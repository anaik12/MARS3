using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTexture3 : MonoBehaviour {
	public static Renderer newRend3;


	// Use this for initialization
	void Start () {
		
		newRend3 = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (ChangeTexture.isClick == true && ChangeTexture.count == 3) {
			//print ("got it!");

			//print("ONTexture3");
			//print(identifySlot["slot"]);

			newRend3.material.mainTexture = ChangeTexture.currentTexture;
			//GetTe
			//ChangeTexture.isClick = false;

		}
	}
}
