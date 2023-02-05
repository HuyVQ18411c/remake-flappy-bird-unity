using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    public Rigidbody2D characterRigidBody2D;
    // Start is called before the first frame update
    public float jumpHeight;
    public ScoreScript scoreLogic;
    public bool isGameOver = false;
    void Start()
    {
        this.scoreLogic = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && !isGameOver)
        {
            characterRigidBody2D.velocity = Vector2.up * this.jumpHeight;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        scoreLogic.gameOver();
        this.isGameOver = true;
    }
}
