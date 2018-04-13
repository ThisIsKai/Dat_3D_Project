using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMovementScript : MonoBehaviour {

	[SerializeField] 																// makes it editable in the inspector
	bool isRight;																	// is it the Right Control

	[SerializeField] 																// makes it editable in the inspector
	float speed = 0.2f;      	 													// paddle speed

	Transform myTransform;															// reference to the object's transform
	int direction = 0; 																// 0 = not moving, 1= up, -1 = down
	private Rigidbody rb; 															// rigidbody is rb now


	void Start () {																	// Start function
		myTransform = transform; 													// define myTransform
		rb = GetComponent<Rigidbody>(); 											// get that rigidbody
	//	col = GetComponent<CapsuleCollider2D>();									// get that collider
	}//END START


	void FixedUpdate () {															// FixedUpdate is called once per physics tick/frame
		if (isRight) {																// is this the right control?
			if (Input.GetKey ("o"))													// make o the up key for right control
				MoveUp (); 															// call move up
			else if (Input.GetKey ("l")) 											// make l the down key for right control
				MoveDown (); 														// call move down
			else {																	// else
				rb.velocity = Vector3.zero; 										// otherwise don't move
			} //end else not moving
		} //end right side control scheme

		else { 																		// if it's not right control (making it left)
			if (Input.GetKey ("q")) 												// make q the up key for the left control
				MoveUp ();															// call move up
			else if (Input.GetKey ("a"))											// make a the down key for left control
				MoveDown (); 														// call move down
			else {																	// else
				rb.velocity = Vector3.zero;											// otherwise don't move
			} //end else not moving
		} //end left side control scheme
	}//END FIXED UPDATE

	void MoveUp() { 																// MoveUp function, to move control up, effected by 'speed'
		rb.velocity = new Vector3(0, speed,0);										// simplified upwards movement
	}//END MOVE UP

	void MoveDown() {																// MoveDown function, to move control down, effected by 'speed'
		rb.velocity = new Vector3(0, -speed,0); 									// simplified downwards momvement
	}//END MOVE DOWN
		
}//END SCRIPT