using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] DataModel _data;

    private void Update()
    {
        _data.Time -= Time.deltaTime;
        if (_data.Time <= 0)
        {

        }
    }
}
