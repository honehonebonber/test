using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {
	public float power = 500f;
	private Rigidbody _rigidbody;

	// Use this for initialization
	void Start () {
		_rigidbody = this.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			this._rigidbody.AddForce (Vector3.up * power);
		}
	}
}
