using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RondomRotator : MonoBehaviour
{
    public float v = 1; //旋转速度

    // Use this for initialization
    private void Start()
    {
        this.GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * v;
    }
}