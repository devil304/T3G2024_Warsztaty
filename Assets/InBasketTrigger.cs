using UnityEngine;

public class InBasketTrigger : MonoBehaviour
{
    [SerializeField] string _playerTag;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(_playerTag))
        {
            other.gameObject.GetComponent<GetPoints>().ChangeBasketState(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(_playerTag))
        {
            other.gameObject.SendMessage("ChangeBasketState", false);
        }
    }
}
