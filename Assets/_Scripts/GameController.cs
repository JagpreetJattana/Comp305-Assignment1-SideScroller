using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    //private instance variables
    private int _scoreValue;         
    private int _livesValue;
    
     


    // Public instance varaibles
    public int cloudNumber=3;
    public EnemyController cloud;
    public Text livesLabel;
    public Text scoreLabel;



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
            this.livesLabel.text = "Lives: " + this._livesValue;
        }
    }
    // Use this for initialization
    void Start () {
        this._initialize();
        this.ScoreValue = 0;
            this.LivesValue = 5;
	
	}
	
    // Update is called once per frame
	void Update () {
	
	}

    //private  methods
    private void _initialize() {
        for (int cloudCount = 0; cloudCount < this.cloudNumber; cloudCount++) {
            Instantiate(cloud.gameObject);
        }

    }
}
