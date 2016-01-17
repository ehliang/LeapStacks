using UnityEngine;
using System.Collections;

public class Makeitrain : MonoBehaviour {


	void Start() {
	}
	void Update(){
	}
	void OnGUI()
	{
		float choice = Random.Range (1, 6); 
		int obtype = Random.Range (0, 2); 
		float totalrand = Random.Range (0, 8) * 0.3F; 
		float totalrand2 = Random.Range (0, 3) * 0.3F; 
		float totalrand3 = Random.Range (0, 8) * 0.3F; 
		PrimitiveType[] shapes = new PrimitiveType[2] { PrimitiveType.Cube, PrimitiveType.Cylinder};
		Event e = Event.current;
		Material newMat = Resources.Load(choice.ToString(), typeof(Material)) as Material;
		if (e.isKey && e.keyCode == KeyCode.N) {
			GameObject cube = GameObject.CreatePrimitive (shapes[obtype]);
			cube.transform.localScale += new Vector3 (totalrand, totalrand2,totalrand3); 
			cube.transform.position = new Vector3 (choice, 2, 0);
			cube.GetComponent<Renderer> ().material = newMat;
			Rigidbody gameObjectsRigidBody = cube.AddComponent<Rigidbody> (); // Add the rigidbody.
			gameObjectsRigidBody.mass = 50;
			gameObjectsRigidBody.useGravity = true; 
			gameObjectsRigidBody.drag = 3; 
			gameObjectsRigidBody.constraints =RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ; 
		}
	}
}