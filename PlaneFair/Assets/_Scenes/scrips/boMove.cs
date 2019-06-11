using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boMove : MonoBehaviour
{
    public float speed = 20f;

    // Use this for initialization
    private void Start()
    {
        this.GetComponent<Rigidbody>().velocity = this.transform.forward * speed;
    }
}