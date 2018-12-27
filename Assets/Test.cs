using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
         
         // Bossクラスの変数を宣言してインスタンスを代入
        boss boss = new boss();

        for (int i = 0; i < 11; i++) {
            // magicの関数を呼び出す
            boss.Magic();
        }



        

    }

    // Update is called once per frame
    void Update()
    {

    }
}

public class boss
{
    private int mp = 53;

    // magic用の関数
    public void Magic()
    {
        //ifを使ってmp
        if (mp > 5) {

            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);

        }else{
            Debug.Log("MPが足りないため魔法が使えない。");

        }
    }

}





