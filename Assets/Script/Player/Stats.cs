using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player 
{
    [CreateAssetMenu(fileName = "PlayerStats", menuName = "ScriptableObjects/Player/Stats")]
    public class Stats : ScriptableObject
    {
        public float movementStrenght;
        public float rotationSpeed;
    }

}
