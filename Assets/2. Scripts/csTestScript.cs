using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class csTestScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Text thisText = this.GetComponent<Text>();

        thisText.text = "I hate Hello World!! \nhahaha!! \nkby";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
