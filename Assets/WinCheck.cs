using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCheck : MonoBehaviour {
    int rN1, rN2, rN3;
    public string currentCombination;
    public string[] maxWin = {"000", "111", "222", "333", "444", "555", "001", "112", "223", "334", "445", "556", "121","211"};
    //public string[] Win = { "000", "111", "222", "333", "444", "555" };
    // Use this for initialization
    void Start () {
        GameObject gO1 = GameObject.Find("Patternpart1");
        if (gO1 != null)
        {
            rN1 = gO1.GetComponent<TextureHandling>().randInt;
        }
        GameObject gO2 = GameObject.Find("Patternpart2");
        if (gO2 != null)
        {
            rN2 = gO2.GetComponent<TextureHandling>().randInt;
        }
        GameObject gO3 = GameObject.Find("Patternpart3");
        if (gO3 != null)
        {
            rN3 = gO3.GetComponent<TextureHandling>().randInt;

        }
        string stringrn1 = rN1.ToString();
        string stringrn2 = rN2.ToString();
        string stringrn3 = rN3.ToString();

        currentCombination = stringrn1 + stringrn2 + stringrn3;
        print(currentCombination);
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
