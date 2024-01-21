using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class player : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButton(0))
        {
            Vector2 touchpos = Camera.main.ScreenToWorldPoint( Input.mousePosition);
            if(touchpos.x < 0)
            {
                rb.AddForce(Vector2.left * speed);
                transform.localScale = new Vector3(-0.25f, 0.25f, 0.25f);
            }
            else
            {
                rb.AddForce(Vector2.right * speed);
                transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
            }
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "spike")
        {
            SceneManager.LoadScene("Game");
        }
    }
}
