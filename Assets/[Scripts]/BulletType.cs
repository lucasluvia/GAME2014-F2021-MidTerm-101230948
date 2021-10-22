/******************
 * BulletType.cs
 * Lucas Dunster - 101230948
 * Modified: 10/22/2021
 * 
 * Description:
 *  - An Enum to differentiate between the types of bullets used in the game. 
 * 
 * Version 1.06
 ******************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public enum BulletType
{
    REGULAR,
    FAT,
    PULSING,
    RANDOM
}
