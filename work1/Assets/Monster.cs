
using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("���ʳt��")] [Range(0, 10)]
    public float speed = 3.5f;
    [Tooltip("�����O , �d��O 0 ~ 500"), Range(0, 500)]
    public int attack = 100;
    [Tooltip("��q , �d��O 0 ~ 5000"), Range(0, 5000)]
    public int Blood = 350;
    [Tooltip("�l�ܽd�� , �d��O 0 ~ 50"), Range(0, 50)]
    public int track = 30;
    //�l�ܮy��
    public Vector3 v3Custom = new Vector3(0, 0, 0);
    //�����D��
    [Header("�����D��")]
    public bool Prop = false;
    [Tooltip("�����D����v , �d��O 0 ~ 1"), Range(0, 1)]
    public float Drop = 1;
    [Header("�����D�㭵��")]
    public Object DropSound;
    //���˭���
    public Object HurtSound;
    //��������
    public Object AttackSound;


}
