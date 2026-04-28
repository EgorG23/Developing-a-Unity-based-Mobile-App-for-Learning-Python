using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;

    [Header("Префаб экрана меню")]
    public GameObject menuScreenPrefab;

    [Header("Контейнер")]
    public Transform screenContainer;

    private GameObject currentMenuScreen;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        ShowMenuScreen();
    }

    public void ShowMenuScreen()
    {
        if (currentMenuScreen != null)
            Destroy(currentMenuScreen);

        currentMenuScreen = Instantiate(menuScreenPrefab, screenContainer);

        currentMenuScreen.SetActive(true);

    }

    public void OnStartButtonClick()
    {
        GameManager.Instance.currentLessonIndex = 0;
        SceneManager.LoadScene("LessonsList");
    }

    private void ActivateAllChildren(Transform parent)
    {
        foreach (Transform child in parent)
        {
            child.gameObject.SetActive(true);
            if (child.childCount > 0)
                ActivateAllChildren(child);
        }
    }
}