using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Select : MonoBehaviour {

    public GameObject fire;
    public GameObject water;

    public Text ResultText;

    string elementText;

	// Use this for initialization
	void Start () {
		
	}
	

    public void SelectButton(){
        ResultText.text = "";
        elementText = "";

        if(fire.GetComponent<FireButton>().isClicked){
            elementText += "Fire, ";
        }
        if (water.GetComponent<WaterButton>().isClicked) {
            elementText += "Water, ";
        }

        ResultText.text = elementText;

    }
}
