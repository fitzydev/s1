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
	// Token: 0x02000990 RID: 2448
	[Token(Token = "0x2000990")]
	[Serializable]
	public class MethInstance : ProductItemInstance
	{
		// Token: 0x060042C6 RID: 17094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042C6")]
		[Address(RVA = "0x87B650", Offset = "0x87A050", VA = "0x18087B650")]
		public MethInstance()
		{
		}

		// Token: 0x060042C7 RID: 17095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042C7")]
		[Address(RVA = "0x87B640", Offset = "0x87A040", VA = "0x18087B640")]
		public MethInstance(ItemDefinition definition, int quantity, EQuality quality, [Optional] PackagingDefinition packaging)
		{
		}

		// Token: 0x060042C8 RID: 17096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042C8")]
		[Address(RVA = "0x87EED0", Offset = "0x87D8D0", VA = "0x18087EED0", Slot = "12")]
		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		// Token: 0x060042C9 RID: 17097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042C9")]
		[Address(RVA = "0x87F060", Offset = "0x87DA60", VA = "0x18087F060", Slot = "18")]
		public override void SetupPackagingVisuals(FilledPackagingVisuals visuals)
		{
		}

		// Token: 0x060042CA RID: 17098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042CA")]
		[Address(RVA = "0x87EF80", Offset = "0x87D980", VA = "0x18087EF80", Slot = "14")]
		public override ItemData GetItemData()
		{
			return null;
		}

		// Token: 0x060042CB RID: 17099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042CB")]
		[Address(RVA = "0x87E480", Offset = "0x87CE80", VA = "0x18087E480", Slot = "20")]
		public override void ApplyEffectsToNPC(NPC npc)
		{
		}

		// Token: 0x060042CC RID: 17100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042CC")]
		[Address(RVA = "0x87EAD0", Offset = "0x87D4D0", VA = "0x18087EAD0", Slot = "21")]
		public override void ClearEffectsFromNPC(NPC npc)
		{
		}

		// Token: 0x060042CD RID: 17101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042CD")]
		[Address(RVA = "0x87E6D0", Offset = "0x87D0D0", VA = "0x18087E6D0", Slot = "22")]
		public override void ApplyEffectsToPlayer(Player player)
		{
		}

		// Token: 0x060042CE RID: 17102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042CE")]
		[Address(RVA = "0x87EBE0", Offset = "0x87D5E0", VA = "0x18087EBE0", Slot = "23")]
		public override void ClearEffectsFromPlayer(Player Player)
		{
		}
	}
}
