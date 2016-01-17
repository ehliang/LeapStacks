using UnityEngine;
using System.Collections;

public class Delta : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		Texture myTexture = Resources.Load("some_texture") as Texture;    
		transform.gameObject.GetComponent<Renderer>().material.mainTexture = myTexture;        
		GetComponent<Renderer>().material.mainTextureScale = new Vector2(transform.lossyScale.x*0.5f,transform.lossyScale.x*0.5f);
	}
	
	// Update is called once per frame


	void Update () {
	
	}
}

