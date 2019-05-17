using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnHienMenu : MonoBehaviour {

    public GameObject Menu;
    int n = 1;
    private void Start()
    {
        Menu.gameObject.SetActive(false);
    }

    public void AnHienMeNu()
    {

        n++;
        if (n % 2 == 1)
        {
            Menu.gameObject.SetActive(false);
        }
        else
            Menu.gameObject.SetActive(true);
    }
}
