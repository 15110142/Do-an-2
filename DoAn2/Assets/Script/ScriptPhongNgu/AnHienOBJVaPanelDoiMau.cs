using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnHienOBJVaPanelDoiMau : MonoBehaviour {

    public GameObject Obj;
    public GameObject panel;
    int n = 1;
    private void Start()
    {
        Obj.gameObject.SetActive(false);
        panel.gameObject.SetActive(false);
    }

    public void AnHienObjVaPanel()
    {
        n++;
        if (n % 2 == 1)
        {
            Obj.gameObject.SetActive(false);
            panel.gameObject.SetActive(false);
        }
        else
            Obj.gameObject.SetActive(true);
            panel.gameObject.SetActive(true);
    }
}
