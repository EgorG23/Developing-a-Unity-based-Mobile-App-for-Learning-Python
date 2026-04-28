using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

[System.Serializable]
public class Lesson
{
    public GameObject introScreen;
    public GameObject theoryScreen;
    public string practiceSceneName;
}

public class LessonManager : MonoBehaviour
{
    public static LessonManager Instance;

    public Transform screenContainer;
    public List<Lesson> lessons;

    public GlitchEffect glitchEffect;

    private GameObject currentScreen;
    private int currentLessonIndex;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        if (GameManager.Instance == null)
        {
            Debug.LogError("GameManager не найден");
            return;
        }

        if (lessons == null || lessons.Count == 0)
        {
            Debug.LogError("Lessons не настроены");
            return;
        }

        int index = GameManager.Instance.currentLessonIndex;

        if (index < 0 || index >= lessons.Count)
            index = 0;

        StartLesson(index);
    }

    public void StartLesson(int lessonIndex)
    {
        currentLessonIndex = lessonIndex;
        ShowIntro();
    }

    public void ShowIntro()
    {
        LoadScreen(lessons[currentLessonIndex].introScreen);
    }

    public void ShowTheory()
    {
        LoadScreen(lessons[currentLessonIndex].theoryScreen);
    }

    public void LoadScreen(GameObject prefab)
    {
        if (currentScreen != null)
            Destroy(currentScreen);

        currentScreen = Instantiate(prefab, screenContainer);

        if (glitchEffect != null)
            glitchEffect.TriggerGlitch();
    }

    public void StartPractice()
    {
        GameManager.Instance.theoryCompleted[currentLessonIndex] = true;
        SceneManager.LoadScene(lessons[currentLessonIndex].practiceSceneName);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("LessonsList");
    }
}