using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float verticalInput = Input.GetAxis("Vertical");
        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);
        
        if (transform.position.y > 3.88f)
        {
            transform.position =  new Vector2(transform.position.x,3.88f);
        }
        else if(transform.position.y < -3.88f)
        {
            transform.position = new Vector2(transform.position.x, -3.88f);
        }




    }
}
