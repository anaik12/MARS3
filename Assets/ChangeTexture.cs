﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;

public class ChangeTexture : MonoBehaviour {
	public float scrollSpeed = 0.5F;
	public Renderer rend;
	public Texture text1;
	public Texture text2;
	public Texture text3;
	public Texture text4;
	public Texture text5;
	public Texture randomTexture;
	public static bool isClick;
	public static Texture currentTexture;
	public static int count = 0;
	private Texture gt1currentTexture, gt2currentTexture, gt3currentTexture;
	private int randomNumber1, randomNumber2;
    private string[] maxWin = { "000", "111", "222", "333", "444", "555", "001", "112", "223", "334", "445", "556", "121", "211","100","200","300","400","500","600" };
    public int score = 0;
    TextureHandling objTexture = new TextureHandling();
    //public static bool win ;
    public static int win = 0;


    // Use this for initialization
    void Start () {
		rend = GetComponent<Renderer>();
	}

    //ChangeTexture(TextureHandling tH) {

    //    this.objTexture = tH;
    //}

	private void setCurrentTexture(Texture newTexture){
		rend.material.mainTexture = newTexture;
	}

	public Texture getCurrentTexture(){
		return rend.material.mainTexture;
	}
    int countb = 0; 
    void OnMouseDown () {
		print ("Box Clicked!" + countb);
        countb++;
        
        //objTexture.onChangeTexture();

        //count++;
        //isClick = true;
        //currentTexture = rend.material.mainTexture;
        ////int randomNumber1 = 3; //Random.Range (0, temptexArray.Length - 1);
        ////int randomNumber2 = 2; //Random.Range (0, temptexArray.Length - 2);
        ////int randomNumber3 = 1;
        //if (count == 1)
        //	gt1currentTexture = getCurrentTexture();
        //if (count == 2)
        //	gt2currentTexture = getCurrentTexture();
        //if (count == 3) {
        //	gt3currentTexture = getCurrentTexture();
        //	//if (count == 3)
        //	//WaitForSeconds();
        //	//callerself();
        //	//printMessage ();
        //	randomizeTextures ();
        //}
        print(WinCheck.currentCombination);
        foreach (string str in maxWin)
        {
            if (str.Equals(WinCheck.currentCombination))
            {
                score = score + 100;
                print(score);
                win = 1;
                break;
            }
          
                win = 2;
                //print("you Lost");
            
        }
        
    
    }

    //private bool IsHand(Collider other)
    //{
    //    if (other.transform.parent && other.transform.parent.parent && other.transform.parent.parent.GetComponent<Hand.Equals()> ())
    //        return true;
    //    else
    //        return false;
    //}

    void OnTriggerExit(Collider other)
    {
        ////if (IsHand(other))
        ////{
        ////    Debug.Log("Yay! A hand collided!");
        ////}
        ////Debug.Log("Yay! A hand collided!");
        //count++;
        //Debug.Log("Yay! A hand collided!" + " " + count);
        //isClick = true;
        //currentTexture = rend.material.mainTexture;
        ////int randomNumber1 = 3; //Random.Range (0, temptexArray.Length - 1);
        ////int randomNumber2 = 2; //Random.Range (0, temptexArray.Length - 2);
        ////int randomNumber3 = 1;
        //if (count == 1)
        //    gt1currentTexture = getCurrentTexture();
        //if (count == 2)
        //    gt2currentTexture = getCurrentTexture();
        //if (count == 3)
        //{
        //    gt3currentTexture = getCurrentTexture();
        //    //if (count == 3)
        //    //WaitForSeconds();
        //    //callerself();
        //    //printMessage ();
        //    randomizeTextures();
        // }
        print(WinCheck.currentCombination);
    }

    void callerself(){
		randomizeTextures ();
	}

	void randomizeTextures(){
		//GetTexture gt1 = new GetTexture ();
		//Debug.Log ("hello");
		//temptexArray[0] = GetTexture.gt1CurrentTexture;
		//temptexArray[1] = GetTexture2.newRend2.material.mainTexture;
		//temptexArray[2] = GetTexture3.newRend3.material.mainTexture;
		//int randomNumber1 = Random.Range (0, temptexArray.Length - 1);
		//int randomNumber2 = Random.Range (0, temptexArray.Length - 2);
		//int randomNumber3 = Random.Range (0, texArray.Length - 1);

		//GetTexture.newRend1.material.mainTexture = gt2currentTexture;
		//GetTexture2.newRend2.material.mainTexture = gt1currentTexture;
		//GetTexture3.newRend3.material.mainTexture = gt2currentTexture;
		//GameObject.Find ("Won").SetActive(false);
		//printMessage ();

	}

	void printMessage(){
		GameObject gO1 = GameObject.Find ("Patternpart1"); //.GetComponent(TextureHandling).
		GameObject gO2 = GameObject.Find ("Patternpart2");
		GameObject gO3 = GameObject.Find ("Patternpart3");
		//GameObject gO4 = 
			GameObject.Find ("Won").SetActive(true);
//		transform.Find.("Patternpart1")
		if(gO1 != null){// && gO4 != null){ //&& gO2 != null && gO3 != null){
			Debug.Log(gO1.GetComponent<TextureHandling> ().tHrandomTexture);
			Debug.Log(GetTexture.newRend1.material.mainTexture);
			if ((gO1.GetComponent<TextureHandling> ().tHrandomTexture) ==
				GetTexture.newRend1.material.mainTexture)// &&
				//(gO2.GetComponent<TextureHandling> ().tHrandomTexture) ==
				//	GetTexture2.newRend2.material.mainTexture &&
			    //(gO3.GetComponent<TextureHandling> ().tHrandomTexture) ==
					//GetTexture3.newRend3.material.mainTexture){
			{
				print ("Bingo!");
				//gO4.SetActive (true);
			}
		}
			
	}

	// Update is called once per frame
	void Update () {
		float offset = Time.time * scrollSpeed;

		if((int)offset % 5 == 0)
			setCurrentTexture(text1);	
		if((int)offset % 5 == 1)
			setCurrentTexture(text2);
		if((int)offset % 5 == 2)
			setCurrentTexture(text3);
		if((int)offset % 5 == 3)
			setCurrentTexture(text4);
		if((int)offset % 5 == 4)
			setCurrentTexture(text5);
		
		isClick = false;

		/*if (Input.GetMouseButtonDown (0)) {
			//print ("mouseclick" + offset);
			count++;
			isClick = true;
			currentTexture = rend.material.mainTexture;
			//print(rend.material.mainTexture);

		}*/

	}
}