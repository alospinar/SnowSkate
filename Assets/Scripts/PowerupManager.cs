using UnityEngine;

public class PowerupManager : MonoBehaviour
{
    [SerializeField] PowerupSO powerup ;

    PlayerController player;
    SpriteRenderer spriteRenderer;
    float timeleft; 

    void Start()
    {
        player = FindAnyObjectByType<PlayerController>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        timeleft = powerup.GetTime();
    }
    void Update()
    {
        CountdownTimer();
    }

    void CountdownTimer()
    {
        if (spriteRenderer.enabled == false)
        {
            if (timeleft > 0)
            {
                timeleft -= Time.deltaTime;
                
                if(timeleft <= 0)
                {
                    player.DesactivatePowerup(powerup);
                }
            }
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Player");
        
        if (collision.gameObject.layer == layerIndex && spriteRenderer.enabled)
        {
            spriteRenderer.enabled = false;
            //activate the powerup
            player.ActivatePowerup(powerup);
            
        }
    }
    
}
