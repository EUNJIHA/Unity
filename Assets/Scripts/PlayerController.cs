using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 키보드로 GameObject 위치 움직이기
// 키보드로 Player의 위치를 움직이는 Controller
public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;

    private int count;

    public Text countText;
    public Text winText;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;

        SetCountText();
        winText.text = "";

    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    // Destroy everything that enters the trigger
    void OnTriggerEnter(Collider other) // 여기서 Collider other은 Trigger인 대상.
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count += 1;
            SetCountText();
        }

    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 12)
        {
            winText.text = "You Win!";
        }
    }
}
