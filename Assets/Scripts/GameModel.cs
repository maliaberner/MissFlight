using UnityEngine;
using System.Collections;

// we need these namespaces for serialization
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.SceneManagement;


public class GameModel : MonoBehaviour {
	

	public Scene currentLevel;

	public string saveFileName;


	public void OnSaveClick()
	{
		SaveGame saveGame = new SaveGame ();
		SaveGameModel(saveGame, saveFileName);
	}

	public void OnLoadClick()
	{
		LoadGame (saveFileName);
	}


	public void SaveGameModel(SaveGame save, string filename)
	{
		BinaryFormatter bf = new BinaryFormatter();
		// then create a file stream that can be opened or created, with write access to it
		FileStream fs = File.OpenWrite(Application.persistentDataPath + "/" + filename + ".dat");

		// note that we store the data from our game model (this object)
		// first in the SaveGame instance, think of SaveGame like a file
		save.StoreData(this.GetComponent<PlayerMovement>());

		// then we can serialize it to the disk using Serialize and
		// we serialize the SaveGame object. 
		bf.Serialize(fs, save);

		// close the file stream
		fs.Close ();
	}

	public void LoadGame(string filename)
	{
		BinaryFormatter bf = new BinaryFormatter();
		FileStream fs = File.OpenRead(Application.persistentDataPath + "/" + filename + ".dat");

		// deserialize the save game--this will throw an exception if we can't
		// deserialize from the file stream
		SaveGame saveGame = (SaveGame)bf.Deserialize(fs);

		// we assume we have access to the game model
		saveGame.LoadData(this.GetComponent<PlayerMovement>());

		// close the file stream
		fs.Close ();
	}
}

