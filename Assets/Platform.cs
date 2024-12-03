using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] string _playerTag;
    Animator _myAnimator;

    private void Start()
    {
        _myAnimator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(_playerTag))
        {
            other.transform.SetParent(transform);
            _myAnimator.SetBool("PlayerInTrigger", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(_playerTag))
        {
            other.transform.SetParent(null);
            _myAnimator.SetBool("PlayerInTrigger", false);
        }
    }
}
