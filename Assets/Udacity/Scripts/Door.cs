using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in Update() 

	bool locked = false;

    void Update() {
		Vector3 door_position = transform.position;

		if (locked && door_position.x > -9.0f) {
			door_position.x -= 0.1f;
			transform.position = door_position;
		}
        // If the door is unlocked and it is not fully raised
            // Animate the door raising up
    }

    public void Unlock()
    {
		Debug.Log ("unlocked!");
		locked = true;		
        // You'll need to set "locked" to true here
    }
}
