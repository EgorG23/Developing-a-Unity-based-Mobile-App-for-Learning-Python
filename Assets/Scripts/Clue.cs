using UnityEngine;

public class Clue : MonoBehaviour
{
    public GameObject clueText;

    public void ShowClue()
    {
        QuestManager.Instance.foundClue = true;
        clueText.SetActive(true);
    }
}