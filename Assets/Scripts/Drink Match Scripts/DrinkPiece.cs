using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkPiece : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;
    private bool _dragging, _placed;

    private Vector2 _offset, _originalPosition;

    private DrinkSlot _slot;

    public void Init(DrinkSlot slot)
    {
        _renderer.sprite = slot.Renderr.sprite;
        _slot = slot;
    }


    void Awake()
    {
        _originalPosition = transform.position; 
    }    
    void Update()
    {
        if (_placed) return;
        if (!_dragging) return;

        var mousePosition = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        transform.position = mousePosition - _offset; 
    }
    void OnMouseDown()
    {
        _dragging = true;

        _offset = GetMousePos() - (Vector2)transform.position;
    }

    void OnMouseUp()
    {
        if(Vector2.Distance(transform.position,_slot.transform.position) < 3)
        {
            transform.position = _slot.transform.position;
            _slot.Placed();
            _placed = true;
            

        }
        else
        {
            transform.position = _originalPosition;
            _dragging = false;  
        }
    }

    Vector2 GetMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition); 
    }
}
