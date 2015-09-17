using UnityEngine;
using System.Collections;

public class variablesandfunctions : MonoBehaviour 
{
	int myInt = 45;

	void Start () 
		{
			myInt = kay (myInt);
			Debug.Log(myInt);
		}
		

	int kay(int variable)
		{
			int ret;
			ret = variable / 5;
			return ret;
		}
}
