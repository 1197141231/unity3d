using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {



    public GameObject stone; //障碍物
    public Vector3 stoneAppearPosition;//障碍物出生地unity前台设置


    public int stoneCount = 10; //循环生成障碍物的个数
    public float stoneWait = .5f; //生成障碍物时间间隔
    public float waveWait = 4f; //每一波障碍物时间间隔
    public float startWait = 1f; //游戏开始等待时间


    // Use this for initialization
    void Start() {
       StartCoroutine(AppearPosition()); //StartCoroutine与IEnumerator配套使用，协程
    }
	
	// Update is called once per frame
	IEnumerator AppearPosition() {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 1; i < stoneCount; i++)
            {
                //自定义随机位置
                Vector3 stoneAppearPosition_random = new Vector3(Random.Range(-stoneAppearPosition.x, stoneAppearPosition.x), stoneAppearPosition.y, stoneAppearPosition.z);
                Quaternion stoneAppearRotation = Quaternion.identity; //初始化角度，默认不自转，预设体已经定义转动
                Instantiate(stone, stoneAppearPosition_random, stoneAppearRotation);

                yield return new WaitForSeconds(stoneWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
       


    }
}
