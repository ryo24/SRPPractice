using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireButton : MonoBehaviour {

    public string element = "Fire";
    public bool isClicked;


	// Use this for initialization
	void Start () {
        isClicked = false;
		
	}

    //基本はこのボタンが押されたことを連絡するだけ
    public void pressed(){
        if (isClicked) {
            isClicked = !isClicked;
            GameObject.Find("FireText").GetComponent<Text>().text = "Fire";

        }
        else {
            isClicked = !isClicked;
            GameObject.Find("FireText").GetComponent<Text>().text = "Fire\nPressed";

        }        
    }
}
