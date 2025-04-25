using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] private GameObject _panelStartMenu;
    [SerializeField] private GameObject _panelFinishLevel;
    [SerializeField] private GameObject _panelGameOver;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            transform.parent = null;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        Init();
    }

    public void Init()
    {
        Pause();
        _panelStartMenu.gameObject.SetActive(true);
    }

    public void StartGame()
    {
        LevelToggler.Instance.FirstLevel();
        Resume();
    }

    public void Pause()
    {
        Time.timeScale = 0.0f;
    }

    public void Resume()
    {
        Time.timeScale = 1.0f;
    }
}
