using System;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class GetPoints : MonoBehaviour
{
    [SerializeField] string _pointTag;
    [SerializeField] InputProvider _inputs;
    [SerializeField] Transform _pointSlot;
    [SerializeField] DataModel _data;
    bool _inBasket = false;
    List<GameObject> _pointInHand = new List<GameObject>();

    public void ChangeBasketState(bool state)
    {
        _inBasket = state;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _inputs.Inputs.Interaction.Default.started += SpacePressed;
    }

    private void SpacePressed(InputAction.CallbackContext context)
    {
        if (_pointInHand.Count > 0 && _inBasket)
        {
            /* alternatywny sposób który naraz zalicza wszystkie punkty
            for (int i = 0; i < _pointInHand.Count; i++)
            {
                if(_pointInHand[i]) //upewniamy się że dany punkt nie został już zniszczony
                _data.Points++;
            }
            _pointInHand.Clear();
            */

            _data.Points++;
            var pointForBasket = _pointInHand.Last();
            pointForBasket = _pointInHand[_pointInHand.Count - 1];
            _pointInHand.Remove(pointForBasket);
            Destroy(pointForBasket);

            //kod poniżej nic nie robi, jest tylko demonstracyjnie
            //_pointInHand.RemoveAt(_pointInHand.Count - 1);
            var pointInHandArray = _pointInHand.ToArray();
            int[] a = new int[7];
            var aList = a.ToList();

        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag(_pointTag))
        {
            _pointInHand.Add(other.gameObject);
            _pointInHand.Last().transform.SetParent(_pointSlot);
            _pointInHand.Last().transform.localPosition = Vector3.zero;
        }
    }

}
