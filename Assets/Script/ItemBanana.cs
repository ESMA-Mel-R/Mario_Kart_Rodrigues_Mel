using UnityEngine;

[CreateAssetMenu(fileName = "ItemBanana", menuName = "Scriptable Objects/ItemBanana")]

public class ItemBanana : Item
{
    public GameObject objectToLaunch;

    public override void Activation(PlayerItemManager player)
    {
        Instantiate(objectToLaunch, player.transform.position, player.transform.rotation);
    }
}
