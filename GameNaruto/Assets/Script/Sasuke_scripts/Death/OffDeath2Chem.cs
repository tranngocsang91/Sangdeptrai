using UnityEngine;
using System.Collections;

public class OffDeath2Chem : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy(gameObject, 0.55f);
	}

	public void OffChem()
	{
		Destroy(gameObject);
	}
}
