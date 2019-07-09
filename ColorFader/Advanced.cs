using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Advanced  {
		//
		// *** values out of range (0<->1), means that will used init render.color values  ***
		//
		public static void FadeIn(this GameObject go,float time = 1f, float delay = 0f){ 
			if(go.GetComponent<ColorChanger>() == null) go.AddComponent<ColorChanger>().changeColor(new Color(2f,2f,2f,0f), new Color(2f,2f,2f,2f), time, delay);
			else go.GetComponent<ColorChanger>().changeColor(new Color(2f,2f,2f,0f), new Color(2f,2f,2f,2f), time, delay);
		}
		//
		public static void FadeOut(this GameObject go,float time = 1f, float delay = 0f){ 
			if(go.GetComponent<ColorChanger>() == null) go.AddComponent<ColorChanger>().changeColor(new Color(2f,2f,2f,2f), new Color(2f,2f,2f,0f), time, delay);
			else go.GetComponent<ColorChanger>().changeColor(new Color(2f,2f,2f,2f), new Color(2f,2f,2f,0f), time, delay);
		}
		//
		public static void FadeColor(this GameObject go, Color col1 = default(Color), Color col2 = default(Color), float time = 1f, float delay = 0f){ 
			if(go.GetComponent<ColorChanger>() == null) go.AddComponent<ColorChanger>().changeColor(col1, col2, time, delay);
			else go.GetComponent<ColorChanger>().changeColor(col1, col2, time, delay);
		}
		//
}