using UnityEngine;
using System.Collections;

public class testiTween : MonoBehaviour {

	public GameObject goAnemy;
	// Use this for initialization
	void Start () {
		Vector3 desPos = goAnemy.transform.position;
		desPos.x += 2f;
		iTween.MoveTo(goAnemy, desPos, 0.5f);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
