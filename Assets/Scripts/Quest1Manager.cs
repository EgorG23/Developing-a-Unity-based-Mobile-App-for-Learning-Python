using UnityEngine;

public class Quest1Manager : MonoBehaviour
{
    public static Quest1Manager Instance;

    void Awake()
    {
        Instance = this;
    }

    public bool powerFixed = false;
    public bool pcUnlocked = false;
    public bool codeCorrect = false;

    [Header("Screens")]
    public GameObject pcScreenPrefab;
    public GameObject doorOpenPrefab;
    public GameObject winScreenPrefab;

    public void FixPower()
    {
        powerFixed = true;
        Debug.Log("Питание включено");

        PracticeManager.Instance.ShowScreen(pcScreenPrefab);
    }

    public void UnlockPC()
    {
        if (!powerFixed)
        {
            Debug.Log("Нет тока");
            return;
        }

        pcUnlocked = true;
        Debug.Log("ПК включен");
    }

    public void CheckCode(string code)
    {
        bool nameOK = code.Contains("user_name = \"Alex\"");
        bool passOK = code.Contains("user_password = 1234567890");
        bool print1 = code.Contains("print(user_name)");
        bool print2 = code.Contains("print(user_password)");

        if (nameOK && passOK && print1 && print2)
        {
            codeCorrect = true;
            Debug.Log("Код верный");

            OpenDoor();
        }
        else
        {
            Debug.Log("Код неверный");
        }
    }

    void OpenDoor()
    {
        PracticeManager.Instance.ShowScreen(doorOpenPrefab);
    }

    public void FinishQuest()
    {
        PracticeManager.Instance.ShowScreen(winScreenPrefab);
    }
}