using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    public float hp;//体力
    public float power;//攻撃力
    public float defense;//防御力
    public float speed;//移動する速さ
    public float jumpPower;//ジャンプ力

    public void Die()
    {
        //死ぬときのアニメーションを入れる

        Destroy(this.gameObject);
    }

    public void Damage(float opponentPower)
    {
        //ダメージを受けた時のアニメーションを入れる

        hp -= opponentPower - defense;
    }

    public void Attack()
    {
        //攻撃する時のアニメーションを入れる
        //当たり判定を出すとか、
    }
}
