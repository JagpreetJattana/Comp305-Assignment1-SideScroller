using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    //private instance variables
    private int _scoreValue;         
    private int _livesValue;
    [SerializeField]
    private AudioSource _gameOverSound;
    
     


    // Public instance varaibles
    public int fireballNumber=3;
    public EnemyController fireball;
    public Text livesLabel;
    public Text scoreLabel;
    public Text gameOverLabel;
    public SupermanController superman;
    public RingController ring;
    public Text finalScoreLabel;
    public Button restartButton;
   


    public int ScoreValue
    {
        get
        {
            return _scoreValue;
        }

        set
        {
            _scoreValue = value;
            this.scoreLabel.text = "Score: "+this._scoreValue;
        }
    }

    public int LivesValue
    {
        get
        {
            return _livesValue;
        }

        set
        {
            _livesValue = value;
            if (this._livesValue <= 0) {
                this._endGame();
                }
            
            else {
                this.livesLabel.text = "Lives: " + this._livesValue;
            }
            
        }
    }
    // Use this for initialization
    void Start () {
        this._initialize();
       

	
	}
	
    // Update is called once per frame
	void Update () {
	
	}

    //private  methods
    private void _initialize() {
        this.ScoreValue = 0;
        this.LivesValue = 5;
        this.gameOverLabel.enabled = false;
        this.finalScoreLabel.enabled = false;
        this.restartButton.gameObject.SetActive(false);
        for (int ballCount = 0; ballCount < this.fireballNumber; ballCount++) {
            Instantiate(fireball.gameObject);
        }

    }

    private void _endGame() {
        this.finalScoreLabel.text = "Final Score:" + this._scoreValue;
        this.gameOverLabel.enabled = true;
        this.finalScoreLabel.enabled = true;
        this.restartButton.gameObject.SetActive(true);
        this.livesLabel.enabled = false;
        this.scoreLabel.enabled = false;
        this.superman.gameObject.SetActive(false);
        this.ring.gameObject.SetActive(false);
        this._gameOverSound.Play();
      //  this.enemy.gameObject.SetActive(false);

    }

    //public methods

    public void RestarButtonClicked() {
        Application.LoadLevel("Main");
    }
}
