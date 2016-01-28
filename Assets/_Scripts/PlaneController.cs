using UnityEngine;
using System.Collections;

public class PlaneController : MonoBehaviour {
    //private instance variables
    private float _playerInput;
    private Transform _transform;
    private Vector2 _currentPosition;

    //public instance varibales
    public float speed = 5;

    // Use this for initialization
    void Start () {
        this._transform = gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        this._currentPosition = this._transform.position;

        this._playerInput = Input.GetAxis("Vertical");
        //this will cause the plne to move to right because input is positive
        if (this._playerInput > 0)
        {
            //to check bounds i.e to keep the plane in scene
            if (this._currentPosition.y < 220)
                this._currentPosition += new Vector2(0, this.speed);
            

        }
        //this will cause the plne to move to left because input is negative
        if (this._playerInput < 0)
        {
            //to check bounds i.e to keep the plane in scene
            if (this._currentPosition.y > -220)
            this._currentPosition -= new Vector2(0, this.speed);
            
        }
        this._transform.position = this._currentPosition;
    }

    //private methos for checkbounds
    private void CheckBounds() {

    }
  
}
