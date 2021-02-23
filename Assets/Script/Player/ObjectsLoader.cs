using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class ObjectsLoader : MonoBehaviour
    {
        [Header("User SO")]
        public UserInputListner userInputListner;

        [Header("Player SO")]
        public PlayerListner playerListner;
        public Stats playerStats;
    }
}
