using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;


public class GameEntryPoint 
{
    private static GameEntryPoint _instance;
    private Coroutines _coroutines;
    private UIRootView _rootView;
  

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void AutoStartGame()
    {
        Application.targetFrameRate = 60;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

        

        _instance = new GameEntryPoint();
        _instance.RunGame();
    }


    private GameEntryPoint() 
    {
        _coroutines = new GameObject("[COROUTINES]").AddComponent<Coroutines>();
        Object.DontDestroyOnLoad( _coroutines.gameObject );

        

        var prefabUIRoot = Resources.Load<UIRootView>("View");
        _rootView = Object.Instantiate(prefabUIRoot);
        Object.DontDestroyOnLoad(_rootView.gameObject );
    }

    private void RunGame()
    {
#if UNITY_EDITOR
        var sceneName = SceneManager.GetActiveScene().name;

        if ( sceneName == Sceens.GAME)
        {
            _coroutines.StartCoroutine(LoadAndStartGamePlay());
            return;
        }

        if (sceneName != Sceens.BOOT)
        {
            return;
        }
#endif


        _coroutines.StartCoroutine(LoadAndStartGamePlay());
    }

    private IEnumerator LoadAndStartGamePlay()
    {
        _rootView.ShowLoginScreen();

        


        yield return LoadScene(Sceens.BOOT);
        yield return LoadScene(Sceens.GAME);

        yield return new WaitForSeconds(2);

        var sceenEntryPoint = Object.FindObjectOfType<GamePlayEntryPoint>();
        sceenEntryPoint.Run();

        _rootView.HideLoginScreen();
    }


    

    private IEnumerator LoadScene(string sceneName)
    {
        yield return SceneManager.LoadSceneAsync(sceneName);
    }
}
