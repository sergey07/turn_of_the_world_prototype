using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] private GameObject PanelStartMenu;
    [SerializeField] private GameObject PanelFinishLevel;
    [SerializeField] private GameObject PanelGameOver;

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
        PanelStartMenu.gameObject.SetActive(true);
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
