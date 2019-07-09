using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Action : MonoBehaviour
{
	public Color color1, color2;
	public float duration1, delay1, duration2, delay2;
	public bool repeat;
	//
    void Start()
    {
       if(repeat) InvokeRepeating("someAct",0f, duration1 + delay1 + duration2 + delay2);
	   else someAct();
    }
	
	void someAct(){
		gameObject.FadeColor(color1, color2, duration1, delay1);
		gameObject.FadeColor(color2, color1, duration2, delay2);
		//gameObject.FadeIn(1,1);//duration, delay
		//gameObject.FadeOut();// with default values duration = 1, delay = 0
	}
}
