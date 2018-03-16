using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScoreIfHit : MonoBehaviour {

    public Text scoreText;

    private void Start()
    {
        scoreText = GameObject.FindWithTag("Score").GetComponent<Text>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (scoreText == null)
            return;
        var score = scoreText.text;
        int scoreInt = int.Parse(score);
        scoreInt++;
        scoreText.text = scoreInt.ToString();
        GameObject.Destroy(this.gameObject);

    }
}
