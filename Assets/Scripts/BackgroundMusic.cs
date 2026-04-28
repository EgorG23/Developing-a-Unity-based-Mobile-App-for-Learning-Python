using UnityEngine; // Вот эта строчка была пропущена!

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic instance;

    void Awake()
    {
        // Проверка: если музыка уже играет, удаляем новый дубликат
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;

        // Делаем объект "бессмертным" при переходе между сценами
        DontDestroyOnLoad(gameObject);
    }
}