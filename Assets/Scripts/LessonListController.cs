using UnityEngine;
using UnityEngine.SceneManagement;

public class LessonListController : MonoBehaviour
{
    private const string LESSON_SCENE_NAME = "LessonScene";   // ← ИЗМЕНИ на точное имя своей сцены с LessonManager!

    public void OnLesson1Click() => StartLesson(0);
    public void OnLesson2Click() => StartLesson(1);
    public void OnLesson3Click() => StartLesson(2);
    public void OnLesson4Click() => StartLesson(3);

    private void StartLesson(int lessonIndex)
    {
        // Защита от NullReference
        if (GameManager.Instance == null)
        {
            Debug.LogError("GameManager.Instance == null! Убедитесь, что GameManager существует в сцене LessonsList или используй DontDestroyOnLoad.");
            return;
        }

        GameManager.Instance.currentLessonIndex = lessonIndex;

        SceneManager.LoadScene(LESSON_SCENE_NAME);
    }
}