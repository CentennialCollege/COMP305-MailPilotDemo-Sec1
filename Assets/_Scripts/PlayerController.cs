/* Author: Tom Tsiliopoulos */
/* File: PlayerController.cs */
/* Creation Date: Sept 22, 2015 */
/* Description: This script controls the player gameObject's movement */

using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// PUBLIC INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++
	public Vector2 move = new Vector2 (0.0f, 0.0f);
	public Boundary boundary;
	
	// PRIVATE INSTANCE VARIABLES
	private Vector2 _newPosition = new Vector2(0.0f, 0.0f);
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		this._CheckInput ();

	}

	// checkInput method
	private void _CheckInput() {

		this._newPosition = gameObject.GetComponent<Transform> ().position; // current position
		
		if (Input.GetAxis ("Horizontal") > 0) {
			this._newPosition.x += this.move.x; // add move value to current position
			//gameObject.GetComponent<Transform>().position = this._newPosition;
		}
		if (Input.GetAxis ("Horizontal") < 0) {
			this._newPosition.x -= this.move.x; // subtract move value to current position
			//gameObject.GetComponent<Transform>().position = this._newPosition;
		}

		// boundary check
		if ((this._newPosition.x) < this.boundary.xMin) {
			this._newPosition.x = this.boundary.xMin;
			//gameObject.GetComponent<Transform>().position = this._newPosition;
		}

		if ((this._newPosition.x) > this.boundary.xMax) {
			this._newPosition.x = this.boundary.xMax;
			//gameObject.GetComponent<Transform>().position = this._newPosition;
		}
		gameObject.GetComponent<Transform>().position = this._newPosition;
	}
}
