using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public GameObject cloud;
	public int cloudCount;

	// Use this for initialization
	void Start () {
		this._CloudStart ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// adds cloudCount clouds to the scene
	private void _CloudStart() {
		for (int count=0; count< this.cloudCount; count++) {
			Instantiate(cloud); // add a cloud to the scene
		}
	}
}
