using UnityEngine;

public class HpPractice : MonoBehaviour
{
    public int currentHp;
    public int maxHp;

    [ContextMenu("체력")]
    void PrintHP()
    {
        float temp = (float)currentHp / maxHp * 100;
        // Debug.Log("HP" + temp + "%");
        Debug.Log((int)temp);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
