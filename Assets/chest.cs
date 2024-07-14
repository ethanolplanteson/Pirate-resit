using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest : MonoBehaviour, iinteractable
{
    [SerializeField] private string _prompt;

    public string interactionprompt => _prompt;

    public bool interact(interactor interactor)
    {
        Debug.Log("Opening chest");
        return true;
    }
}
