using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    [SerializeField] string MainMenuScene = "MainMenu";
    [SerializeField] float maxHealth = 1f;
    float CurrentHealth;


    void Start()
    {
        CurrentHealth = maxHealth;
    }

    private void Update()
    {
        if (CurrentHealth > maxHealth)
        {
            CurrentHealth = maxHealth;
        }
    }

    public void Hit(float rawDamage)
    {
        CurrentHealth -= rawDamage;

        Debug.Log("OUCH: " + CurrentHealth.ToString());

        if (CurrentHealth <= 0)
        {
            OnDeath();
        }
    }


    float NormalisedHitPoints()
    {
        return CurrentHealth / maxHealth;
    }
    public void Heal(float rawDamage)
    {
        CurrentHealth += rawDamage;

        Debug.Log("Yay: " + CurrentHealth.ToString());

        if (CurrentHealth <= 0)
        {
            Debug.Log("TODO: GAME OVER - YOU DIED");
        }
    }
    void OnDeath()
    {
        Debug.Log("TODO: GAME OVER - YOU DIED");
        Cursor.visible = true;
       // SceneManager.LoadScene(MainMenuScene);
    }
}

