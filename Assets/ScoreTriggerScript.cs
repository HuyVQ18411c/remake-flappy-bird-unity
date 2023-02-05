using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTriggerScript : MonoBehaviour
{
    public ScoreScript scoreLogic;
    // Start is called before the first frame update
    void Start()
    {
        this.scoreLogic = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            this.scoreLogic.addScore(5);
        }
    }
}
