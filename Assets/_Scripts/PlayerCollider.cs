using UnityEngine;
using System.Collections;
using UnityEngine.UI; // add this using statement

public class PlayerCollider : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public Text ScoreLabel;
	public Text LivesLabel;

	// PRIVATE INSTANCE VARIABLES
	private AudioSource[] _audioSources; // array of audio sources
	private AudioSource _cloudAudioSource, _islandAudioSource;

	private int _score = 0;
	private int _lives = 5;

	// Use this for initialization
	void Start () {
		this._audioSources = this.GetComponents<AudioSource> ();
		this._cloudAudioSource = this._audioSources [1]; // reference thunder sound
		this._islandAudioSource = this._audioSources [2]; // reference to the yay sound

		this._ScoreUpdate ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void _ScoreUpdate() {
		this.ScoreLabel.text = "Score: " + this._score;
		this.LivesLabel.text =  "Lives: " + this._lives;
	}

	void OnTriggerEnter2D(Collider2D otherGameObject) {
		if (otherGameObject.tag == "Island") {
			this._islandAudioSource.Play(); // play the yay sound
			this._score += 100;
		}

		if (otherGameObject.tag == "Cloud") {
			this._cloudAudioSource.Play(); // play the thunder sound
			this._lives -= 1;
			// End the game when lives are less than or equal to zero
			if(this._lives <= 0) {
				this._endGame();
			}
		}

		this._ScoreUpdate ();
	}

	// PRIVATE METHODS
	private void _endGame() {
		Application.LoadLevel ("GameOver");
	}
}
