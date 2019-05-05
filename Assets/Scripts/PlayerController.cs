using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
        public float speed;
        public Text scoreText;
        public Text winText;

        private Rigidbody2D rb2d;
        private const string pickUpTag = "PickUp";
        private int score;

        void Start()
        {
                rb2d = GetComponent<Rigidbody2D>();
                score = 0;
                winText.text = "";
                setScoreText();
        }

        void FixedUpdate()
        {
                float moveHorizontal = Input.GetAxis("Horizontal");
                float moveVertical = Input.GetAxis("Vertical");
                Vector2 movement = new Vector2(moveHorizontal, moveVertical);
                rb2d.AddForce(movement * speed);
        }
        void OnTriggerEnter2D(Collider2D other)
        {
                if (other.gameObject.CompareTag(pickUpTag))
                {
                        other.gameObject.SetActive(false);
                        score += 10;
                        setScoreText();
                }
        }

        void setScoreText()
        {
                scoreText.text = "Score: " + score.ToString();
                if (score >= 80)
                {
                        winText.text = "You won!";
                }
        }
}
