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
      
        Debug.Log( h +"시간" + (M%60) +"분" + (playSeconds%60) +"초");
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
