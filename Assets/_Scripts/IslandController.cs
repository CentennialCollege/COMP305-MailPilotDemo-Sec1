/* Author: Tom Tsiliopoulos */
/* File: IslandController.cs */
/* Creation Date: Sept 21, 2015 */
/* Description: This script controls the ocean gameObject's movement */

using UnityEngine;
using System.Collections;

public class IslandController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public float speed;
	
	// Use this for initialization
	void Start () {
		this._Reset ();
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 currentPosition = new Vector2 (0.0f, 0.0f);
		currentPosition = gameObject.GetComponent<Transform> ().position;
		currentPosition.y -= speed;
		
		// move the gameObject to the currentPosition
		gameObject.GetComponent<Transform> ().position = currentPosition;
		
		// top boundary check - gameObject meets top of camera viewport
		if (currentPosition.y <= -270) {
			this._Reset();
		}
	}
	
	// Resets our gameObject
	private void _Reset() {
		Vector2 resetPosition = new Vector2 (0.0f, 270f);
		gameObject.GetComponent<Transform> ().position = resetPosition;
	}
}
