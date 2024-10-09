using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerScript : MonoBehaviour
{
    public Animator animator;
    private bool isActive = false;

    public void SetActiveState(bool active)
    {
        if (isActive != active)
        {
            isActive = active;
            animator.SetBool("IsActive", isActive);
            Debug.Log("Character is now " + (isActive ? "Active" : "Idle"));
        }
    }
}

