using UnityEngine;
using System.Collections;

public class ifstatments : MonoBehaviour 
{
	float coffeeTemperature = 85.0f;
	float hotLimitTemperature = 70.0f;
	float coldLimitTemperature = 40.0f;
	// Use this for initialization
	void Start () 
	{
		if (Input.GetKeyDown (KeyCode.Space))
			TemperatureTest ();

		coffeeTemperature -= Time.deltaTime * 5f;
	
	}
	void TemperatrueTest ()
	{
		if (coffeeTemperature > hotLimitTemperature) {
			print ("Coffee is Too Hot.");
		} else if (coffeeTemperature < coldLimitTemperature) {
			print ("Coffee is Just Right.");
		} else {
			print ("coffee is Just Right.");
		}
	}
}
