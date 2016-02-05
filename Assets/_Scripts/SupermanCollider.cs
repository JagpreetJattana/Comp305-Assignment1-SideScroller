using UnityEngine;
using System.Collections;

public class SupermanCollider : MonoBehaviour {
    //private instance variables
    private AudioSource[] _audioSources;
    private AudioSource _ringSound;
    private AudioSource _fireballSound;
    private AudioSource _heartSound;

    //public instance variables
    public GameController gameController;

	// Use this for initialization
	void Start () {
        //initialize the audio source array
        this._audioSources = gameObject.GetComponents<AudioSource>();
        this._fireballSound = this._audioSources[1];
        this._ringSound = this._audioSources[2];
        this._heartSound = this._audioSources[3];
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    //public methods

    //used ontrigger method to detect collisions between objects
    public void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.gameObject.CompareTag("Ring")) {
            this._ringSound.Play();
            this.gameController.ScoreValue+= 100;
        }
        if (other.gameObject.CompareTag("FireBall"))
        {
           
            this._fireballSound.Play();
            this.gameController.LivesValue -= 1;
        }

        if (other.gameObject.CompareTag("Heart"))
        {

            this._heartSound.Play();
            this.gameController.LivesValue += 1;
        }

    }
}
