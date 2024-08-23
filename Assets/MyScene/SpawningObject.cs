using UnityEngine;
using VContainer;

public class SpawningObject : MonoBehaviour
{
    private SceneManager _sceneManager;

    [Inject]
    private void Construct(SceneManager sceneManager)
    {
        _sceneManager = sceneManager;
    }

    public void Debugging()
    {
        Debug.Log("SceneManager in SpawningObject injected successfully");

    }

}
