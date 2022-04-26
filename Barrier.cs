using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    void Update()
    {
        if (transform.position.x < -8)
            Destroy(gameObject);
    }
}
