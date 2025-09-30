using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.NPCs;
using ScheduleOne.Packaging;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Product.Packaging;

namespace ScheduleOne.Product
{
	// Token: 0x020009B9 RID: 2489
	[Token(Token = "0x20009B9")]
	[Serializable]
	public class WeedInstance : ProductItemInstance
	{
		// Token: 0x06004412 RID: 17426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004412")]
		[Address(RVA = "0x8AB8A0", Offset = "0x8AA2A0", VA = "0x1808AB8A0")]
		public WeedInstance()
		{
		}

		// Token: 0x06004413 RID: 17427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004413")]
		[Address(RVA = "0x87B640", Offset = "0x87A040", VA = "0x18087B640")]
		public WeedInstance(ItemDefinition definition, int quantity, EQuality quality, [Optional] PackagingDefinition packaging)
		{
		}

		// Token: 0x06004414 RID: 17428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004414")]
		[Address(RVA = "0x8AB0E0", Offset = "0x8A9AE0", VA = "0x1808AB0E0", Slot = "12")]
		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		// Token: 0x06004415 RID: 17429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004415")]
		[Address(RVA = "0x8AB270", Offset = "0x8A9C70", VA = "0x1808AB270", Slot = "18")]
		public override void SetupPackagingVisuals(FilledPackagingVisuals visuals)
		{
		}

		// Token: 0x06004416 RID: 17430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004416")]
		[Address(RVA = "0x8AB190", Offset = "0x8A9B90", VA = "0x1808AB190", Slot = "14")]
		public override ItemData GetItemData()
		{
			return null;
		}

		// Token: 0x06004417 RID: 17431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004417")]
		[Address(RVA = "0x8AA8B0", Offset = "0x8A92B0", VA = "0x1808AA8B0", Slot = "20")]
		public override void ApplyEffectsToNPC(NPC npc)
		{
		}

		// Token: 0x06004418 RID: 17432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004418")]
		[Address(RVA = "0x8AAD70", Offset = "0x8A9770", VA = "0x1808AAD70", Slot = "21")]
		public override void ClearEffectsFromNPC(NPC npc)
		{
		}

		// Token: 0x06004419 RID: 17433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004419")]
		[Address(RVA = "0x8AA9E0", Offset = "0x8A93E0", VA = "0x1808AA9E0", Slot = "22")]
		public override void ApplyEffectsToPlayer(Player player)
		{
		}

		// Token: 0x0600441A RID: 17434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600441A")]
		[Address(RVA = "0x8AAE00", Offset = "0x8A9800", VA = "0x1808AAE00", Slot = "23")]
		public override void ClearEffectsFromPlayer(Player Player)
		{
		}
	}
}
