using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour {

    //自动销毁多余的项目
    public float leftTime = 1f; // 存在时间
	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, leftTime);
	}
	

}
