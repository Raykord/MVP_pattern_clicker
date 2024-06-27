using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIRootView : MonoBehaviour
{
    [SerializeField] GameObject _loadingScreen;

    private void Awake()
    {
        HideLoginScreen();
    }


    public void ShowLoginScreen()
    {
        _loadingScreen.SetActive(true);
    }

    public void HideLoginScreen()
    {
        _loadingScreen.SetActive(false);
    }
}
