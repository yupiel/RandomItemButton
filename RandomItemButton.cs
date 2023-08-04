using Terraria.ModLoader;

namespace RandomItemButton
{
    public class RandomItemButton : Mod
    {
        public static ModKeybind giveRandomItem;

        public override void Load()
        {
            giveRandomItem = KeybindLoader.RegisterKeybind(this, "Random Item Button", Microsoft.Xna.Framework.Input.Keys.Y);
            base.Load();
        }

        public override void Unload()
        {
            giveRandomItem = null;
            base.Unload();
        }
    }
}