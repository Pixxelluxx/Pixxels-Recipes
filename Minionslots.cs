using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace PixxelsRecipes
{
    public class MCount : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Minion Counter");
        }
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.rare = ItemRarityID.Yellow;
            item.value = 10000;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            var line = new TooltipLine(mod, "Minion Counter Tooltip", "Minion Slots: " + Main.LocalPlayer.maxMinions +
                                                     "\nMinions Summoned: " + Main.LocalPlayer.slotsMinions);
            tooltips.Add(line);
        }    

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 50);
            recipe.AddIngredient(ItemID.SummoningPotion, 2);

            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }  
        
    }
}
