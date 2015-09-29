using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {

	// PRIVATE INSTANCE VARIABLES
	private AudioSource[] _audioSources; // array of audio sources
	private AudioSource _cloudAudioSource, _islandAudioSource;

	// Use this for initialization
	void Start () {
		this._audioSources = this.GetComponents<AudioSource> ();
		this._cloudAudioSource = this._audioSources [1]; // reference thunder sound
		this._islandAudioSource = this._audioSources [2]; // reference to the yay sound
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D otherGameObject) {
		if (otherGameObject.tag == "Island") {
			this._islandAudioSource.Play(); // play the yay sound
		}

		if (otherGameObject.tag == "Cloud") {
			this._cloudAudioSource.Play(); // play the thunder sound
		}
	}
}
