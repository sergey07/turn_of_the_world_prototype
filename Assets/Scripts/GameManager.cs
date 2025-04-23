using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] private GameObject PanelStartMenu;
    [SerializeField] private GameObject PanelEndGame;

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
        PanelStartMenu.gameObject.SetActive(true);
    }

    public void StartGame()
    {
        LevelToggler.Instance.FirstLevel();
    }
}
