using UnityEngine;
using Zenject;

public class GameSceneInstaller : MonoInstaller
{
    [SerializeField] StandartView _view;
    [SerializeField] Presenter _presenter;
    [SerializeField] Model _model;



    public override void InstallBindings()
    {
        Container.Bind<View>().FromInstance(_view);
        Container.Bind<Presenter>().FromInstance(_presenter);
        Container.Bind<Model>().FromInstance(_model);
    }
}