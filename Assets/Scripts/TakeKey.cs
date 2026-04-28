using UnityEngine;

public class TakeKey : MonoBehaviour
{
    public GameObject keyNotification;

    public void TakeKeyMethod()
    {
        QuestManager.Instance.hasKey = true;
        if (keyNotification != null)
        {
            keyNotification.SetActive(true);
        }
        gameObject.SetActive(false);

        Debug.Log("Ключ взят");
    }
}