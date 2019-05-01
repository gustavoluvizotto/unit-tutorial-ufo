using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
        public GameObject player;
        private Vector3 offset;

        // Start is called before the first frame update
        void Start()
        {
                // transform is coming from the game object that this script is attached to.
                offset = transform.position - player.transform.position;
        }

        // Update is called once per frame
        // LateUpdate is called after Update (garanteed)
        void LateUpdate()
        {
                transform.position = player.transform.position + offset;
        }
}
