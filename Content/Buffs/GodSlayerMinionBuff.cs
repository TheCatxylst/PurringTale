﻿using Terraria;
using Terraria.ModLoader;
using PurringTale.Content;
using PurringTale.Content.Items.Weapons;
using PurringTale.Content.Projectiles.MinionProjectiles;

namespace PurringTale.Content.Buffs
{
    public class GodSlayerMinionBuff : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            if (player.ownedProjectileCounts[ModContent.ProjectileType<GodSlayerMinionProjectile>()] > 0)
            {
                player.buffTime[buffIndex] = 18000;
            }
            else
            {
                player.DelBuff(buffIndex);
                buffIndex--;
            }
        }
    }
}