using UnityEngine;
using System.Collections;

public class LoadLevel1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("MoveScenes",5f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void MoveScenes()
	{
		Application.LoadLevel("Star2");
	}
}
