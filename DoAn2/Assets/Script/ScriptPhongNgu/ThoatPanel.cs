using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThoatPanel : MonoBehaviour {

    public GameObject thoat;
	void Start () {
       
    }
	
	// Update is called once per frame
	public void thoatPanel () {
        thoat.gameObject.SetActive(false);
    }
}
