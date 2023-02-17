using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    private bool cameraView = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (cameraView == false && Input.GetKeyDown(KeyCode.Space))
        {
            cameraView = true;
            offset = new Vector3(0, 5, -10);
        }
        else if (cameraView == true && Input.GetKeyDown(KeyCode.Space))
        {
            cameraView = false;
            offset = new Vector3(0, 3, 2);
        }

        // set offset on player
        transform.position = player.transform.position + offset;
    }
}
