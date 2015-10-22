using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ControllerGame : MonoBehaviour {

	[SerializeField] Text scoreText;
	[SerializeField] Text distanceText;

	[SerializeField] float distanceInterval = 1;
	float distanceTimer = 0;

	int oldScore;

	[SerializeField] int currentScore = 0;

	#region START/UPDATE
	// Use this for initialization
	void Start () {
		distanceText.text = "0M";
		oldScore = int.Parse (scoreText.text.ToString());
	}
	
	// Update is called once per frame
	void Update () {
		UpdateScore ();
		UpdateDistance ();
		IfEscapePressed ();
	}
	#endregion START/UPDATE

	#region YOUR FUNCTIONS
	void UpdateScore() {
		if (oldScore < currentScore) {
			oldScore++;
			scoreText.text = oldScore.ToString ();
		} else if (oldScore > currentScore) {
			oldScore--;
			scoreText.text = oldScore.ToString ();
		}
	}

	void UpdateDistance(){
		if (distanceTimer >= distanceInterval) {
			int x = int.Parse (distanceText.text.Replace ("M", ""));
			x++;
			distanceText.text = x + "M";
			distanceTimer = 0;
		}
		distanceTimer += Time.deltaTime;
	}

	void IfEscapePressed(){
		if (Input.GetKey (KeyCode.Escape))
			Application.LoadLevel (0);
	}
	#endregion YOUR FUNCTIONS

	#region MAKE THINGS EASIER CODE
	void Increment(int i){
		currentScore += i;
	}
	
	void Decrement(int i){
		currentScore -= i;
	}
	#endregion MAKE THINGS EASIER CODE
}
