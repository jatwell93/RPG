using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private BoxCollider2D coll;
    private Vector3 moveDelta;

    // Start is called before the first frame update
    private void Start()
    {
        coll = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        //Reset moveDelta
        moveDelta = new Vector3(x, y, 0);

        //Swap sprite direction 
        if(moveDelta.x > 0)
        {
            transform.localScale = Vector3.one;
        
        } else if(moveDelta.x < 0)
        {
            transform.localScale = new Vector3(-1,1,1);
        }

        //Move
        transform.Translate(moveDelta * Time.deltaTime);
    }
}
