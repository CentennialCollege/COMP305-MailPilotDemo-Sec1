/* Author: Tom Tsiliopoulos */
/* File: CloudController.cs */
/* Creation Date: Sept 22, 2015 */
/* Description: This script controls the cloud gameObject's movement */

using UnityEngine;
using System.Collections;

// speed class
[System.Serializable]
public class Speed {
	public float xMin, xMax, yMin, yMax;
}

// boundary class
[System.Serializable]
public class Boundary {
	public float xMin, xMax, yMin, yMax;
}

public class CloudController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public Speed speed;
	public Boundary boundary;

	// PRIVATE INSTANCE VARIABLES
	private float _currentSpeed;
	private float _currentDrift;

	// Use this for initialization
	void Start () {
		this._Reset ();
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 currentPosition = new Vector2 (0.0f, 0.0f);
		currentPosition = gameObject.GetComponent<Transform> ().position;
		currentPosition.y -= this._currentSpeed; // move object down the screen
		currentPosition.x += this._currentDrift; // move object left or right
		
		// move the gameObject to the currentPosition
		gameObject.GetComponent<Transform> ().position = currentPosition;
		
		// top boundary check - gameObject meets top of camera viewport
		if (currentPosition.y <= boundary.yMin) {
			this._Reset();
		}
	}
	
	// Resets our gameObject
	private void _Reset() {
		this._currentSpeed = Random.Range (speed.yMin, speed.yMax);
		this._currentDrift = Random.Range (speed.xMin, speed.xMax);
		Vector2 resetPosition = new Vector2 (Random.Range(boundary.xMin,boundary.xMax), boundary.yMax);
		gameObject.GetComponent<Transform> ().position = resetPosition;
	}
}
