using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    /*[SerializeField] float xValue = 0.0f;*/
/*    [SerializeField] float yValue = 0.02f;
*/    [SerializeField] float moveSpeed = 10f;
    /* [SerializeField] float zValue = 0.0f;*/

    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis ("Horizontal") *Time.deltaTime* moveSpeed;
        float zValue = Input.GetAxis("Vertical") *Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }

    void PrintInstruction()
    {
        Debug.Log("Dont hit the wall");
    }


}
