using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DusterController : MonoBehaviour
{
    private Vector3 mousePosition;
    public Rigidbody2D rb;
    private Vector2 direction;
    private float moveSpeed = 100f;
    public int webCount;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        webCount = 0;
    }

    private void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = (mousePosition - transform.position).normalized;
        rb.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);

        if(webCount >= 6)
        {
            SceneManager.LoadScene("Mansion");
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Web"))
        {
            Destroy(col.gameObject);
            webCount++;
        }
    }
}
