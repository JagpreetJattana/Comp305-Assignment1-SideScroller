using UnityEngine;
using System.Collections;

public class RingController : MonoBehaviour {
    //private instance variable
    private Transform _transform;
    private Vector2 _currentPosition;

    //public instance varibales
    public float speed = 5;

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
        this._currentPosition -= new Vector2(this.speed,0);
        this._transform.position = this._currentPosition;

        if (this._currentPosition.x <= -320f)
        {
            //reset the iland
            this.Reset();
        }

    }

    public void Reset()
    {
        float xPosition = Random.Range(-240f, 240f);
        this._transform.position = new Vector2(360f,xPosition);
    }
}


