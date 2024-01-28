using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    [SerializeField] private Transform objectGrabPointTransform;
    [SerializeField] private Transform sceneCamera;

    [SerializeField] private LayerMask pickUpLM;

    private ObjectGrabbable objGrabbable;
    

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if (objGrabbable == null )
            {
                float pickUpDistance = 2f;
                if (Physics.Raycast(sceneCamera.position, sceneCamera.forward, out RaycastHit raycastHit, pickUpDistance, pickUpLM))
                {
                    ///Debug.Log(raycastHit.transform);
                    if (raycastHit.transform.TryGetComponent(out objGrabbable))
                    {
                        objGrabbable.Grab(objectGrabPointTransform);
                        Debug.Log(objGrabbable);
                    }
                }
            } else
            {
                objGrabbable.Drop();
                objGrabbable = null;
            }

        }
    }
}
