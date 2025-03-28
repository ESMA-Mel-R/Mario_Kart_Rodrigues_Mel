using UnityEngine;

[CreateAssetMenu(fileName = "ItemGigaShroom", menuName = "Scriptable Objects/ItemSize")]

public class ItemGigaShroom : Item
{
    public override void Activation(PlayerItemManager player)
    {
        player.carControler.Giant();
    }
}
