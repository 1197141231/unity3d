using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public int force; //速度

    public float xMin, xMax, zMin, zMax;

    public float tilt = 4; // 倾斜角度

    public GameObject boom; // 预设子弹体
    public Transform boomController; //子弹发射器的Transform

    public float fireRate = 0.2f;//子弹发射频率 1s/5发
    private float nextFire = 0;// 下一次发射时间

    //稳定刷新间隔相同
    private void FixedUpdate()
    {
        //获取用户输入水平力及垂直力
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //控制player移动
        Vector3 movement = new Vector3(h, 0, v);
        this.GetComponent<Rigidbody>().velocity = movement * force;

        //区域限制
        this.GetComponent<Rigidbody>().position = new Vector3
        (
            Mathf.Clamp(this.GetComponent<Rigidbody>().position.x, xMin, xMax),
            0,
            Mathf.Clamp(this.GetComponent<Rigidbody>().position.z, zMin, zMax)
        );

        //倾斜
        this.GetComponent<Rigidbody>().rotation = Quaternion.Euler(0, 0, this.GetComponent<Rigidbody>().velocity.x * -tilt);
    }

    //每帧刷新自动间隔或许不相同 1s/60帧
    private void Update()
    {
        //unity input输入中默认fire1为鼠标左键  Time.time游戏运行时间
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            print("成功");
            nextFire = Time.time + fireRate;
            //实例化预设体
            Instantiate(boom, boomController.position, boomController.rotation);
            this.GetComponent<AudioSource>().Play();
        }
        else
        {
            print("失败");
        }
    }
}