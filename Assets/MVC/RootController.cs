using UnityEngine;

public class RootController : MonoBehaviour
{
    [SerializeField] GameplayController _gameplayController;
    [SerializeField] MenuController _menuController;
    [SerializeField] GameOverController _gameoverController;

    private void Start()
    {
        _menuController.SetRootController(this);
        _gameoverController.SetRootController(this);
        _gameplayController.SetRootController(this);
        ActivateController(UIstate.Menu);
    }

    public void ActivateController(UIstate state)
    {
        DeactivateControllers();
        switch (state)
        {
            case UIstate.Menu:
                _menuController.gameObject.SetActive(true);
                break;
            case UIstate.Game:
                _gameplayController.gameObject.SetActive(true);
                break;
            case UIstate.EndGame:
                _gameoverController.gameObject.SetActive(true);
                break;
            default:
                break;

        }
    }

    public void DeactivateControllers()
    {
        _gameoverController.gameObject.SetActive(false);
        _menuController.gameObject.SetActive(false);
        _gameplayController.gameObject.SetActive(false);
    }

    public enum UIstate { Menu, Game, EndGame }
}
