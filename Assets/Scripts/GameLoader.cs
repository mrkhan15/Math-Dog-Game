using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameLoader : MonoBehaviour
{
    [SerializeField] public TMP_Text onScreenTMP;

    string onScreenText = "Hello";
    public void PuzzleLevel()
    {
        onScreenText = "Puzzle Coming Soon";

        onScreenTMP.text = onScreenText;
    }


    public void FunLevel()
    {
        onScreenText = "Subtraction Fun coming Soon";
        onScreenTMP.text = onScreenText;
    }

    public void QuizLevel()
    {
        onScreenText = "Quiz Level Coming Soon";
        onScreenTMP.text = onScreenText;
    }

    public void PracticeLevel(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);

    }

    public void BeginnerLevel(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void IntermediateLevel(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}