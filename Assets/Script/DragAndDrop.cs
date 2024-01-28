using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    [SerializeField] private Transform sceneCamera;
    [SerializeField] private LayerMask pickUpLM;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            float pickUpDistance = 2f;
            if(Physics.Raycast(sceneCamera.position, sceneCamera.forward, out RaycastHit raycastHit, pickUpDistance, pickUpLM)){
                ///Debug.Log(raycastHit.transform);
/*                if (raycastHit.transform.TryGetComponent(out ObjectGrabbable objectGrabbable))
                {
                    Debug.Log(objectGrabbable);
                }*/
            }
        }
    }
}
