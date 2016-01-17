using UnityEngine;
using System.Collections;
using Leap;
using System;

public class MainView : MonoBehaviour {
    Controller controller;

    // Position Vector of the pressable button
    Vector3 buttonPos;

    // Threshold for considering screen taps
    private float epsilon = 0.30F;
    private GameObject button;

	// Use this for initialization
	void Start () {
        Debug.Log("Start");
        controller = new Controller();
        if (!controller.IsGestureEnabled (Gesture.GestureType.TYPE_SWIPE))
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

        button = GameObject.Find("Sphere");
        //button = FindObjectOfType();
        buttonPos = button.transform.position.normalized;
        Debug.Log(String.Format("Button pos: {0}", buttonPos.ToString()));
        // buttonPos = new Vector(position.x, position.y, position.z);
    }
	
	// Update is called once per frame
	void Update () {
        Frame frame = controller.Frame();
        GestureList gestures = frame.Gestures();
        foreach (Gesture gesture in gestures)
        {
            if (gesture.Type == Gesture.GestureType.TYPE_SCREEN_TAP)
            {
                ScreenTapGesture screentapGesture = new ScreenTapGesture(gesture);
                processScreenTaps(screentapGesture);
            } else if (gesture.Type == Gesture.GestureType.TYPE_KEY_TAP)
            {
                KeyTapGesture keyTapGesture = new KeyTapGesture(gesture);
                processKeyTaps(keyTapGesture);
            }
        }
    }

    void processScreenTaps(ScreenTapGesture gesture)
    {
        Debug.Log(String.Format("Screen tap dirn {0}", gesture));
        Vector pos = gesture.Position.Normalized;
        Debug.Log(String.Format("Pos: {0}", pos.ToString()));
        float dist = Vector3.Distance(buttonPos, new Vector3(pos.x, pos.y, pos.z));
        Debug.Log(String.Format("Distance: {0}", dist));
        if (dist <= epsilon)
        {
            addObject();
        }
    }

    void processKeyTaps(KeyTapGesture gesture)
    {
        Debug.Log(String.Format("Key tap dirn {0}", gesture));
        Vector pos = gesture.Position.Normalized;
        Debug.Log(String.Format("Pos: {0}", pos.ToString()));
        float dist = Vector3.Distance(buttonPos, new Vector3(pos.x, pos.y, pos.z));
        Debug.Log(String.Format("Distance: {0}", dist));
        if (dist <= epsilon + 0.05F)
        {
            addObject();
        }
    }

    void addObject()
    {
        Debug.Log("Adding an object");
    }
}
