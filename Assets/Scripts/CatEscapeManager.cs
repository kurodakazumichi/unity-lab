using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatEscapeManager : MonoBehaviour {

    GameObject hpGauge;

	// Use this for initialization
	void Start () {
        this.hpGauge = GameObject.Find("hpGauge");
	}
	
	// Update is called once per frame
	public void DecreseHp () {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
	}
}
