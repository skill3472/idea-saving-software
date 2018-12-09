using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sliders : MonoBehaviour {

	public Slider difficultySlider;
	public Slider confidenceSlider;
	public Slider impactSlider;
	public int difficulty;
	public int confidence;
	public int impact;


	// Use this for initialization
	void Start () {
		difficultySlider = transform.GetChild(0).GetComponent<Slider>();
		impactSlider = transform.GetChild(1).GetComponent<Slider>();
		confidenceSlider = transform.GetChild(2).GetComponent<Slider>();
	}
	
	// Update is called once per frame
	public void SliderUpdateIndeed () {
		difficulty = (int)difficultySlider.value;
		confidence = (int)confidenceSlider.value;
		impact = (int)impactSlider.value;
		transform.GetChild(0).GetChild(3).GetComponent<Text>().text = "DIFFICULTY: " + difficulty.ToString();
		transform.GetChild(1).GetChild(3).GetComponent<Text>().text = "IMPACT: " + impact.ToString();
		transform.GetChild(2).GetChild(3).GetComponent<Text>().text = "CONFIDENCE: " + confidence.ToString();
	}
}
