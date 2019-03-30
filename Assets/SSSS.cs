using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SSSS : MonoBehaviour
{
    public Transform tf;
    
    void Update()
    {
        transform.rotation = tf.rotation;
    }
}
