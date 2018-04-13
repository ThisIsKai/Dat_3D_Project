using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour {
	

		void OnCollision(Collision other) {								// collision function,for when ball hits this goal
			if(other.gameObject.tag == "Ball") {						// if the other object (the one hitting this object) has a tag that is "Ball" THEN
				Destroy (this.gameObject);								// destroy this game object (the one this script is attached to)
			} // end destroy
		
	}//END ON TRIGGER

}// END SCRIPT "GOALSCRIPT"
