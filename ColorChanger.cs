using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    //
	public void changeColor(Color col1 = default(Color), Color col2 = default(Color), float time = 1f,float delay = 0f){
		if(time > 0f) StartCoroutine(changeColor_Corr(col1, col2, time, delay));
		else setColor(col2);
	}
	/////
	void setColor(Color col2 = default(Color)){rend_cols.lerpColor(col2,col2,1f);}
	//
	IEnumerator changeColor_Corr(Color col1 = default(Color), Color col2 = default(Color), float time = 1f, float delay = 0f){
		//
		if(delay > 0f) yield return new WaitForSeconds(delay);
		//
		float time_0 = 0f;
		while (time_0 < time){
			//if(!paused){
				time_0 += Time.deltaTime;
				rend_cols.lerpColor(col1, col2, (time_0/time)); 
			//}
			yield return null; 
		}
		//
		setColor(col2);
	}
	//
	RenderersAndColors rend_cols_;
	RenderersAndColors rend_cols { 
		get{ 
			if(gameObject.GetComponent<RenderersAndColors>() == null) rend_cols_ = gameObject.AddComponent<RenderersAndColors>(); 
			return rend_cols_; 
		}
	}
	//
}
