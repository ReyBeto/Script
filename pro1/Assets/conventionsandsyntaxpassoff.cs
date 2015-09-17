using UnityEngine;
using System.Collections;

public class conventionsandsyntaxpassoff : MonoBehaviour
{
	float overFloor = 85.0f;
	float midairLimitFloor = 70.0f;
	float bottomLimitFloor= 40.0f;

	void Start ()
	{
		//This is a single line comment.
		
		/*This is a multiple line comment or block 
		of code that needs to be commented out.
		*/
	}

	void Update()
	{
		//The following line of code is used to track the position on the falling cube. Enter the correct convention.
		Debug.Log ();

		/*The following statement will tell unity when to print "I'm going to splater!" to the console if the cube is < or = 10. 
		Enter the correct statement.
		*/
		if (Input.GetKeyDown (KeyCode.Space)) 
			Falltest ();	
		{
			Debug.Log ("I'm going to splater!");
		}
	}
}