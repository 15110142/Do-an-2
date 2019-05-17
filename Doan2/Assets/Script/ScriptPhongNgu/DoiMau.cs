using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoiMau : MonoBehaviour {

    public GameObject cube;

    void Start()
    {
    }
    public void changcolor(Material mm)
    {
        cube.GetComponent<Renderer>().material = mm;

    }
}
