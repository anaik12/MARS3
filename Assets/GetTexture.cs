using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTexture : MonoBehaviour {
	//ChangeTexture cT = new ChangeTexture();
	public static Renderer newRend1;
	public static int counter = 1;
	public Dictionary<string, int> identifySlot = new Dictionary<string, int>();
	public static Texture gt1CurrentTexture;
	// Use this for initialization
	void Start () {
		newRend1 = GetComponent<Renderer>();
		identifySlot.Add("slot", counter);
	}
	
	// Update is called once per frame
	void Update () {
		//print(identifySlot.Values);
		//print ("inside update");
		if (ChangeTexture.isClick == true && ChangeTexture.count == 1) {
			//print ("got it!");

			//identifySlot["slot"] = ++counter;
			//print (newRend.name);
			//print(identifySlot["slot"]);
			//print("ONTexture1");
			gt1CurrentTexture = ChangeTexture.currentTexture;
			newRend1.material.mainTexture = gt1CurrentTexture;
			//GetTe
			//ChangeTexture.isClick = false;
		}
		//ChangeTexture.isClick = false;
	}
}
