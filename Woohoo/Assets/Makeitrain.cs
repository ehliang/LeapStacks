using UnityEngine;
using System.Collections;
using Leap;

public class Makeitrain : MonoBehaviour {
	bool choose = true;

    Controller controller;

    // Position Vector of the pressable button
    Vector3 buttonPos;

    // Threshold for considering screen taps
    private float epsilon = 1.35F;
    private GameObject button;

    // Use this for initialization
    void Start()
    {
        Debug.Log("Start");
        controller = new Controller();
        if (!controller.IsGestureEnabled(Gesture.GestureType.TYPE_SWIPE))
        {
            Debug.Log("Enabled swipe");
            // controller.EnableGesture(Gesture.GestureType.TYPE_SWIPE);
        }
        if (!controller.IsGestureEnabled(Gesture.GestureType.TYPE_SCREEN_TAP))
        {
            Debug.Log("Enabled screen tap");
            controller.EnableGesture(Gesture.GestureType.TYPE_SCREEN_TAP);
        }

        if (!controller.IsGestureEnabled(Gesture.GestureType.TYPE_KEY_TAP))
        {
            Debug.Log("Enabled key tap");
            controller.EnableGesture(Gesture.GestureType.TYPE_KEY_TAP);
        }

        button = GameObject.Find("Button");
        //button = FindObjectOfType();
        buttonPos = button.transform.position.normalized;
        Debug.Log(System.String.Format("Button pos: {0}", buttonPos.ToString()));
        // buttonPos = new Vector(position.x, position.y, position.z);
    }

    // Update is called once per frame
    void Update()
    {
        Frame frame = controller.Frame();
        GestureList gestures = frame.Gestures();
        foreach (Gesture gesture in gestures)
        {
            if (gesture.Type == Gesture.GestureType.TYPE_SCREEN_TAP)
            {
                ScreenTapGesture screentapGesture = new ScreenTapGesture(gesture);
                processScreenTaps(screentapGesture);
            }
            else if (gesture.Type == Gesture.GestureType.TYPE_KEY_TAP)
            {
                KeyTapGesture keyTapGesture = new KeyTapGesture(gesture);
                processKeyTaps(keyTapGesture);
            }
        }
    }

    void processScreenTaps(ScreenTapGesture gesture)
    {
        Debug.Log(System.String.Format("Screen tap dirn {0}", gesture));
        Vector pos = gesture.Position.Normalized;
        Debug.Log(System.String.Format("Pos: {0}", pos.ToString()));
        float dist = Vector3.Distance(buttonPos, new Vector3(pos.x, pos.y, pos.z));
        Debug.Log(System.String.Format("Distance: {0}", dist));
        if (dist <= epsilon)
        {
            addObject();
        }
    }

    void processKeyTaps(KeyTapGesture gesture)
    {
        Debug.Log(System.String.Format("Key tap dirn {0}", gesture));
        Vector pos = gesture.Position.Normalized;
        Debug.Log(System.String.Format("Pos: {0}", pos.ToString()));
        float dist = Vector3.Distance(buttonPos, new Vector3(pos.x, pos.y, pos.z));
        Debug.Log(System.String.Format("Distance: {0}", dist));
        if (dist <= epsilon + 0.05F)
        {
            addObject();
        }
    }

    void addObject()
    {
        Debug.Log("Adding an object");

        float choice = Random.Range(1, 6);
        int obtype = Random.Range(0, 2);
        float totalrand = Random.Range(0, 8) * 0.3F;
        float totalrand2 = Random.Range(0, 3) * 0.3F;
        float totalrand3 = Random.Range(0, 8) * 0.3F;
        PrimitiveType[] shapes = new PrimitiveType[2] { PrimitiveType.Cube, PrimitiveType.Cylinder };
        Material newMat = Resources.Load(choice.ToString(), typeof(Material)) as Material;

        GameObject cube = GameObject.CreatePrimitive(shapes[obtype]);
        cube.transform.localScale += new Vector3(totalrand, totalrand2, totalrand3);
        cube.transform.position = new Vector3(choice, -2.5F, 0);
        cube.GetComponent<Renderer>().material = newMat;
        Rigidbody gameObjectsRigidBody = cube.AddComponent<Rigidbody>(); // Add the rigidbody.
        gameObjectsRigidBody.mass = 50;
        gameObjectsRigidBody.useGravity = choose;
        gameObjectsRigidBody.drag = 3;
        gameObjectsRigidBody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

    }

    void OnGUI()
    {
        // Debug.Log("Pressing Keys");
        Event e = Event.current;
        if (e.isKey && e.keyCode == KeyCode.G) {
			choose = !choose;
		}
		if (e.isKey && e.keyCode == KeyCode.N) {
            addObject();
        }
	}
}