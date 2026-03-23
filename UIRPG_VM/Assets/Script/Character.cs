using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public float health;
    
    [SerializeField] private string charname;

    public abstract void Attack(Character toHit);

    public string charName
    {
        get { return charname;}
    }

    public void TakeDamage(float damage)
    {
        health = health - damage;
        Debug.Log(charName + " took " + damage + " damage. Health: " + health);;
    }

    public void Takedamage(Weapon thrownWeapon)
    {
        float damage = thrownWeapon.GetDamage();
        TakeDamage(damage);
        
        Debug.Log(charName + " took " + damage + " damage. Health: " + health);
        
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
