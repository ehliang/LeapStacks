using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

public class closebutton : MonoBehaviour {

	public GameObject menu;
	public GameObject text;

	void Update()
	{
		if (Input.GetMouseButtonDown (0)) {
			menu.SetActive (false);
			text.SetActive (false);
		}
	}

}