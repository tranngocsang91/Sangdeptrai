using UnityEngine;
using System.Collections;

public class createRongSamSet : MonoBehaviour {

	public GameObject prefab_RongSS1;
	public GameObject prefab_RongSS2;
	public GameObject prefab_VanCong;
	public Transform transCam;	
	public Transform transSasuke;	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ani_disableGO()
	{
		gameObject.SetActive(false);
	}

	public void ani_createRongSamSet()
	{
		if(Sa_info.isDie) return;
		GameObject go1 = new GameObject();
		GameObject goPrefab;
		if(Sa_info.curSelectedRongSamSet <= 1)
		{
			goPrefab = prefab_RongSS1;
		}
		else
		{
			goPrefab = prefab_RongSS2;
		}

		Vector3 posRong;
		posRong = new Vector3(Random.Range(0.2f, 1.1f), Random.Range(-0.2f, 0.25f), 0f);
		go1 = Instantiate(goPrefab, transCam.position + posRong, Quaternion.identity) as GameObject;
		FixZcharaters.instance.AddNewZchar(go1.transform.FindChild("TransChild").transform);

		posRong = new Vector3(Random.Range(0.2f, 1.1f), Random.Range(-0.75f, -0.3f), 0f);
		go1 = Instantiate(goPrefab, transCam.position + posRong, Quaternion.identity) as GameObject;
		FixZcharaters.instance.AddNewZchar(go1.transform.FindChild("TransChild").transform);

		posRong = new Vector3(Random.Range(-1.1f, -0.2f), Random.Range(-0.2f, 0.25f), 0f);
		go1 = Instantiate(goPrefab, transCam.position + posRong, Quaternion.identity) as GameObject;
		FixZcharaters.instance.AddNewZchar(go1.transform.FindChild("TransChild").transform);

		posRong = new Vector3(Random.Range(-1.1f, -0.2f), Random.Range(-0.75f, -0.3f), 0f);
		go1 = Instantiate(goPrefab, transCam.position + posRong, Quaternion.identity) as GameObject;
		FixZcharaters.instance.AddNewZchar(go1.transform.FindChild("TransChild").transform);

		posRong = new Vector3(0f, -0.3f, -0.8f);
		go1 = Instantiate(prefab_VanCong, transSasuke.position + posRong, Quaternion.identity) as GameObject;
		go1.transform.parent = transSasuke;


	}
}
