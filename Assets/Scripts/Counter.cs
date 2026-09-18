using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text counterText;

    int count = 0;
    void Start()
    {
        counterText.text = count.ToString();
    }

    public void AddCount()
    {
        count += 1;
        counterText.text = count.ToString();
    }
    public void RemoveCount()
    {
        count -= 5;
        counterText.text = count.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Food"))
        {
            AddCount();
        }
        else if (other.CompareTag("BadFood"))
        {
            RemoveCount();
        }
    }
}
