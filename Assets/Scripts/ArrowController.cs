using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour {

    GameObject player;

	// Use this for initialization
	void Start () {

        this.player = GameObject.Find("player");
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(0, -0.1f, 0);

        if (transform.position.y < -5.0f) {
            Destroy(this.gameObject);
        }

        Vector2 dir = this.transform.position - player.transform.position;
        if(dir.magnitude < 1.5f) {
            GameObject manager = GameObject.Find("Manager");
            manager.GetComponent<CatEscapeManager>().DecreseHp();
            Destroy(this.gameObject);
        }
	}
}
