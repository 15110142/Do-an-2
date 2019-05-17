using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.SceneManagement;
public class Login : MonoBehaviour {

    public InputField inputUser;
    public InputField inputPass;
    string user, pass;
    public Text text;
    public void Login1()
    {
        user = inputUser.text.ToString();
        pass = inputPass.text.ToString();
        string conn = "URI=file:" + Application.dataPath + "/Plugin/Noithat1.s3db"; //Path to database.
        IDbConnection dbconn;
        dbconn = (IDbConnection)new SqliteConnection(conn);
        dbconn.Open(); //Open connection to the database.
        IDbCommand dbcmd = dbconn.CreateCommand();
        dbcmd.CommandText = "SELECT * " + "FROM TaiKhoan";
        //string sqlQuery = "SELECT * " + "FROM TaiKhoan";// table name
        //dbcmd.CommandText = sqlQuery;
        IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            string UserName = reader.GetString(1);
            string PassWord = reader.GetString(2);        

            if (user == UserName && pass == PassWord)
            {
                text.text = "Login successfully";
                SceneManager.LoadScene("ChonDiaDiem");
                break;
            }
            else
            {
                text.text = "Username or password wrong";
            }
        }
        reader.Close();
        reader = null;
       // dbcmd.Dispose();
        //dbcmd = null;
        dbconn.Close();
        dbconn = null;
    }
}
