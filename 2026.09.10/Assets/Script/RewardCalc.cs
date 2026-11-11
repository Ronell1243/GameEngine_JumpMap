using UnityEngine;
using UnityEngine.Rendering;

public class RewardCalc : MonoBehaviour
{
    public int playSeconds = 3725, gold = 1234, members = 4, kills = 7, expPerKill = 35, totalDamage = 250, hits = 20;
    public float ExpRate;

    [ContextMenu("정산")]
    void Settle()
    {
        int M = playSeconds / 60;
        int h = M / 60;
        Debug.Log(h + "시간" + (M % 60) + "분" + (playSeconds % 60) + "초");

        int Gold = gold / members;
        int Bonus = gold % members;
        Debug.Log("1인당 " + Gold + "G, " + "리더 보너스 " + Bonus + "G");

        int defaltEXP = kills * expPerKill;
        float FinalEXP = defaltEXP * ExpRate;
        Debug.Log("경험치 " + (int)FinalEXP + "(기본 " + defaltEXP + ")");

        float Level = (int)FinalEXP / 100 + 1;
        float R = (int)FinalEXP % 100;
        float EXP = 100 - R;
        Debug.Log("Lv " + Level + ", 다음 레벨까지 " + EXP);

        float Damage = (float)totalDamage / hits;
        Debug.Log("평균 데미지 " + Damage);
    }

    void Start()
    {

    }

    void Update()
    {

    }
}
