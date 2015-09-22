using UnityEngine;
using System.Collections;

public class conventionsandsyntaxpassoff : MonoBehaviour
{
    public float cubeTop = 20.0f;
    float midairLimitFloor = 10.0f;
    float bottomLimitFloor = 0.0f;

    void Update()
    {
        //This is a single line comment.

        /*This is a multiple line comment or block 
		of code that needs to be commented out.
		*/
		if (Input.GetKeyDown(KeyCode.Mouse0))
            Falltest();

        cubeTop -= Time.deltaTime * 10f;
    }

    void Falltest()
    {
        /*The following line of code is used to track the position on the falling cube. Enter the correct convention.
       ; The following statement will tell unity when to print "I'm going to splater!" to the console if the cube is < or = 10. 
       Enter the correct statement.
       */
        if (cubeTop < midairLimitFloor)
        {
			print("SPLAT!");
        }
        else if (cubeTop <= bottomLimitFloor)
        {
            print("I'm going to splater!");
        }
        else
        {
			print("I'm Falling!");
        }
    }
}   