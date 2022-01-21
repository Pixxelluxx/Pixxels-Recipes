using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PixxelsRecipes
{
    public class pixxrecipe : Mod
    {

        public override void AddRecipeGroups()
        {
            RecipeGroup group = new RecipeGroup(() => "Any Copper Bar", new int[] 
            {
                ItemID.CopperBar,
                ItemID.TinBar
            });

            RecipeGroup.RegisterGroup("Any Copper Bar", group);
        }
        //CustomRecipes
        public override void AddRecipes()
        {
            //TinkerTable
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.TatteredCloth, 6);
            recipe.AddIngredient(ItemID.Wood, 20);
            recipe.anyWood = true;
            recipe.AddTile(TileID.Sawmill);
            recipe.SetResult(ItemID.TinkerersWorkshop);
            recipe.AddRecipe();

            //Hellforge
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Furnace);
            recipe.AddIngredient(ItemID.Hellstone, 30);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.Hellforge);
            recipe.AddRecipe();

            //Wire
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Any Copper Bar", 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.Wire, 5);
            recipe.AddRecipe();

            //Wrench
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.IronBar, 25);
            recipe.anyIronBar = true;
            recipe.AddIngredient(ItemID.Wire, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.Wrench);
            recipe.AddRecipe();
            
            //SlimeStaff
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Wood, 20);
            recipe.anyWood = true;
            recipe.AddIngredient(ItemID.Gel, 60);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.SlimeStaff);
            recipe.AddRecipe();
        }
    }
}

