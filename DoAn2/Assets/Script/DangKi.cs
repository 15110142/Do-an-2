using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.SceneManagement;

public class DangKi : MonoBehaviour {

    public InputField inputUser;
    public InputField inputPass;
    public InputField inputEmail;
    string user, pass,email;
    public Text text;
   public void DangKi1()
    {
        user = inputUser.text.ToString();
        pass = inputPass.text.ToString();
        email = inputEmail.text.ToString();
        string conn = "URI=file:" + Application.dataPath + "/Plugin/Noithat1.s3db"; //Path to database.
        IDbConnection dbconn;
        dbconn = (IDbConnection)new SqliteConnection(conn);
        dbconn.Open(); //Open connection to the database.
        IDbCommand dbcmd = dbconn.CreateCommand();
        string sqlQuery = "INSERT INTO TaiKhoan (UserName,PassWord,Email) VALUES ( '"+ user +"', '" + pass + "', '"+email+"')";// table name
        dbcmd.CommandText = sqlQuery;
        text.text = "Sign Up Success";
        dbcmd.ExecuteNonQuery();
       // dbcmd.Dispose();
        dbcmd = null;
        dbconn.Close();
        dbconn = null;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
