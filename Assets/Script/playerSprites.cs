using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSprites : MonoBehaviour
{

    [SerializeField] ScoreKeeper scoreKeeper;

    [SerializeField] SpriteRenderer spriteRenderer;

    public Sprite bayiSprite;
    public Sprite remajaSprite;
    public Sprite dewasaSprite;
    public Sprite dewasaMatangSprite;
    public Sprite megamouthSprite;

    private int score;

    private void Start()
    {

        // Initialize the sprite renderer and set the initial sprite
        spriteRenderer = GetComponent<SpriteRenderer>();
        SetSpriteBasedOnScore();
    }

    private void Update()
    {
        // Update the sprite based on the new score
        SetSpriteBasedOnScore();

        score = scoreKeeper.GetScore();
        Debug.Log(score);
    }

    private void SetSpriteBasedOnScore()
    {
        if (score >= 7000)
        {
            spriteRenderer.sprite = megamouthSprite; // Set the Megamouth sprite for score >= 7000
            Debug.Log("megamouthSprite");
        }
        else if (score >= 5000)
        {
            spriteRenderer.sprite = dewasaMatangSprite; // Set the Dewasa-Matang sprite for score >= 5000
            Debug.Log("dewasaMatangSprite");
        }
        else if (score >= 3000)
        {
            spriteRenderer.sprite = dewasaSprite; // Set the Dewasa sprite for score >= 3000
            Debug.Log("dewasaSprite");
        }
        else if (score >= 1000)
        {
            spriteRenderer.sprite = remajaSprite; // Set the Remaja sprite for score >= 1000
            Debug.Log("remajaSprite");
        }
        else
        {
            spriteRenderer.sprite = bayiSprite; // Set the Bayi sprite for score < 1000
            Debug.Log("bayiSprite");
        }
    }
}