using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public static HealthManager Instance;
    public int currentHealth, maxHealth;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    //  Update is called once per frame
    void Update()
    {
        
    }

    public void Hurt()
    {
        currentHealth--;
        if(currentHealth <= 0)
        {
            currentHealth = 0;
            GameManager.instance.Respawn();
        }
    }

    
    
    
}