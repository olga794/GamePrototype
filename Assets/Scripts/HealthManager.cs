using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public static HealthManager Instance;
    public int currentHealth, maxHealth;
    public float invincibleLength = 2f;
    public float invincCounter;
    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        UpdateUI();
    }

    //  Update is called once per frame
    void Update()
    {
        if (invincCounter > 0)
        {
            invincCounter -= Time.deltaTime;
        }
    }

    public void Hurt()
    {
        if (invincCounter <= 0)
        {
            currentHealth--;
            if(currentHealth <= 0)
            {
                currentHealth = 0;
                GameManager.instance.Respawn();
            }
            else
            {
                PlayerController.instance.Knockback();
                invincCounter = invincibleLength;
            
            }
            UpdateUI();
        }
        
        
    }

    public void ResetHealth()
    {
        currentHealth = maxHealth;
        UpdateUI();
    }

    public void AddHealth(int amountToHeal)
    {
        currentHealth += amountToHeal;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        UpdateUI();
    }

    public void UpdateUI()
    {
        UIManager.Instance.TexHearlth.text = currentHealth.ToString();
    }

}