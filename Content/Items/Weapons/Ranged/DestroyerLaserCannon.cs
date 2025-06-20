using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PurringTale.Content.Items.MobLoot;
using PurringTale.Content.Items.Placeables.Bars;

namespace PurringTale.Content.Items.Weapons.Ranged;

public class DestroyerLaserCannon : ModItem
{
        public override void SetDefaults()
        {
            Item.damage = 400;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 7;
            Item.useAnimation = 7;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useTurn = false;
            Item.knockBack = 10;
            Item.value = Item.sellPrice(gold: 50);
            Item.rare = ItemRarityID.Quest;
            Item.UseSound = SoundID.Item12;
            Item.autoReuse = true;
            Item.shoot = ProjectileID.LaserMachinegunLaser;
            Item.useAmmo = AmmoID.Gel;
            Item.shootSpeed = 90f;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<BrokenDestroyerLaserCannon>(1);
            recipe.AddIngredient<TopiumBar>(20);
            recipe.AddIngredient<CoreOfValhalla>(20);
            recipe.AddIngredient(ItemID.LunarBar, 100);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();
        }

        public override Vector2? HoldoutOffset()
        {
            Vector2 offset = new(6, 2);
            return offset;
        }
}
