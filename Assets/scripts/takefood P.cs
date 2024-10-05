using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class objInter : MonoBehaviour
{
    public int f = 0;
    public int b = 0;
    public int m = 0;
    public Text successTxt_P;
    public Text successTxt_C;
    public Text successTxt_T;
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"f{f}b{b}m{m}");
        if (collision.gameObject.name == "fish_take")
        {
            collision.gameObject.SetActive(false);
            f = 1;
        }
        if(f==1&& collision.gameObject.name == "Pinguin_001")
        {
            successTxt_P.text = "Feed the penguins successfully";
        }
        if (collision.gameObject.name == "meat_take")
        {
            collision.gameObject.SetActive(false);
            m = 1;
        }
        if (m == 1 && collision.gameObject.name == "Tiger_001")
        {
            successTxt_T.text = "Feed the tiger successfully";
        }
        if (collision.gameObject.name == "bread_take")
        {
            collision.gameObject.SetActive(false);
            b = 1;
        }
        if (b == 1 && collision.gameObject.name == "Chicken_001")
        {
            successTxt_C.text = "Feed the chicken successfully";
        }
    }
}