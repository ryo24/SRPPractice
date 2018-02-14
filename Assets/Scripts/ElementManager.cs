using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementManager : MonoBehaviour {

    string[] ElementArray = { "Fire", "Water" };

    bool fireElementActived = false;
    bool waterElementActived = false;

	// Use this for initialization
	void Start () {

		
	}

    public bool IsFireButtonPressed(){
        if (fireElementActived) {
            fireElementActived = false;
            return true;
        }else{
            fireElementActived = true;
            return false;
        }
    }

    //public bool CheckElementAcitve(string element){
    //    switch (element){
    //        case "Fire":

    //            break;
    //    }


    //    return true;
    //}
}
