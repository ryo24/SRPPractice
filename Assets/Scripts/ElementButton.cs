using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElementButton : MonoBehaviour {

    //インスペクターから指定する
    public string element;
    //public bool isClicked;

    ElementManager manager;

	// Use this for initialization
	void Start () {
        //isClicked = false;
        manager = GameObject.Find("ElementManager").GetComponent<ElementManager>();
		
	}

    //基本はこのボタンが押されたことを連絡するだけ
    public void pressed(){

        //managerに連絡して、結果をもとに自分を更新
        if(manager.ChangeElementStatus(element)){
            //ボタンの情報を変えるだけ
            transform.Find("elementText").GetComponent<Text>().text = element+ "\nPressed";
        }else{
            transform.Find("elementText").GetComponent<Text>().text = element ;
        }

        //比較用１：監督スクリプトを利用しているが、ボタンごとの情報（IsFireButtonPressed()と”Fire"）
        //　　　　　が入っているため、ボタン毎（エレメントを増やす毎）にスクリプトを作る必要がある。
        //if (!manager.IsFireButtonPressed()) {
        //    //ボタンの情報を変えるだけ
        //    GameObject.Find("FireText").GetComponent<Text>().text = "Fire";
        //}
        //else {
        //    GameObject.Find("FireText").GetComponent<Text>().text = "Fire\nPressed";
        //}

        //比較用２：一番最初のパターンのコメントアウト。ボタンごとにメソッドを準備する
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
