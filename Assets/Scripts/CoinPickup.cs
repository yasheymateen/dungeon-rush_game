using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] AudioClip coinPickupSFX;
    [SerializeField] int coinValue = 100;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioSource.PlayClipAtPoint(coinPickupSFX, Camera.main.transform.position);
        FindObjectOfType<GameSession>().AddToScore(coinValue);
        Destroy(gameObject);
    }
}
