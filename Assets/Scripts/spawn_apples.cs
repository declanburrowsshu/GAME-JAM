using UnityEngine;
public class spawn_apples : MonoBehaviour
{
    int num;
    float timeSec = 0f;
    public GameObject apple;
    public GameObject badapple;
    void Start()
    {
        
    }
    void Update()
    {
        timeSec += Time.deltaTime;
        if (timeSec >= 2)
        {
            num = Random.Range(1, 10);
            timeSec -= 2;
            Vector3 pos = new Vector3(Random.Range(-9, 9), 6);
            Quaternion angle = new Quaternion(0f, 0f, 0f, 1);
            if (num <= 7)
            {
                Instantiate(apple, pos, angle);
            }
            else
            {
                Instantiate(badapple, pos, angle);
            }
        }
    }
}