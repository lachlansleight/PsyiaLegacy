using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveCubemap : MonoBehaviour {

	public Camera CubemapCamera;
	public string TargetDirectory = "C:/Users/Lachlan/Desktop/Cubemap/";
	public string ViveButton = "Grip";
	public int Size = 4096;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(
			VRTools.VRInput.GetDevice("ViveRight").GetButtonDown(ViveButton) ||
			VRTools.VRInput.GetDevice("ViveLeft").GetButtonDown(ViveButton) ||
			Input.GetKeyDown(KeyCode.F12)
		) {
			Save();
		}
	}

	public void Save()
	{
		Debug.Log("Saving cubemap to " + TargetDirectory);
		CubemapCamera.transform.position = VRTools.VRInput.GetDevice("ViveHMD").position;

		Cubemap NewCubemap = new Cubemap(Size, TextureFormat.ARGB32, false);
		NewCubemap.name = CubemapCamera.gameObject.name + System.DateTime.Now.Ticks.ToString();
		CubemapCamera.RenderToCubemap(NewCubemap);
		var tex = new Texture2D (NewCubemap.width, NewCubemap.height, TextureFormat.RGB24, false);
		CubemapFace[] faces = new CubemapFace[] {
			CubemapFace.PositiveX, CubemapFace.NegativeX,
			CubemapFace.PositiveY, CubemapFace.NegativeY,
			CubemapFace.PositiveZ, CubemapFace.NegativeZ };
		
		foreach (CubemapFace face in faces) {
			tex.SetPixels(NewCubemap.GetPixels(face));        
			Directory.CreateDirectory(TargetDirectory + NewCubemap.name + "/");
			File.WriteAllBytes(TargetDirectory + NewCubemap.name + "/" + face.ToString() + ".png",
			tex.EncodeToPNG());
		}   
	}
}
