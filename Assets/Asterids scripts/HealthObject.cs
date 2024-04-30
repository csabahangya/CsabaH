using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthObject : MonoBehaviour
{
    [SerializeField] int startHp;
    [SerializeField] int collisionDamage;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] List<Sprite> sprites;
    [SerializeField] TMP_Text healthText;

    int currentHp;
    bool isSetup = false;

    private void OnValidate()
    {
        if (spriteRenderer == null)
            spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        currentHp = startHp;
        isSetup = true;
        UpdateHealthText();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Damage(collisionDamage);
    }

    public void Damage(int damage)
    {
        if (!isSetup) return;
        if (damage < 0) return;

        currentHp -= damage;

        UpdateHealthText();
        UpDateSprite();

        if (currentHp <= 0)
            Destroy(gameObject);
    }

    private void UpDateSprite()
    {
        if (spriteRenderer == null) return;
        if (sprites == null || sprites.Count == 0) return;

        float healthRate = (float)currentHp / startHp;
        healthRate = 1 - healthRate;
        int index = Mathf.RoundToInt(healthRate * (sprites.Count - 1));
        spriteRenderer.sprite = sprites[index];
    }
    void UpdateHealthText()
    {
        if (healthText != null)
            healthText.text = "Health: " + currentHp;
    }
}
