using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.SceneManagement;
public class doimatkhau : MonoBehaviour {

    public InputField inputUser;
    public InputField inputPass;
    public InputField inputPassNew;
    string user, pass,newpass;
    public Text text;
    public void doimatkhau1()
    {
        user = inputUser.text.ToString();
        pass = inputPass.text.ToString();
        newpass = inputPassNew.text.ToString();
        string conn = "URI=file:" + Application.dataPath + "/Plugin/Noithat1.s3db"; //Path to database.
        IDbConnection dbconn;
        dbconn = (IDbConnection)new SqliteConnection(conn);
        dbconn.Open(); //Open connection to the database.
        IDbCommand dbcmd = dbconn.CreateCommand();
        string sqlQuery = "SELECT * " + "FROM TaiKhoan";// table name
        dbcmd.CommandText = sqlQuery;
        //IDataReader reader = dbcmd.ExecuteReader();
        //while (reader.Read())
        //{
        //    string UserName = reader.GetString(1);
        //    string PassWord = reader.GetString(2);
            

        //    if (user == UserName && pass == PassWord)
        //    {
                dbcmd.CommandText = "UPDATE TaiKhoan SET(PassWord) ='"+newpass+"' WHERE UserName='"+user+"'and PassWord='"+pass+"'";
                dbcmd.ExecuteNonQuery();
                //reader.Close();
                text.text = "Sign successfully";
        //        break;
        //    }
        //    else
        //    {
        //        text.text = "Username or password wrong";
        //    }
        //}
        //reader.Close();
        //reader = null;
       // dbcmd.Dispose();
       // dbcmd = null;
        dbconn.Close();
        dbconn = null;
        
    
    }
}
