using UnityEngine;

public class CoinScript : MonoBehaviour
{
    SpriteRenderer _sr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _sr = GetComponent<SpriteRenderer>();

        _sr.color = new Color(255,255,255);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Debug.Log("Coin Destroy");
        }         
    }
}
