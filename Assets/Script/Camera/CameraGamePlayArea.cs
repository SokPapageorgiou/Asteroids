using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class CameraGamePlayArea : MonoBehaviour
{
    public static CameraGamePlayArea Instance { get; private set; }
    public float HalfHeight{ get; set; }
    public float HalfWidth { get; set; }
    public Vector2 BoxColliderSize { get; set; }

    void Awake()
    {
        Instance = this;
        
        BoxCollider2D _boxCollider2D = GetComponent<BoxCollider2D>();
        SetBoxColliderSize(_boxCollider2D);
        _boxCollider2D.isTrigger = true;
    }

    private static void SetBoxColliderSize(BoxCollider2D _boxCollider2D)
    {
        Instance.HalfHeight = Camera.main.orthographicSize;
        Instance.HalfWidth = Camera.main.aspect * Instance.HalfHeight;
        Instance.BoxColliderSize = new Vector2(Instance.HalfWidth * 2, Instance.HalfHeight * 2);
        _boxCollider2D.size = Instance.BoxColliderSize;
    }

}
