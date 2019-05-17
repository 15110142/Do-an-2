using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xoayObj : MonoBehaviour {

    public GameObject obj;
	public void Xoay()
    {
        obj.transform.Rotate(0, 45, 0);
    }
}
