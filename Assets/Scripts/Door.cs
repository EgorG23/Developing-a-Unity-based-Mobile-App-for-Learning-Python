using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject successScreen;
    public GameObject noKeyScreen;

    public void TryOpen()
    {
        if (QuestManager.Instance.hasKey)
        {
            Debug.Log("Дверь открыта");

            PracticeManager.Instance.ShowScreen(successScreen);
        }
        else
        {
            Debug.Log("Нет ключа");

            if (noKeyScreen != null)
                PracticeManager.Instance.ShowScreen(noKeyScreen);
        }
    }
}