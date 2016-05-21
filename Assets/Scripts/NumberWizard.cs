using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int max;
	int min;
	int guess;

	int maxGuessAllowed = 15;
	
	public Text text;

	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	void StartGame () {
		max = 1000;
		min = 1;
		NextGuess();
	}
	
	public void GuessHigher (){
		min = guess;
		NextGuess();
	}
	
	public void GuessLower () {
		max = guess;
		NextGuess();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			GuessHigher();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			GuessLower();
		} 
	}
	
	void NextGuess () {
		guess = Random.Range(min, max);
		text.text = guess.ToString();
		maxGuessAllowed = maxGuessAllowed - 1;
		if (maxGuessAllowed <= 0) {
			Application.LoadLevel("Win");
		}
	}
	
}
