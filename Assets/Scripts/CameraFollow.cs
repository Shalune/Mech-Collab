using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    //public Transform player;
    public float rotationCatchupSpeed;
    public float positionCatchupSpeed;
    public float forwardOffset;

    public void UpdateCamera(Transform player)
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, player.rotation, rotationCatchupSpeed);

        Vector2 newPos = Vector2.Lerp(transform.position, player.position, positionCatchupSpeed);
        newPos += (Vector2)player.up * forwardOffset;
    
        transform.position = new Vector3(newPos.x, newPos.y, transform.position.z);
        Debug.Log(newPos);
    }
}
