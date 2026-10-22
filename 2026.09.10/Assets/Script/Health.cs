using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int maxHp = 3;
    public int currentHp;
    public Slider hpSlider;    //플레이어만 연결
    public GameObject dropPrefab;    //적만 연결
    public float dropChance = 0.3f;   // 30%
    public static int killCount;    //모든 Health가 같이 쓰는 값 하나
    public float invincibleTime = 0f;   //플레이어는 0.5
    float lastHitTime = -999f;
  

    void Start()
    {
        currentHp = maxHp;
        UpdateBar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        if (currentHp <= 0) return;   //이미 죽었으면 무시
        if (Time.time < lastHitTime + invincibleTime) return;
        lastHitTime = Time.time;

        currentHp -= damage;
        Debug.Log(name + " HP: " + currentHp);
        UpdateBar();

        if (currentHp <= 0) Die();
        else Blink();
    }

    public void Heal(int amount)
    {
        currentHp = Mathf.Min(currentHp +  amount, maxHp);
        UpdateBar();
    }

    //Die의 else만, Destroy 바로 위에 추가

    void UpdateBar()
    {
        Debug.Log(name + " Current HP : " + currentHp + " / Max HP : " + maxHp);
        if (hpSlider != null)
        hpSlider.value = (float)currentHp / maxHp;
    }

    void Die()
    {
        if (CompareTag("Player"))
        {
            GameManager.Instance.GameOver();
        }
        else
        {
            if(dropPrefab != null && Random.value < dropChance)
            {
                Vector3 pos = transform.position + Vector3.up * 0.5f;
            }
            killCount++;
            Destroy(gameObject);
        }
    }

    void Blink()
    {
        SetVisible(false);
        Invoke(nameof(ShowAgain), 0.1f);
    }

    void ShowAgain()
    {
        SetVisible(true);
    }

    void SetVisible(bool on)
    {
        foreach (Renderer r in GetComponentsInChildren<Renderer>())
            r.enabled = on;
    }
}
