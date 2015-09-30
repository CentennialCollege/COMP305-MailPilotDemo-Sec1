using UnityEngine;
using System.Collections;

public class PlayerAnimator : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public Sprite[] sprites;
	public float framesPerSecond;

	// PRIVATE INSTANCE VARIABLES
	private SpriteRenderer _spriteRenderer;

	// Use this for initialization
	void Start () {
		this._spriteRenderer = gameObject.GetComponent<SpriteRenderer> () as SpriteRenderer;
	}
	
	// Update is called once per frame
	void Update () {
		int index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
		index = index % (sprites.Length - 1);
		this._spriteRenderer.sprite = this.sprites [index];
	}
}
