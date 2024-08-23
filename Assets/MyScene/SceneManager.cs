
using UnityEngine;
using VContainer;
using VContainer.Unity;

public class SceneManager : MonoBehaviour
{
    [SerializeField] private SpawningObject spawningObject;
    public int PrintNumber;

    public void Spawning()
    {
        spawningObject = Instantiate(spawningObject);
        spawningObject.Debugging();
    }

}
