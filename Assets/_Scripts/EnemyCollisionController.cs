using UnityEngine;
using System.Collections;

public class EnemyCollisionController : MonoBehaviour {

    //private instance valiable
    private int _motion=1;

    //public instance variables
    public EnemyController enemyController;

    //getter and setter
    public int motion
    {
        get
        {
            return _motion;
        }

        set
        {
            _motion = value;

        }
    }
    // Use this for initialization
    void Start()
    {
        //initialize the audio source array
        this.enemyController = gameObject.GetComponent<EnemyController>();
      
    }

    // Update is called once per frame
    void Update()
    {

    }

    //public methods

    //used ontrigger method to detect collisions between objects
    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("FireBall"))
        {
                         
          //  Debug.Log("self collision");
            this._motion = this._motion * (-1);

        }
      

    }
}
