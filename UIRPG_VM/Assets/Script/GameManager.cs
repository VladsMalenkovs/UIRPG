using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private Enemy enemy;
    [SerializeField] private TextMeshProUGUI playerName, playerHp, enemyName, enemyHp;

    void Start()
    {
        UpdateUI();

    }
    
    
    private void UpdateUI()
    {
        playerName.text = player.charName;
        playerHp.text = player.health.ToString("F1");
        enemyHp.text = enemy.health.ToString("F1");
        enemyName.text = enemy.charName;
    }

    public void PlayerAttack()
    {
        player.Attack(enemy);
        UpdateUI();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
