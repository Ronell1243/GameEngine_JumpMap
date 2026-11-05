using UnityEngine;

public class StatPractice : MonoBehaviour
{
    public string PlayerName;
    public int Level;
    public float Attack;
    public bool IsBoos;

    [ContextMenu("스탯")]
    void ShowStat()
    {
        Debug.Log("플레이어 이름 : 유재원");
        Debug.Log("레벨 : 99");
        Debug.Log("공격력 : 555");
        Debug.Log("보스 여부 : True");

    }
}
