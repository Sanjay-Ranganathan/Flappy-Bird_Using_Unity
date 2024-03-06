using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D myrbd;
    public float flapstr;
    public logicscript logic;
    public bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)==true && birdIsAlive){
            myrbd.velocity = Vector2.up * flapstr;
        }
        else if(Input.GetMouseButtonDown(0)){
            myrbd.velocity = Vector2.up * flapstr;
        }
        Vector3 birdPosition = transform.position;
        float screenBottom=-45;
        if(birdPosition.y < screenBottom){
            logic.gameOver();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision){
        logic.gameOver();
        birdIsAlive = false;
    }
}
