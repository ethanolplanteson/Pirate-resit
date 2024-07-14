using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface iinteractable
{
   public string interactionprompt { get; }

    public bool interact(interactor interactor);
}
