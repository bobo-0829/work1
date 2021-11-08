
using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("移動速度")] [Range(0, 10)]
    public float speed = 3.5f;
    [Tooltip("攻擊力 , 範圍是 0 ~ 500"), Range(0, 500)]
    public int attack = 100;
    [Tooltip("血量 , 範圍是 0 ~ 5000"), Range(0, 5000)]
    public int Blood = 350;
    [Tooltip("追蹤範圍 , 範圍是 0 ~ 50"), Range(0, 50)]
    public int track = 30;
    //追蹤座標
    public Vector3 v3Custom = new Vector3(0, 0, 0);
    //掉落道具
    [Header("掉落道具")]
    public bool Prop = false;
    [Tooltip("掉落道具機率 , 範圍是 0 ~ 1"), Range(0, 1)]
    public float Drop = 1;
    [Header("掉落道具音效")]
    public Object DropSound;
    //受傷音效
    public Object HurtSound;
    //攻擊音效
    public Object AttackSound;


}
