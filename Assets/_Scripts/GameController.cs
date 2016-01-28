using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    // Public instance varaible
    public int cloudNumber=3;
    public EnemyController cloud;


	// Use this for initialization
	void Start () {
        this._initialize();
	
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
