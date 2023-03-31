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
	public GameObject butt;

    

    public void ButtonScript() 
	{

		Button button = butt.GetComponent<Button>();
		button.onClick.AddListener(TaskOnClick);

        


    }

	public void TaskOnClick()
	{ 
        rand = Random.Range(0, greetings.Length);
        text = inputField.GetComponent<InputField>().text;

        textField.GetComponent<Text>().text = greetings[rand] + text.ToUpper() + "";
    }

	public void Update() 
	{
	ButtonScript();
	}

}
