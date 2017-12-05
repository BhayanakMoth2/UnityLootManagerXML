using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

   
    Ak47 ak_47;
	// Use this for initialization
	void Start () {

        ak_47 = new Ak47();
        ak_47.loadAk();
        ak_47.getName();
    }
	
	// Update is called once per frame
	void Update () {
      
	}
}
