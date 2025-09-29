using UnityEngine;
using TMPro;
public class ManagerScript : MonoBehaviour
{

    Vector3 spawn;

    [SerializeField]
    TMP_Text scoreText;

    [SerializeField]
    TMP_Text livesText;

    int score = 0;
    int lives = 3;

    [SerializeField]
    GameObject gameoverPanel;

    [SerializeField]
    TMP_Text gameoverText;

    [SerializeField]
    GameObject blockade;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawn = transform.position;

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
        transform.position = spawn;
        blockade.SetActive(false);

        if (lives <= 0)
        {
            ShowGameOver();
        }
    }

    public void ShowGameOver()
    {
        gameoverPanel.SetActive(true);
        gameoverText.text = "Game Over! \nYour score was: " + score.ToString();
    }
}
