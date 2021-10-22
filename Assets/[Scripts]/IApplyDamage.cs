/******************
 * IApplyDamage.cs
 * Lucas Dunster - 101230948
 * Modified: 10/22/2021
 * 
 * Description:
 *  - An Interface which creates the function ApplyDamage that classes inheriting from IApplyDamage can call and use.
 * 
 * Version 1.01
 *  - No changes from template.
 ******************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IApplyDamage
{
    int ApplyDamage();
}
