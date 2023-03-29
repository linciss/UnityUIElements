using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class ShowWord : MonoBehaviour {
	private string text;
	private string[] greetings = {"Hello", "Good day", "Good to see you", "Bye"};
	int rand;

	public GameObject inputField;
	public GameObject textField;
	public GameObject button;

	public void SaveText() 
	{
		rand = Random.Range(0, greetings.Length);
		text = inputField.GetComponent<Text>().text;
		textField.GetComponent<Text>().text = greetings[rand]+text.ToUpper()+"";
	
	}



	// Use this for initialization
		

	/*void Start () {
		
    }
	
	// Update is called once per frame
	void Update () {
		
    }*/
}
