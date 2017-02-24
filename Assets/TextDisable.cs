using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDisable : MonoBehaviour {
	//GameObject gO1 = GameObject.Find ("Patternpart1"); //.GetComponent(TextureHandling).
	//GameObject gO2 = GameObject.Find ("Patternpart2");
	//GameObject gO3 = GameObject.Find ("Patternpart3");
	GameObject child1, child2;
	// Use this for initialization
	void Start () {
		//print (GameObject.activeSelf);
		print ("hello");
		//GameObject gO3 = GameObject.Find ("WonMessage");
		//GameObject gO1 = new GameObject ();
		child1 = this.transform.FindChild("WonMessage").gameObject;
		child1.SetActive (false);
		child2 = this.transform.FindChild("LostMessage").gameObject;
		child2.SetActive (false);
		//Debug.Log(gO1.activeSelf);


		//print (GameObject.activeSelf);

	}

	// Update is called once per frame
	void Update () {
		//print ("bingo");
		GameObject gO1 = GameObject.Find ("Patternpart1");
		GameObject gO2 = GameObject.Find ("Patternpart2");
		GameObject gO3 = GameObject.Find ("Patternpart3");
		//Debug.Log(gO1.GetComponent<TextureHandling> ().tHrandomTexture);
		//Debug.Log(GetTexture.newRend1.material.mainTexture);
		//print(ChangeTexture.count);
		if (ChangeTexture.count == 3) {
			print (gO1.GetComponent<TextureHandling> ().tHrandomTexture + " - " +
			gO2.GetComponent<TextureHandling> ().tHrandomTexture + " - " +
			gO3.GetComponent<TextureHandling> ().tHrandomTexture);

			print (GetTexture.newRend1.material.mainTexture + " - " +
				GetTexture2.newRend2.material.mainTexture + " - " +
				GetTexture3.newRend3.material.mainTexture);
			
			if ((gO1.GetComponent<TextureHandling> ().tHrandomTexture.Equals(GetTexture.newRend1.material.mainTexture)) &&
				(gO2.GetComponent<TextureHandling> ().tHrandomTexture.Equals(GetTexture2.newRend2.material.mainTexture)) &&
				(gO3.GetComponent<TextureHandling> ().tHrandomTexture).Equals(GetTexture3.newRend3.material.mainTexture)) {
				print ("Bingo! - " + ChangeTexture.count );
				//this.gameObject.SetActive(true);
				child1.SetActive (true);
				//child2.SetActive (false);
			} 
			else
			{
				print ("Lost! - " + ChangeTexture.count );
				child2.SetActive (true);
				//child1.SetActive (false);
			}

		}

	}
}


