using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text numberText; // UI element to display the random number
    public Text scoreText; // UI element to display the score
    public Text mistakesText; // UI element to display the mistakes
    public Button boomButton; // Button for "Boom"
    public Button NextButton; // Button for "Not Boom"

    private int score = 0;
    private int mistakes = 0;
    private int currentNumber;

    private const int maxMistakes = 3;

    void Start()
    {
        boomButton.onClick.AddListener(() => CheckInput(true));
        NextButton.onClick.AddListener(() => CheckInput(false));
        GenerateRandomNumber();
    }

    void GenerateRandomNumber()
    {
        // Generate a random number between 1 and 100
        currentNumber = Random.Range(1, 101);
        numberText.text = "Number: " + currentNumber;
    }

    bool IsBoom(int number)
    {
        // Check if the number is divisible by 7 or contains a 7
        return number % 7 == 0 || number.ToString().Contains("7");
    }

    void CheckInput(bool isBoomSelected)
    {
        // Compare player's choice with the correct answer
        if (IsBoom(currentNumber) == isBoomSelected)
        {
            score++;
        }
        else
        {
            mistakes++;
        }

        // Update UI
        UpdateUI();

        // Check if the game is over
        if (mistakes >= maxMistakes)
        {
            EndGame();
        }
        else
        {
            GenerateRandomNumber();
        }
    }

    void UpdateUI()
    {
        scoreText.text = "Score: " + score;
        mistakesText.text = "Mistakes: " + mistakes + "/" + maxMistakes;
    }

    void EndGame()
    {
        numberText.text = "Game Over!";
        boomButton.interactable = false;
        NextButton.interactable = false;
    }
}
