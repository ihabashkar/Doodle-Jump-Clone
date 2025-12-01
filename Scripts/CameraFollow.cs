using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CamerFollow : MonoBehaviour
{
    public Transform target;
    private void LateUpdate()
    {
        if (target.position.y > transform.position.y)
        {
            Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            transform.position = newPosition;
        }
    }
}
