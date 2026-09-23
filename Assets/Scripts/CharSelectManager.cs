using UnityEngine;

public class CharSelectManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] GameObject scoreCanvas;
    [SerializeField] GameObject frogSprite;
    [SerializeField] GameObject dinoSprite;
    void Start()
    {
     Time.timeScale = 0;   
    }

    void BeginGame()
    {
        Time.timeScale = 1f;
        scoreCanvas.SetActive(true);
        gameObject.SetActive(false);
    }

    public void ChooseDino()
    {
        dinoSprite.SetActive(true);
        BeginGame();
    }
    public void ChooseFrog()
    {
        frogSprite.SetActive(true);
        BeginGame();
    }
}
