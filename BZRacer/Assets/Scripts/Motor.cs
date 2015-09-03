using UnityEngine;
using System.Collections;

public class Motor : MonoBehaviour {
	/* FL
	 * FR
	 * BL
	 * BR
	 */
	public Wheel[] wheels;

	// Use this for initialization
	void Start () {
	
	}
	
	void FixedUpdate () {
		float torque = Input.GetAxis("Vertical") * 20f;
	}
}
