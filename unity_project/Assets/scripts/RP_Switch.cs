using UnityEngine;
using System.Collections;

public class RP_Switch : MonoBehaviour {

	public GameObject lever;

	private bool MoveLever = true;

	/*void Update(){
		if (Input.GetMouseButtonDown (0) && MoveLever == false) {
			MoveLever = true;
		} else if (Input.GetMouseButtonDown (0) && MoveLever== true) {
			MoveLever = false;
		}
	}

	void FixedUpdate(){
		Rigidbody rb = lever.GetComponent<Rigidbody> ();


		if (MoveLever) {
			RotateLever ();
		}
		if(!MoveLever){
			RotateLever ();
		}
	}

	void RotateLever(){
		float x = lever.transform.rotation.x;
		float y = lever.transform.rotation.y;
		float z = lever.transform.rotation.z;
		Vector3 move = new Vector3 (x + 90.0f, y, z);
		lever.transform.rotation = Quaternion.Euler (move);
	} // */

	void OnMouseDown(){
		float x = lever.transform.rotation.x;
		float y = lever.transform.rotation.y;
		float z = lever.transform.rotation.z;
		if (MoveLever) {
			Vector3 move = new Vector3 (90.0f, y, z);
			lever.transform.rotation = Quaternion.Euler (move);
			MoveLever = false;
		} else if (!MoveLever) {
			Vector3 move = new Vector3 (0.0f, y, z);
			lever.transform.rotation = Quaternion.Euler (move);
			MoveLever = true;
		}
	}
}
