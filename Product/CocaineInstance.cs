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
	// Token: 0x02000986 RID: 2438
	[Token(Token = "0x2000986")]
	[Serializable]
	public class CocaineInstance : ProductItemInstance
	{
		// Token: 0x060042A9 RID: 17065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042A9")]
		[Address(RVA = "0x87B650", Offset = "0x87A050", VA = "0x18087B650")]
		public CocaineInstance()
		{
		}

		// Token: 0x060042AA RID: 17066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042AA")]
		[Address(RVA = "0x87B640", Offset = "0x87A040", VA = "0x18087B640")]
		public CocaineInstance(ItemDefinition definition, int quantity, EQuality quality, [Optional] PackagingDefinition packaging)
		{
		}

		// Token: 0x060042AB RID: 17067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042AB")]
		[Address(RVA = "0x87B240", Offset = "0x879C40", VA = "0x18087B240", Slot = "12")]
		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		// Token: 0x060042AC RID: 17068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042AC")]
		[Address(RVA = "0x87B3D0", Offset = "0x879DD0", VA = "0x18087B3D0", Slot = "18")]
		public override void SetupPackagingVisuals(FilledPackagingVisuals visuals)
		{
		}

		// Token: 0x060042AD RID: 17069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042AD")]
		[Address(RVA = "0x87B2F0", Offset = "0x879CF0", VA = "0x18087B2F0", Slot = "14")]
		public override ItemData GetItemData()
		{
			return null;
		}

		// Token: 0x060042AE RID: 17070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042AE")]
		[Address(RVA = "0x87A880", Offset = "0x879280", VA = "0x18087A880", Slot = "20")]
		public override void ApplyEffectsToNPC(NPC npc)
		{
		}

		// Token: 0x060042AF RID: 17071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042AF")]
		[Address(RVA = "0x87AE00", Offset = "0x879800", VA = "0x18087AE00", Slot = "21")]
		public override void ClearEffectsFromNPC(NPC npc)
		{
		}

		// Token: 0x060042B0 RID: 17072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042B0")]
		[Address(RVA = "0x87AA60", Offset = "0x879460", VA = "0x18087AA60", Slot = "22")]
		public override void ApplyEffectsToPlayer(Player player)
		{
		}

		// Token: 0x060042B1 RID: 17073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042B1")]
		[Address(RVA = "0x87AF40", Offset = "0x879940", VA = "0x18087AF40", Slot = "23")]
		public override void ClearEffectsFromPlayer(Player Player)
		{
		}
	}
}
