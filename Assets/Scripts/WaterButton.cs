﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterButton : MonoBehaviour {

    public string element = "Water";
    public bool isClicked; //アクティブかどうか


	// Use this for initialization
	void Start () {
        isClicked = false;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Pressed(){
        if(isClicked){
            isClicked = !isClicked;
            GameObject.Find("WaterText").GetComponent<Text>().text = element;

        }else{
            isClicked = !isClicked;
            GameObject.Find("WaterText").GetComponent<Text>().text = element + "\nPressed";

        }
    }
}
