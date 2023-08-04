using Terraria;
using Terraria.GameInput;
using Terraria.ModLoader;

namespace RandomItemButton
{
    public class RandomItemButtonPlayer : ModPlayer
    {
        public override void ProcessTriggers(TriggersSet triggersSet)
        {
            if (RandomItemButton.giveRandomItem.JustPressed)
            {
                base.Player.PutItemInInventoryFromItemUsage(Main.rand.Next(0, ItemLoader.ItemCount));
            }
            base.ProcessTriggers(triggersSet);
        }
    }
}
