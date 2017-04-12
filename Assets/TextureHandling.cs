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
    //changed from public static while accesing from Wincheck
	public static int randomNumber;
    public int randInt;
	//public static Texture2D randomTexture;

	//Texture randomizeTexture(){
		
		
	//}

	// Use this for initialization
	 void Start () {
		int randomNumber = Random.Range(0, texArray.Length-1); //Pick a random number between first index and last accessible index
        randInt = randomNumber;
        tHrandomTexture = texArray[randomNumber];
		rend.material.mainTexture = tHrandomTexture;
		
	}
	
	// Update is called once per frame
	void Update () {
		//int randomNumber = Random.Range(0, texArray.Length-1); //Pick a random number between first index and last accessible index
		//randomTexture = texArray[randomNumber];
		rend.material.SetTexture (randomNumber, tHrandomTexture);
		
	}
    public void onChangeTexture()
    {
        Debug.Log("In Change Texture");
        //Debug.Log(texArray.Length - 1);
        if (texArray == null) Debug.Log("TextArrayNull");
        int randomNumber = Random.Range(0, texArray.Length - 1); //Pick a random number between first index and last accessible index
        randInt = randomNumber;
        tHrandomTexture = texArray[randomNumber];
        rend.material.mainTexture = tHrandomTexture;


    }
}
