using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class login : MonoBehaviour {

    
    public Text username;
    public Text password;

    public Text message;

    public GameObject setting; //设置页面对象
    private bool isOut = true; //设置界面是否在外
    // Use this for initialization

    public void OnLoginClick() {
        string username = this.username.text;
        string password = this.password.text;
        print("**"+username+ "**"+password);
        if (username == "admin" && password == "admin")
        {
            message.gameObject.SetActive(true);
            message.text = "登陆成功";
            StartCoroutine(DisapperMes()) ;
            print("登陆成功");
            //登陆跳转
            Application.LoadLevel("startSence");
        }
        else
        {
            message.gameObject.SetActive(true);
            message.text = "用户名密码错误";
            StartCoroutine(DisapperMes());
            print("用户名密码错误");
        }

    }

    //等待消失
    IEnumerator DisapperMes()
    {
        yield return new WaitForSeconds(1);
        message.gameObject.SetActive(false);

    }
	
    public void OnSoundOff(bool isActive)
    {
        print(isActive);
    }

    public void OnSoundVolumeChanged(float value)
    {
        print(value);
    }

    public void OnEazyChanged(bool isActive)
    {
        print("easy"+isActive);
    }

    public void OnNormalChanged(bool isActive)
    {
        print("nor" + isActive);
    }

    public void OnDiddcultChanged(bool isActive)
    {
        print("dif" + isActive);
    }

    public void OnSettingButtonClick()
    {
        if (isOut)
        {
            isOut = false;
            iTween.MoveTo(setting,setting.transform.position + new Vector3(800,0,0),0.5f);
        }
        else
        {
            isOut = true;
            iTween.MoveTo(setting, setting.transform.position - new Vector3(800, 0, 0), 0.5f);
        }
    }


}
