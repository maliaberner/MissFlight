using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System;
using System.Runtime.Serialization;


[Serializable]
public class SaveGame : MonoBehaviour {
	
	public Scene currentLevel;




	public void StoreData(PlayerMovement model)
	{
		currentLevel = model.currentScene;
	}

	public void LoadData(PlayerMovement model)
	{
		model.currentScene = currentLevel;
	}

	// this method is called when your object is serialized--this helps deal with some of the
	// issues around unity objects that aren't flagged as serializable
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue ("level", currentLevel);
	}

	// we use the empty constructor when creating a save game before writing it to the disk
	public SaveGame()
	{
	}

	// this is a special constructor needed by ISerializable so that we can
	// construct the object from a stream--here we must fill out all the values
	// we saved to the file
	public SaveGame(SerializationInfo info, StreamingContext context)
	{
		currentLevel = (Scene)info.GetValue ("level", currentLevel.GetType());
	}

}
