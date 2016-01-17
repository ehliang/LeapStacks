using UnityEngine;
using System.Collections;

public class CubeGenerate : MonoBehaviour {
	Material newMat = Resources.Load("New Material", typeof(Material)) as Material;

		
	void Start() {
		GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube.transform.position = new Vector3(0, 2, 0);
		cube.GetComponent<Renderer>().material = newMat;
		Rigidbody gameObjectsRigidBody = cube.AddComponent<Rigidbody>(); // Add the rigidbody.
		gameObjectsRigidBody.mass = 50;
		gameObjectsRigidBody.useGravity = true; 
		gameObjectsRigidBody.drag = 3; 




		GameObject capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
		capsule.transform.position = new Vector3(2, 1, 0);
		GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder.transform.position = new Vector3(-2, 1, 0);
	}


}