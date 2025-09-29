using UnityEngine;
using TMPro;
public class ManagerScript : MonoBehaviour
{

    TMP_Text scoreText;
    TMP_Text livesText;

    int score = 0;
    int lives = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreText.text = "Score: " + score.ToString();
        livesText.text = "Lives: " + lives.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddScore(int addition)
    {
        score += addition;
        scoreText.text = "Score: " + score.ToString();
        scoreText.GetComponent<Animator>().SetTrigger("Add");

    }

    public void LoseLife()
    {
        lives -= 1;
        livesText.text = "Lives: " + lives.ToString();
        scoreText.GetComponent<Animator>().SetTrigger("Add");
    }
}
