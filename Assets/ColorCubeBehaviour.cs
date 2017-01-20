﻿using UnityEngine;
using System.Collections;

public class ColorCubeBehaviour : MonoBehaviour {
	private RandomColor _randomColor;

	void Awake(){
		_randomColor = this.GetComponent<RandomColor> ();
	}
	void OnCollisionEnter(Collision coll){
		Renderer renderer = coll.gameObject.GetComponent<Renderer> ();
		renderer.material.color = _randomColor.GetBodyColor ();

		_randomColor.ChangeColor ();
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
