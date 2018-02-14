using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Select : MonoBehaviour {

    public GameObject fire;
    public GameObject water;
    ElementManager objectSomething;

    string elementText;

    public Text ResultText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SelectButton(){
        ResultText.text = "";

        if(fire.GetComponent<FireButton>().isClicked){
            elementText += "Fire, ";
        }
        if (water.GetComponent<WaterButton>().isClicked) {
            elementText += "Water, ";
        }

        ResultText.text = elementText;

    }
}
