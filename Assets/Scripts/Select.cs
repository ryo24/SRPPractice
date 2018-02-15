using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Select : MonoBehaviour {

    //public GameObject fire;
    //public GameObject water;
    ElementManager manager;

    string elementText;
    public Text ResultText;

	// Use this for initialization
	void Start () {
        manager = GameObject.Find("ElementManager").GetComponent<ElementManager>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SelectButton(){
        ResultText.text = "";
        elementText = "";

        //セレクトボタンもゲームのステータスは持たない。マネージャー
        elementText = manager.GetElementText();

        ResultText.text = elementText;

    }
}
