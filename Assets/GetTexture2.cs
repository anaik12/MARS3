using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTexture2 : MonoBehaviour {
	public static Renderer newRend2;
	// Use this for initialization

	void Start () {

		newRend2 = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (ChangeTexture.isClick == true && ChangeTexture.count == 2) {
			//print ("got it!");

			//print("ONTexture2");
			//print(identifySlot["slot"]);
			//commenting the below line
			newRend2.material.mainTexture = ChangeTexture.currentTexture;
			//GetTe
			//ChangeTexture.isClick = false;

		}
	}
}
