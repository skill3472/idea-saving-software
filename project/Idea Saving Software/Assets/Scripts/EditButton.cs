using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditButton : MonoBehaviour {

	public bool isEditing = false;
	public InputField description;
	public InputField title;
	public Text pholderDescription;
	public Text pholderTitle;

	void Start(){
		title = transform.GetChild(0).GetComponent<InputField>();
		description = transform.GetChild(1).GetComponent<InputField>();
		title.interactable = false;
		description.interactable = false;

	}


	
	public void OnEditClick()
	{
		if(isEditing == true)
		{
			isEditing = false;
			title.interactable = false;
			description.interactable = false;
			transform.GetChild(5).GetComponent<Image>().color = Color.white;
		}
		else
		{
			isEditing = true;
			title.interactable = true;
			description.interactable = true;
			transform.GetChild(5).GetComponent<Image>().color = Color.green;
		}

	}

}
