using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CameraGamePlayArea))]
public class CameraStageWarp : MonoBehaviour
{
    public CameraStageWarp Instance { get; private set;}
    
    private CameraGamePlayArea _gamePlayArea;
    
    private float _otherPositionX;
    private float _otherPositionY;

    private void Awake()
    {
        Instance = this;   
    }

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
        if (_otherPositionX > _gamePlayArea.HalfWidth || _otherPositionX < -_gamePlayArea.HalfWidth) 
            _otherPositionX = InvertPositionX(_otherPositionX);

        _otherPositionY = other.gameObject.transform.position.y;
        if (_otherPositionY > _gamePlayArea.HalfHeight || _otherPositionY < -_gamePlayArea.HalfHeight)
            _otherPositionY = InvertPositionY(_otherPositionY);

        other.gameObject.transform.position = new Vector2(_otherPositionX, _otherPositionY);
    }

    public float InvertPositionX(float _otherPositionX)
    {
        return -_otherPositionX;
    }
    public float InvertPositionY(float _otherPositionY)
    {
        return -_otherPositionY;
    }
}
