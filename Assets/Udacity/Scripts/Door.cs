using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
	bool locked = false;

    void Update() {
		Vector3 door_position = transform.position;

		if (locked && door_position.x > -9.0f) {
			door_position.x -= 0.1f;
			transform.position = door_position;
		}
    }

    public void Unlock()
    {
		Debug.Log ("unlocked!");
		locked = true;		
		transform.GetComponent<AudioSource> ().Play ();
    }
}
