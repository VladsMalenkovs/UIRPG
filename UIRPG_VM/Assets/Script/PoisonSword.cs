using UnityEngine;

namespace Script
{
    public class PoisonSword : Sword
    {
        [SerializeField] private float poisonDamage;

        [SerializeField] public int poisonCount;

        public override float GetDamage()
        {
            float baseDamage = base.GetDamage();
            if (poisonCount > 0)
            {
                poisonCount -= 1;
                 return baseDamage + poisonDamage;
            }

            return baseDamage;
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
}
