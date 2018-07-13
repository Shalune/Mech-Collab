using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    //public Transform player;
    public float rotationCatchupSpeed;
    public float positionCatchupSpeed;

    public void UpdateCamera(Transform player)
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, player.rotation, rotationCatchupSpeed);
        Vector2 newPos = Vector2.Lerp(transform.position, player.position, positionCatchupSpeed);
        Debug.Log("playerpos = " + player.position + "    mypos = " + transform.position);

        transform.position = new Vector3(newPos.x, newPos.y, transform.position.z);
        Debug.Log(newPos);
    }
}
