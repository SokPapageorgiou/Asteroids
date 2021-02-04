using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CameraGamePlayArea))]
public class CameraStageWarp : MonoBehaviour
{
    private CameraGamePlayArea _gamePlayArea;
    
    private float _otherPositionX;
    private float _otherPositionY;

    private void Start()
    {
        _gamePlayArea = GetComponent<CameraGamePlayArea>();
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        InvertPosition(other);
    }

    private void InvertPosition(Collider2D other)
    {
        _otherPositionX = other.gameObject.transform.position.x;
        _otherPositionY = other.gameObject.transform.position.y;

        if (_otherPositionX > _gamePlayArea.HalfWidth || _otherPositionX < -_gamePlayArea.HalfWidth)
            other.gameObject.transform.position = new Vector2(-_otherPositionX, _otherPositionY);

        if (_otherPositionY > _gamePlayArea.HalfHeight || _otherPositionY < -_gamePlayArea.HalfHeight)
            other.gameObject.transform.position = new Vector2(_otherPositionX, -_otherPositionY);
    }
}
