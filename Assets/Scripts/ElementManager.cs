using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementManager : MonoBehaviour {

    //string[] ElementArray = { "Fire", "Water", "Air", "Ground"};
    string[] elementArray = { "Fire", "Water" };

    bool fireElementStatus = false;
    bool waterElementStatus = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //エレメントを引数にして、ステータスを更新する
    public bool ChangeElementStatus(string element){
        switch (element){
            case "Fire":
                //ステータス変える処理
                if (fireElementStatus) {
                    fireElementStatus = false;
                    return fireElementStatus;
                }
                else {
                    fireElementStatus = true;
                    return fireElementStatus;
                }
            case "Water":
                //ステータス変える処理
                if (waterElementStatus) {
                    waterElementStatus = false;
                    return waterElementStatus;
                }
                else {
                    waterElementStatus = true;
                    return waterElementStatus;
                }
        }
        return true;
    }

    //引数がないため、ボタンそれぞれにメソッドをつくる必要がある
    public bool ChangeFireElementStatus(){
        if (fireElementStatus) {
            fireElementStatus = false;
            return fireElementStatus;
        }else{
            fireElementStatus = true;
            return fireElementStatus;
        }

        //比較用：より簡潔い書く方法
        // bool型の場合は{!bool変数}で反対の値になるので、反転という動作では{bool = !bool}を使うことが多い
        //上は説明用として分かりやすくしている。
        //fireElementStatus = !fireElementStatus;
        //return fireElementStatus;

    }

    public string GetElementText(){
        string elementText = "";

        if(fireElementStatus){
            elementText += elementArray[0];
        }
        elementText += ", ";
        if (waterElementStatus) {
            elementText += elementArray[1];
        }

        //for (int i = 0; i < elementArray.Length; i++){
        //    //ほんとはFor文使ったほうが、より分かりやすくてシンプルだよね？
        //}

        return elementText;
    }
}
