Inheritance  
Character is the base class for Player and Enemy. Weapon is the base for Sword, MagicSword, PoisonSword. Potion is the base for HealPotion and DamageBuffPotion.  
Encapsulation  
charName in Character has a getter and setter. exp in Enemy has a getter and setter that prevents negative values. level in Player has a public getter and private setter.  
Polymorphism  
Attack() is overridden in Player, Enemy. TakeDamage() is overridden in Player for shield logic. TakeDamage is overloaded one version takes (float, DamageType), another takes (Weapon).  
Abstraction    
Weapon is abstract with abstract method GetDamage() and regular method GetDescription(). Potion is abstract with abstract method Drink().  
Shield - player can toggle shield on/off. Active shield reduces damage by 50% with 25% chance to break. Enemy attacks back after player.  
Level system - killing enemies gives EXP. On level up: +20 max HP, +5 damage. Next level requires 40% more EXP.  
Potions - HealPotion restores HP. DamageBuffPotion adds bonus damage to next attack.  
