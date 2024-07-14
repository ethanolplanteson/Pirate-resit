using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactor : MonoBehaviour
{
    [SerializeField] private Transform _interactionpoint;
    [SerializeField] private float _interactionpointradius = 0.5f;
    [SerializeField] private LayerMask _interactablemask;

    private readonly Collider[] _colliders = new Collider[3];
    [SerializeField] private int _numfound;

    private void Update()
    {
        _numfound = Physics.OverlapSphereNonAlloc(_interactionpoint.position, _interactionpointradius, _colliders, (int)_interactablemask);

        if (_numfound > 0)
        {
            var interactable = _colliders[0].GetComponent<iinteractable>();

            if (iinteractable != null && KeyCode.E)
            {
                iinteractable.interact(this);
            }
        }
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(_interactionpoint.position, _interactionpointradius);
    }
}