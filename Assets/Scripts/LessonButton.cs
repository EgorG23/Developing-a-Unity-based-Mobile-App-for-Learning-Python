using UnityEngine;

public class LessonButton : MonoBehaviour
{
    public void GoToTheory()
    {
        LessonManager.Instance.ShowTheory();
    }

    public void GoToIntro()
    {
        LessonManager.Instance.ShowIntro();
    }

    public void StartPractice()
    {
        LessonManager.Instance.StartPractice();
    }

    public void GoToMenu()
    {
        LessonManager.Instance.GoToMenu();
    }

    public void LoadScreen(GameObject prefab)
    {
        LessonManager.Instance.LoadScreen(prefab);
    }

}