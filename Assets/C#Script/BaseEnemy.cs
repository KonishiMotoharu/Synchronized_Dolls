using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    public float hp;//�̗�
    public float power;//�U����
    public float defense;//�h���
    public float speed;//�ړ����鑬��
    public float jumpPower;//�W�����v��

    public void Die()
    {
        //���ʂƂ��̃A�j���[�V����������

        Destroy(this.gameObject);
    }

    public void Damage(float opponentPower)
    {
        //�_���[�W���󂯂����̃A�j���[�V����������

        hp -= opponentPower - defense;
    }

    public void Attack()
    {
        //�U�����鎞�̃A�j���[�V����������
        //�����蔻����o���Ƃ��A
    }
}
