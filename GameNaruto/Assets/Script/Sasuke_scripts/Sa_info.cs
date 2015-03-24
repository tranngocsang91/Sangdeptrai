using UnityEngine;
using System.Collections;

public static class Sa_info : object {

	public static bool isRight = true;
	public static bool isDie = false;
	public static bool isRun = false;
	public static bool isSkill = false;
	public static bool isDeathSkill = true;
	public static int curKiem = 0; //0: kiem thuong; 1: kiem lua; 2: kiem dien

	//for Death
	public static bool isDeath = false;
	public static GameObject go_death;
	public static int curSelectedDeath = 0; //0: Death 1; 1: Death 2; 2: Death 3
	public static bool isDeathRun = false;

	//for Fire
	public static int curSelectedFire = 2; //0-1: lua thuong; 

	//for Fire
	public static int curSelectedRongSamSet = 2; //0-1: lua thuong; 

	//thay doi tinh trang huong left right
	public static void info_changeIsRight()
	{
		if(Sa_info.isRight)
		{
			Sa_info.isRight = false;
		}
		else
		{
			Sa_info.isRight = true;
		}
	}
}
