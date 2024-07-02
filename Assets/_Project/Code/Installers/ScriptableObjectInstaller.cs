using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "ScriptableObjectInstaller", menuName = "Installers/ScriptableObjectInstaller")]
public class ScriptableObjectInstaller : ScriptableObjectInstaller<ScriptableObjectInstaller>
{
    [SerializeField] private PlayerData _playerData;

    public override void InstallBindings()
    {
        Container.BindInstance(_playerData);
    }
}