using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FixZcharaters : MonoBehaviour {

	public static FixZcharaters instance;
	public Transform transSasukeChild;
	private List<Transform> listTransChild;
	private int length;
	private Transform transTemp;
	private float minY;
	private int minI;
	private Vector3 tempPos;
	private float startZ = 1f;
	private float stepZ = 2f;
	private bool hasChange = false;
	// Use this for initialization
	void Start () {
		instance = this;
		listTransChild = new List<Transform>();
		AddNewZchar(transSasukeChild);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void LateUpdate()
	{
		fixNull();
		updateZ();
	}

	public void AddNewZchar(Transform transChild)
	{
		listTransChild.Add(transChild);
		tempPos = transChild.parent.position;
		tempPos.z = (listTransChild.Count-1)*stepZ + startZ;
		transChild.parent.position = tempPos;
		if(listTransChild.Count >= 30) Debug.Log("============= Vuot wa 30 character roi ========");
	}
	 
	private void fixNull()
	{
		hasChange = false;
		//Debug.Log("dau co "+length);
		length = listTransChild.Count;
		for(int i = 0; i < length; i++)
		{
			if(listTransChild[i] == null)
			{
				hasChange = true;
				listTransChild.RemoveAt(i);
				length = listTransChild.Count;
				i--;
//				//lui z phia tren, can toi uu ham nay
//				for(int j = i; j < length; j++)
//				{
//					charListChild[j].parent.position += new Vector3(0f, 0f, -stepZ);
//				}
			}
		}
		//Debug.Log("cuoi co "+length);
	}

	private void updateZ()
	{
		length = listTransChild.Count;
		for(int i = 0; i < length; i++)
		{
			minY = listTransChild[i].position.y;
			minI = i;
			for(int j = i+1; j < length; j++)
			{
				if(minY > listTransChild[j].position.y) 
				{
					minY = listTransChild[j].position.y;
					minI = j;
				}
			}
			if(minI != i) 
			{
				hasChange = true;
				transTemp = listTransChild[i];
				listTransChild[i] = listTransChild[minI];
				listTransChild[minI] = transTemp;
			}

		}

		//chinh lai z cua charListChild[]
		if(hasChange)
		{
			for(int i = 0; i < length; i++)
			{
				tempPos = listTransChild[i].parent.position;
				tempPos.z = i*stepZ + startZ;
				listTransChild[i].parent.position = tempPos;
			}
		}
	}
}
