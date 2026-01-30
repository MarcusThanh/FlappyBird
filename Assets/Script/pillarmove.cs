using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float speed = 5f; // Tốc độ trôi

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        //Tự hủy khi đi qua
        if (transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
    }
}