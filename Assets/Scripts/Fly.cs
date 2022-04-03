using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public float velocity = 1;
    public GameManager gm;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        

        if(Input.GetMouseButtonDown(0))
        {
            if (gm.mouse == 0) {

                gm.titleCanvas.SetActive(false);
                Time.timeScale = 1;

            }


            gm.mouse++;
            rb.velocity = Vector2.up * velocity;
        }


        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gm.GameOver();
    }
}
