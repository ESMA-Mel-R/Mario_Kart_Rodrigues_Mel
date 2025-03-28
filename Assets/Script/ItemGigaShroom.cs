using UnityEngine;

[CreateAssetMenu(fileName = "ItemLaunchable", menuName = "Scriptable Objects/ItemLaunchable")]

public class ItemGigaShroom : Item
{
    public override void Activation(PlayerItemManager player)
    {
        player.carControler.Giant();
    }
}
