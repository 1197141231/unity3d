using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stone_destroy : MonoBehaviour
{
    public GameObject stoneBoomAnimation; //陨石爆炸动画效果
    public GameObject playerBoomAnimation; //玩家飞机爆炸动画效果

    private void OnTriggerEnter(Collider collider)
    {
        print("***" + collider.name);
        //陨石接触到玩家飞机或子弹同时销毁双方
        if (collider.name == "player" || collider.name == "boom(Clone)")
        {
            Destroy(this.gameObject); //销毁自身
            Destroy(collider.gameObject); //销毁接触物

            Instantiate(stoneBoomAnimation, this.transform.position, this.transform.rotation);
            if (collider.name == "player")
            {
                Instantiate(playerBoomAnimation, this.transform.position, this.transform.rotation);
            }
        }
        else
        {
            Destroy(this.gameObject); //销毁自身
        }
    }
}