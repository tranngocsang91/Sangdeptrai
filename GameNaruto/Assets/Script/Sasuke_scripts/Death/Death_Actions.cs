using UnityEngine;
using System.Collections;

public class Death_Actions : MonoBehaviour {

	Animator aniTor;
	// Use this for initialization
	void Start () {
		if(!Sa_info.isDeath) Destroy(gameObject);
		aniTor = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Chem()
	{
		if(Sa_info.isDeathSkill) return;
		aniTor.Play("Death_1_Chem_Right");
		/* khong hieu so ko thay doi ten cua controller duoc
		switch(Sa_info.curSelectedDeath)
		{
		case 0:
		{
			aniTor.Play("Death_1_Chem_Right");
			break;
		}
		case 1:
		{
			aniTor.Play("Death_2_Chem_Right");
			break;
		}
		case 2:
		{
			aniTor.Play("Death_3_Chem_Right");
			break;
		}
		}
		*/
	}

	public void Run()
	{
		aniTor.SetInteger("chuyen", 1);
	}

	public void StopRun()
	{
		aniTor.SetInteger("chuyen", 0);
	}

	public void destroyGO()
	{
		Destroy(gameObject);
	}
	
	//bat dau cua idle state, thiet lap san sang cho skill moi
	public void setDeathStateReadyForSkill()
	{
		Sa_info.isDeathSkill = false;
	}
	//bat dau moi skill, thiet lap la dang choi skill, ko cho skill khac choi
	public void setDeathStateProducingSkill()
	{
		Sa_info.isDeathSkill = true;
	}
}
