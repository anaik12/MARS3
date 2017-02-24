using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureHandling : MonoBehaviour {
	//public Texture apple;
	//public Texture orange;
	//public Texture banana;
	//public Texture peach;
	public Texture2D[] texArray;
	public Renderer rend;
	public Texture tHrandomTexture;
	public static int randomNumber;
	//public static Texture2D randomTexture;

	//Texture randomizeTexture(){
		
		
	//}

	// Use this for initialization
	void Start () {
		int randomNumber = Random.Range(0, texArray.Length-1); //Pick a random number between first index and last accessible index
		tHrandomTexture = texArray[randomNumber];
		rend.material.mainTexture = tHrandomTexture;
		
	}
	
	// Update is called once per frame
	void Update () {
		//int randomNumber = Random.Range(0, texArray.Length-1); //Pick a random number between first index and last accessible index
		//randomTexture = texArray[randomNumber];
		rend.material.SetTexture (randomNumber, tHrandomTexture);
		
	}
}
