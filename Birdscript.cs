using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdscript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flappower;
    public Logicscript logic;
    public bool birdalive =true;
    public AudioSource gameoverSFX;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdalive==true)
        {
            myRigidbody.velocity = Vector2.up * 10;
        }

        if (transform.position.y < -17 || transform.position.y > 17)
        {
            logic.gameover();
            gameoverSFX.Play();
            birdalive= false;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameover();
        gameoverSFX.Play();
        birdalive = false;
    }
}
