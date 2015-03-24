using UnityEngine;
using System.Collections;

public class StartDeath : MonoBehaviour {

	public GameObject prefab_Death1;
	public GameObject prefab_Death2;
	public GameObject prefab_Death3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void creatDeath()
	{
		if(Sa_info.isDie) return;
		if(!Sa_info.isDeath) return;
		GameObject go1 = new GameObject();
		switch(Sa_info.curSelectedDeath)
		{
			case 0:
			{
				go1 = Instantiate(prefab_Death1, transform.parent.position + new Vector3(0f, 0.2f, -0.5f), Quaternion.identity) as GameObject;
				break;
			}
			case 1:
			{
				go1 = Instantiate(prefab_Death2, transform.parent.position + new Vector3(0f, 0.2f, -0.5f), Quaternion.identity) as GameObject;
				break;
			}
			case 2:
			{
				go1 = Instantiate(prefab_Death3, transform.parent.position + new Vector3(0f, 0.2f, -0.5f), Quaternion.identity) as GameObject;
				break;
			}
		}
		//rescale follow isRight
		Vector3 scaleTemp;
		scaleTemp = go1.transform.localScale;
		if(Sa_info.isRight)
		{
			scaleTemp.x = Mathf.Abs(scaleTemp.x);
		}
		else
		{
			scaleTemp.x = -Mathf.Abs(scaleTemp.x);
		}
		go1.transform.localScale = scaleTemp;
		//set parent
		go1.transform.parent = transform.parent;
		Sa_info.go_death = go1;
	}

	public void destroyGO()
	{
		Destroy(gameObject);
	}
}
