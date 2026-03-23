using UnityEngine;

public class Player : Character
{
    [SerializeField] Weapon activeWeapon;
    public override void Attack(Character enemyToHit)
    {
        enemyToHit.Takedamage(activeWeapon);
    }
    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
