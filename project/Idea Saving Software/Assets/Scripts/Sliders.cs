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
	void Update () {
		difficulty = (int)difficultySlider.value;
		confidence = (int)confidenceSlider.value;
		impact = (int)impactSlider.value;
	}
}
