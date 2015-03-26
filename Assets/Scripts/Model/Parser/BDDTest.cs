using UnityEngine;
using System.Collections;
using Mono.Data.Sqlite;
using System.Data; 
using System;

public class BDDTest : MonoBehaviour {

	void Start () {
	string conn = "URI=file:" + Application.dataPath + "/test.s3db"; //Path to database.
	IDbConnection dbconn;
	dbconn = (IDbConnection) new SqliteConnection(conn);
	dbconn.Open(); //Open connection to the database.
	IDbCommand dbcmd = dbconn.CreateCommand();
	
	
		Debug.Log(conn );
	
	
	string sqlQuery = "SELECT * FROM Combatant WHERE Force >= 100 ";
	dbcmd.CommandText = sqlQuery;
	IDataReader reader = dbcmd.ExecuteReader();
	
	
	while (reader.Read())
	{
		float value = reader.GetFloat(2);
		string name = reader.GetString(0);
		float rand = reader.GetFloat(1);
		
			Debug.Log( "Vitalite= "+value+"  Nom ="+name+"  Force ="+  rand);
	}
	
	reader.Close();
	reader = null;
	dbcmd.Dispose();
	dbcmd = null;
	dbconn.Close();
	dbconn = null;

	}
}