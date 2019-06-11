using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBoom : MonoBehaviour
{
    // 销毁触发墙的子弹
    private void OnTriggerEnter(Collider collider)
    {
        Destroy(collider.gameObject);
    }
}