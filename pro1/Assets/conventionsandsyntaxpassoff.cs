using UnityEngine;
using System.Collections;

public class conventionsandsyntaxpassoff : MonoBehaviour
{
    float cubeTop = 50.0f;
    float midairLimitFloor = 26.0f;
    float bottomLimitFloor = 0.0f;

    void Start()
    {
        //This is a single line comment.

        /*This is a multiple line comment or block 
		of code that needs to be commented out.
		*/
        if (Input.GetKeyDown(KeyCode.Space))
            Falltest();

        cubeTop -= Time.deltaTime * 2f;
    }

    void Falltest()
    {
        /*The following line of code is used to track the position on the falling cube. Enter the correct convention.
       ; The following statement will tell unity when to print "I'm going to splater!" to the console if the cube is < or = 10. 
       Enter the correct statement.
       Debug.Log(50.0f)
       */
        if (cubeTop < midairLimitFloor)
        {
            Debug.Log("I'm Falling!");
        }
        else if (cubeTop <= bottomLimitFloor)
        {
            Debug.Log("I'm going to splater!");
        }
        else
        {
            Debug.Log("SPLAT!");
        }
    }
}   