using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class test : MonoBehaviour
{


    Rigidbody2D rb;
    public GameObject WinText;
    float xInput;
    public float skokWysokosc;


    int skok = 0;


    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        
    }

    // Update is called once per frame
    void Update()
    {

        xInput = Input.GetAxisRaw("Horizontal");


        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (skok < 2)
            {
                skok++;
                rb.AddForce(Vector2.up * speed * skokWysokosc);
            }

        }

        if (Input.GetKeyDown(KeyCode.D)){
            

        }

        transform.position += new Vector3(xInput, 0) * Time.deltaTime * speed;

        









        if (Input.GetKeyDown(KeyCode.R)){

            SceneManager.LoadScene("Level2");
        }

        



        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.tag == "gruond")
        {
            WinText.SetActive(true);
            skok = 0;
        }

    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
