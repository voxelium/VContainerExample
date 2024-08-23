using UnityEngine;
using VContainer;
using VContainer.Unity;

public class GameInstaller : LifetimeScope
{
    [SerializeField] private SceneManager sceneManager;

    protected override void Configure(IContainerBuilder builder)
    {
        // Регистрация SceneManager как singleton, если он один на сцене
        builder.RegisterComponent(sceneManager);

        // Регистрация Printer и SpawningObject
        builder.RegisterComponentInHierarchy<Printer>();
        builder.RegisterComponentInHierarchy<SpawningObject>();
    }
}
