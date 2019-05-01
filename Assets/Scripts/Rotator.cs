using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
        private const float degree = 45;

        void Update()
        {
                transform.Rotate(new Vector3(0, 0, degree) * Time.deltaTime);
        }
}
