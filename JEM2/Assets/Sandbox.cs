using UnityEngine;
using System.Collections;

public class Sandbox : MonoBehaviour {
    MyCube cube;

	// Use this for initialization
	void Start () {
        Debug.Log("Sandbox started");
        cube = GetComponent<MyCube>();
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Sandbox updated");
	}

    void OnGUI()
    {
        Event e = Event.current;
        if (e.isKey && e.keyCode == KeyCode.N)
        {
            // object new_cube = Instantiate(cube, new Vector3(Random.Range(-10.0F, 10.0F), 0, Random.Range(-10.0F, 10.0F)), Quaternion.identity);
        }
    }
}
