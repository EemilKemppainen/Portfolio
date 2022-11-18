using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shot : MonoBehaviour
{

    public Text text;

    public int streak = 0;

    public Collider goal;

    

    public Rigidbody rb;

    float x;
    float y;
    float z;

    public GameObject player;

    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {

        x = transform.position.x;

        y = transform.position.y;

        z = transform.position.z;

    }

    // Update is called once per frame
    void Update()
    {

        text.text = "Streak: " + streak;



        if (Input.GetKeyDown(KeyCode.Space))
        {



            rb.velocity = new Vector3(0, 6, 6);

            

        }

        if (transform.position.y < -10)
        {

            transform.position = player.transform.position;

            rb.velocity = new Vector3(0, 0, 0);

            rb.angularVelocity = Vector3.zero;

            //Destroy(gameObject);

            //Instantiate(ball, player.transform.position, player.transform.rotation);

            streak = 0;

        }

    }

    


    private void OnTriggerEnter(Collider other)
    {

        

    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider == goal)
        {

            transform.position = player.transform.position;

            rb.velocity = new Vector3(0, 0, 0);

            rb.angularVelocity = Vector3.zero;

            streak++;



            Move.instance.ChangeSpeed();

        }

    }




}
