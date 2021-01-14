using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LotScroller : MonoBehaviour
{
    [SerializeField] private float _scrollDelta;
    [SerializeField] private ScrollRect _rect;
    private float _nextPosition = 0;
    private float _column;
    private bool _isScroll;

    public void SetColumns(float column)
    {
        _column = column;
    }

    private void Update()
    {
        if (_nextPosition != _rect.horizontalNormalizedPosition && !_isScroll)
        {
            _rect.horizontalNormalizedPosition = Mathf.MoveTowards(_rect.horizontalNormalizedPosition, _nextPosition, _scrollDelta);
        }
    }

    public void SetScroll(bool scroll)
    {
        _isScroll = scroll;
    }

    public void SkrewUp()
    {
        float newPosition = 0;
        if(_nextPosition < _rect.horizontalNormalizedPosition)
        {
            while (newPosition < _rect.horizontalNormalizedPosition)
                newPosition += (1f / (_column - 2f));
        }
        else
        {
            newPosition = 1;
            while(newPosition > _rect.horizontalNormalizedPosition)
            {
                newPosition -= (1f / (_column - 2f));
            }
        }
        _nextPosition = newPosition;
    }

    public void ScrollForward()
    {
        _nextPosition = _rect.horizontalNormalizedPosition + (1f / (_column - 2f));
        Debug.Log(_nextPosition);
    }

    public void ScrollBack()
    {
        _nextPosition = _rect.horizontalNormalizedPosition - (1f / (_column - 2f));
    }
}
