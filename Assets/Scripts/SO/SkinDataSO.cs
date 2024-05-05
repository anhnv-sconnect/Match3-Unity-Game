using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = Constants.SKIN_DATA_SO, menuName = "ScriptableObjects/SkinData")]
public class SkinDataSO : ScriptableObject
{
    public Sprite[] Skin;
}
