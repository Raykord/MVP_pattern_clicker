using UnityEngine;

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

        var prefabUIRoot = Resources.Load<UIRootView>("UIRoot");
        _rootView = Object.Instantiate(prefabUIRoot);
        Object.DontDestroyOnLoad(_rootView.gameObject );
    }

    private void RunGame()
    {

    }
}
