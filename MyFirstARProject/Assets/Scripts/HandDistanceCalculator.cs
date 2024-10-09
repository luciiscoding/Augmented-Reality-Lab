using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandDistanceCalculator : MonoBehaviour
{
    public Vector3 leftHandPosition;
    public Vector3 rightHandPosition;
    public float activationThreshold = 0.5f; 
    public CharacterControllerScript character1;
    public CharacterControllerScript character2;
    void Update()
    {
        // Simulez pozitiile mainilor
        Vector3 leftHandPosition = new Vector3(0, 0, 0);  
        Vector3 rightHandPosition = new Vector3(0.5f, 0, 0); 

      
        float distance = Vector3.Distance(leftHandPosition, rightHandPosition);

        Debug.Log("Hand Distance: " + distance);  

     
        float activationThreshold = 0.4f;

      
        if (distance < activationThreshold)
        {
            character1.SetActiveState(true); // attack animation
            character2.SetActiveState(true);
        }
        else
        {
            character1.SetActiveState(false); // switch to idle animation
            character2.SetActiveState(false);
        }
    }

}
