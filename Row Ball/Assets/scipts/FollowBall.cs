using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour
{
    public Transform ballTransform;
    private Vector3 offset;

    // Use this for initialization
    private void Start()
    {
        //球与相机相对位移
        offset = transform.position - ballTransform.position;
    }

    // Update is called once per frame
    //求位置更新后相机位置更新
    private void Update()
    {
        transform.position = ballTransform.position + offset;
    }
}