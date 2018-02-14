using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireButton : MonoBehaviour {

    public string element = "Fire";
    public bool isClicked;

    ElementManager manager;

	// Use this for initialization
	void Start () {
        isClicked = false;
        manager = GameObject.Find("ElementManager").GetComponent<ElementManager>();
		
	}

    //基本はこのボタンが押されたことを連絡するだけ
    public void pressed(){

        //manager.isFireActved
         //      →アクティブならアクティブではなくする
        // アクティブでなければアクティブ
        if(!manager.IsFireButtonPressed()){
            //ボタンの情報を変えるだけ
            GameObject.Find("FireText").GetComponent<Text>().text = element;

        }else{
            GameObject.Find("FireText").GetComponent<Text>().text = element + "\nPressed";
   
        }


        //if (isClicked) {
        //    isClicked = !isClicked;
        //    GameObject.Find("FireText").GetComponent<Text>().text = "Fire";

        //}
        //else {
        //    isClicked = !isClicked;
        //    GameObject.Find("FireText").GetComponent<Text>().text = "Fire\nPressed";

        //}        
    }
}
