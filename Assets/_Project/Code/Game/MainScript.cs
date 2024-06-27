using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    [SerializeField] StandartView standartView;
    [SerializeField] PlayerData playerData;


    // Start is called before the first frame update
    void Awake()
    {
        var view = Instantiate(standartView);
        Model model = new StandartModel(view, playerData);
        Presenter presenter = new StandartPresender(model);

        view.Init(presenter);
    }

    
}
