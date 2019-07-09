using System.Collections;
//using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class RenderersAndColors : MonoBehaviour
{
	//
    MeshRenderer[] mesh_renderers; SpriteRenderer[] sprt_renderers; Image[] img_renderers; RawImage[] Rimg_renderers; Text[] txt_renderers;
	bool init; int renderers_num;
	Color[] init_colors, colors;
	//
	void Awake(){initRenderers();}
	//
	public void initRenderers(){
		mesh_renderers = GetComponentsInChildren<MeshRenderer>();
		sprt_renderers = GetComponentsInChildren<SpriteRenderer>();
		img_renderers = GetComponentsInChildren<Image>();
		Rimg_renderers = GetComponentsInChildren<RawImage>();
		txt_renderers = GetComponentsInChildren<Text>();
		renderers_num = mesh_renderers.Length + sprt_renderers.Length + img_renderers.Length + Rimg_renderers.Length + txt_renderers.Length;
		init_colors = getColors();
		init = true;
	}
	//
	public void lerpColor(Color col1 = default(Color), Color col2 = default(Color), float time = 1f){
		if(!init) initRenderers();
		int i = 0;
		foreach (MeshRenderer msh_r in mesh_renderers) {msh_r.materials[0].color = calcColor(i, col1, col2, time); i++;}
		foreach (SpriteRenderer spr_r in sprt_renderers) {spr_r.color = calcColor(i, col1, col2, time); i++; }
		foreach (Image img_r in img_renderers) {img_r.color = calcColor(i, col1, col2, time); i++; }
		foreach (RawImage Rimg_r in Rimg_renderers) {Rimg_r.color = calcColor(i, col1, col2, time); i++; }
		foreach (Text txt_r in txt_renderers) {txt_r.color = calcColor(i, col1, col2, time); i++; }
	}
	//
	Color calcColor(int i, Color col1, Color col2, float time){
		float r1, g1, b1, a1, r2, g2, b2, a2;
		r1 = col1.r < 0f || col1.r > 1f ? init_colors[i].r : col1.r;
		g1 = col1.g < 0f || col1.g > 1f ? init_colors[i].g : col1.g;
		b1 = col1.b < 0f || col1.b > 1f ? init_colors[i].b : col1.b;
		a1 = col1.a < 0f || col1.a > 1f ? init_colors[i].a : col1.a;
		r2 = col2.r < 0f || col2.r > 1f ? init_colors[i].r : col2.r;
		g2 = col2.g < 0f || col2.g > 1f ? init_colors[i].g : col2.g;
		b2 = col2.b < 0f || col2.b > 1f ? init_colors[i].b : col2.b;
		a2 = col2.a < 0f || col2.a > 1f ? init_colors[i].a : col2.a;
		return Color.Lerp(new Color(r1, g1, b1, a1), new Color(r2, g2, b2, a2), time);
	}
	//
	public Color[] getColors(){
		Color[] cols = new Color[renderers_num];
		int i = 0;
		foreach (MeshRenderer msh_r in mesh_renderers) {cols[i] = msh_r.material.color; i++; }
		foreach (SpriteRenderer spr_r in sprt_renderers) {cols[i] = spr_r.color; i++; }
		foreach (Image img_r in img_renderers) {cols[i] = img_r.color; i++; }
		foreach (RawImage Rimg_r in Rimg_renderers) {cols[i] = Rimg_r.color; i++; }
		foreach (Text txt_r in txt_renderers) {cols[i] = txt_r.color; i++; }
		return cols;
	}
	//
}
