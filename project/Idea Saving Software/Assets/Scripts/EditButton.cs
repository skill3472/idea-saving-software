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
	public Sliders slidersCS;

	void Start(){
		title = transform.GetChild(0).GetComponent<InputField>();
		description = transform.GetChild(1).GetComponent<InputField>();
		title.interactable = false;
		description.interactable = false;
		slidersCS = GameObject.Find("Sliders Empty").GetComponent<Sliders>();
		slidersCS.difficultySlider.interactable = false;
		slidersCS.confidenceSlider.interactable = false;
		slidersCS.impactSlider.interactable = false;
	}


	
	public void OnEditClick()
	{
		if(isEditing == true)
		{
			isEditing = false;
			title.interactable = false;
			description.interactable = false;
			transform.GetChild(3).GetComponent<Image>().color = Color.white;
			slidersCS.difficultySlider.interactable = false;
			slidersCS.confidenceSlider.interactable = false;
			slidersCS.impactSlider.interactable = false;
		}
		else
		{
			isEditing = true;
			title.interactable = true;
			description.interactable = true;
			transform.GetChild(3).GetComponent<Image>().color = Color.green;
			slidersCS.difficultySlider.interactable = true;
			slidersCS.confidenceSlider.interactable = true;
			slidersCS.impactSlider.interactable = true;
		}

	}

}
