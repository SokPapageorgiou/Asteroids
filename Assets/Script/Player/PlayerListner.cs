using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    [CreateAssetMenu(fileName = "PlayerListner", menuName = "ScriptableObjects/Player/Listner")]
    public class PlayerListner : ScriptableObject
    {
        public float angleInDegrees;
    }
}
