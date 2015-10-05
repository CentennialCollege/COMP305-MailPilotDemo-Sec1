using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// PUBLIC METHODS

	// Start Button Event Handler
	public void OnStartButtonClick() {
		Application.LoadLevel ("Main");
	}

}
