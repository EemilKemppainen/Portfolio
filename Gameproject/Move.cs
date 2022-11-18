using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public static Move instance;

    public Rigidbody rb;

    private bool goingRight = true;

    [SerializeField]
    private float speed = 5;

    [SerializeField]
    private GameObject goLeft;

    [SerializeField]
    private GameObject goRight;


    // Start is called before the first frame update
    void Start()
    {

        instance = this;

    }

    // Update is called once per frame
    void Update()
    {

        if (goingRight == true)
        {

            

            transform.Translate(Vector3.right * speed * Time.deltaTime);

        }

        else
        {

           

            transform.Translate(Vector3.left * speed * Time.deltaTime);

        }


        if (transform.position.x >= 7)
        {

            goingRight = false;

           

        }

        if (transform.position.x <= -1.44)
        {

            goingRight = true;

            

        }

    }

    public void ChangeSpeed()
    {

        speed = Random.Range(3, 10);

        

    }



}
