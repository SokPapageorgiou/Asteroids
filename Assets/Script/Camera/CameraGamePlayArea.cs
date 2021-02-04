using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class CameraGamePlayArea : MonoBehaviour
{
    private static CameraGamePlayArea _instance;
    public static CameraGamePlayArea Instance => _instance;
    public float HalfHeight{ get; set; }
    public float HalfWidth { get; set; }

    void Awake()
    {
        if (_instance != null && _instance != this) 
        { 
            Destroy(this.gameObject);
            return;
        }
        _instance = this;
        DontDestroyOnLoad(this.gameObject);

        BoxCollider2D _boxCollider2D = GetComponent<BoxCollider2D>();
        SetBoxColliderSize(_boxCollider2D);
        _boxCollider2D.isTrigger = true;
    }

    private static void SetBoxColliderSize(BoxCollider2D _boxCollider2D)
    {
        _instance.HalfHeight = Camera.main.orthographicSize;
        _instance.HalfWidth = Camera.main.aspect * _instance.HalfHeight;
        _boxCollider2D.size = new Vector2(_instance.HalfWidth * 2, _instance.HalfHeight * 2);
    }

}
