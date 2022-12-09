using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public CharacterController player;

    private void Update()
    {
        scoreText.text = player.score.ToString() + " x";
    }
}
