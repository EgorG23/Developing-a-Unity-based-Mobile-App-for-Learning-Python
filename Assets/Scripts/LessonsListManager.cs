using UnityEngine;
using UnityEngine.SceneManagement;

public class LessonsListManager : MonoBehaviour
{
    public static LessonsListManager Instance;

    [Header("Префаб экрана со списком уроков")]
    public GameObject lessonListPrefab;

    [Header("Контейнер")]
    public Transform screenContainer;

    private GameObject currentListScreen;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        ShowLessonListScreen();
    }

    public void ShowLessonListScreen()
    {
        if (currentListScreen != null)
            Destroy(currentListScreen);

        currentListScreen = Instantiate(lessonListPrefab, screenContainer);
        currentListScreen.SetActive(true);
    }

    public void BackClick()
    {
        GameManager.Instance.currentLessonIndex = 0;
        SceneManager.LoadScene("Menu");
    }
}