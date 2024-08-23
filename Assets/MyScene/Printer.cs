using UnityEngine;
using TMPro;
using VContainer;

public class Printer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textMesh;
    private SceneManager _sceneManager;

    [Inject]
    private void Construct(SceneManager sceneManager)
    {
        _sceneManager = sceneManager;
        Debug.Log("SceneManager injected successfully");
    }

    public void PrintNumberOnScreen()
    {
        string textValue = textMesh.text;
        int currentNumber;

        if (int.TryParse(textValue, out currentNumber))
        {
            currentNumber += _sceneManager.PrintNumber;
        }
        else
        {
            currentNumber = _sceneManager.PrintNumber;
        }

        textMesh.text = currentNumber.ToString();
    }
}
