using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemVisual", menuName = "Item/ItemVisual", order = 1)]
public class ChangeItemVisual : ScriptableObject
{
    [SerializeField] GameObject[] normalItems;
    [SerializeField] Sprite[] fishTextures;

    [ContextMenu("Update fish textures")]
    public void GetAllNormalItems()
    {
        for (int i = 0; i < normalItems.Length; i++)
        {
            normalItems[i].GetComponent<SpriteRenderer>().sprite = fishTextures[i];
        }
    }
}
