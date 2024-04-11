using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
        [SerializeField] private HealthBar healthBar;
        [SerializeField] private GameObject dieEffect;
        [SerializeField] private float maxHealth;
        private float health;
        private SpriteRenderer spriteRenderer;

        private void Start()
        {
            health = maxHealth;
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        private void OnMouseDown()
        { 
            StartCoroutine(GetDamage());

        }   

        IEnumerator GetDamage()
        {
            float damageDuration = 0.1f;
            float damage = Random.Range(1f, 5f)
            health -= damage;
            if (health > 0)
            {
                spriteRenderer.color = Color.red;
                yield return new WaitForSeconds(damageDuration);
                spriteRenderer.color = Color.white;
            }
            else
            {
                Instantiate(dieEffect, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }

}
