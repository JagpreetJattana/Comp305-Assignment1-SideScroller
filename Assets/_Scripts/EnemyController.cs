using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    //private instance variable
    private Transform _transform;
    public Vector2 _currentPosition;
    private float _horizontalSpeed;
    private float _verticalSpeed;

    //public instance varibales
    public float minHSpeed = 5f;
    public float maxHSpeed = 10f;
    public float minVSpeed=-2;
    public float maxVSpeed = 2;
    public EnemyCollisionController enemyCollider;

    public float VerticalSpeed
    {
        get
        {
            return _verticalSpeed;
        }

        set
        {
            _verticalSpeed = value;
           
        }
    }

    public float HorizontalSpeed
    {
        get
        {
            return _horizontalSpeed;
        }

        set
        {
            _horizontalSpeed = value;

        }
    }

 

    // Use this for initialization
    void Start()
    {
        //Make a reference with the Transform Component
        this._transform = gameObject.GetComponent<Transform>();
        this.Reset();
    }

    // Update is called once per frame
    void Update()
    {
        this._currentPosition = this._transform.position;
        if (this.enemyCollider.motion == 1) {
            this._currentPosition -= new Vector2(this._horizontalSpeed, this._verticalSpeed);
         
        }
        else {
            this._currentPosition += new Vector2(0, this._verticalSpeed);
            this._currentPosition -= new Vector2(this._horizontalSpeed,0);
            

        }
        
        this._transform.position = this._currentPosition;

        if (this._currentPosition.x <= -440f)
        {
            //reset the fireball
            this.Reset();
        }

    }

    //public methods

        //method to reset the fireball
    public void Reset()
    {
        this._horizontalSpeed = Random.Range(this.minHSpeed, this.maxHSpeed);
        this._verticalSpeed = Random.Range(this.minVSpeed,this.maxVSpeed);
        float xPosition = Random.Range(-150f, 150f);
        this._transform.position = new Vector2(430f, xPosition);
    }
}
