using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
	[SerializeField]  KeyCode KeyOne;
	[SerializeField]  KeyCode KeyTwo;
	[SerializeField]  Vector3 MoveDirection;
	
	private void FixedUpdate(){
		if(Input.GetKey(KeyOne)){
			GetComponent<Rigidbody>().velocity += MoveDirection;
			
		}
		if(Input.GetKey(KeyTwo)){
			GetComponent<Rigidbody>().velocity -= MoveDirection;
			
		}
	}
	
}
