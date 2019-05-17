using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Loguot : MonoBehaviour {

    public void Loguot1()
    {
        SceneManager.LoadScene("Login");
    }
    public void changpass()
    {
        SceneManager.LoadScene("Doimatkhau");
    }
}
