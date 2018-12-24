using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        int[] array = { 10, 20, 30, 40, 50 };
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 10)
            {
                Debug.Log(array[i]);
            }


        }
        for (int i = array.Length - 1; i > -1; i--)
        {
            Debug.Log(array[i]);
        }

         // Bossクラスの変数を宣言してインスタンスを代入
         Boss boss = new Boss();

         // magicの関数を呼び出す
         boss.Magic();

        

    }

    // Update is called once per frame
    void Update()
    {

    }
}

public class Boss
{
    private int mp = 53;

    // magic用の関数
    public void Magic()
    {
        Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
    }
    //減らす関数
    public void Defence(int damage){
        Debug.Log(damage + "MPが足りないため魔法が使えない。");
        this.mp -= damage;
    }

}

public class test : MonoBehaviour
{

}