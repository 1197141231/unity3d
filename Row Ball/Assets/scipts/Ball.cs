using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    private Rigidbody rigidbody;

    public int force = 5;
    public Text ballText;
    private int score = 0;
    public GameObject winText;

    // Use this for initialization
    private void Start()
    {
        //获取  力
        rigidbody = GetComponent<Rigidbody>();
    }

    // 球体移动
    private void Update()
    {
        //获取输入水平力及垂直力
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //控制坐标以及力的大小
        rigidbody.AddForce(new Vector3(h, 0, v) * force);
    }

    //碰撞检测
    private void OnCollisionEnter(Collision collision)
    {
        //collision.collider获取碰撞物体collider组件
        string name = collision.collider.name;
        string t = collision.collider.tag;
        print(name);
        print(t);
        if (collision.collider.tag == "pickup")
        {
            Destroy(collision.collider.gameObject);
        }
    }

    //触发检测
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "pickup")
        {
            score++;
            ballText.text = "当前的分：  " + score.ToString();

            if (score == 2)
            {
                winText.SetActive(true);
            }
            Destroy(collider.gameObject);
        }
    }
}