/* Author: Tom Tsiliopoulos */
/* File: OceanController.cs */
/* Creation Date: Sept 21, 2015 */
/* Description: This script controls the ocean gameObject's movement */

using UnityEngine;
using System.Collections;

public class OceanController : MonoBehaviour {
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
		if (currentPosition.y <= -480) {
			this._Reset();
		}
	}

	// Resets our gameObject
	private void _Reset() {
		Vector2 resetPosition = new Vector2 (0.0f, 480f);
		gameObject.GetComponent<Transform> ().position = resetPosition;
	}
}
