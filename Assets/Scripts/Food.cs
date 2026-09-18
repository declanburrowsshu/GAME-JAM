using UnityEngine;

public class Food : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += (Vector3.down * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
