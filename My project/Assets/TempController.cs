using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using Leap.Unity;

public class TempController : MonoBehaviour
{
    
    Controller controller;
    Frame frame;
    List<Hand> hands;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        controller = new Controller();
        frame = controller.Frame();
        hands = frame.Hands;

        if (hands.Count > 0) {
            foreach (Hand hand in hands) {
                if (hand.PinchDistance < 20) {
                    Debug.Log("Pinch detected in hand");
                } else {
                    Debug.Log("No Pinch");
                }
            }
        }
        //
        
    }
}
