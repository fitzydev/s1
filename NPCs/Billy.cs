using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Economy;
using ScheduleOne.ItemFramework;
using ScheduleOne.Quests;
using ScheduleOne.UI.Handover;
using UnityEngine;

namespace ScheduleOne.NPCs
{
	// Token: 0x02000654 RID: 1620
	[Token(Token = "0x2000654")]
	public class Billy : NPC
	{
		// Token: 0x06002784 RID: 10116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002784")]
		[Address(RVA = "0x6E7BD0", Offset = "0x6E65D0", VA = "0x1806E7BD0", Slot = "64")]
		public override void Awake()
		{
		}

		// Token: 0x06002785 RID: 10117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002785")]
		[Address(RVA = "0x6E8050", Offset = "0x6E6A50", VA = "0x1806E8050")]
		public void OpenRDXTradeHandover()
		{
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002786")]
		[Address(RVA = "0x6E7E30", Offset = "0x6E6830", VA = "0x1806E7E30")]
		private void HandoverOutcome(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> givenItems, float payment)
		{
		}

		// Token: 0x06002787 RID: 10119 RVA: 0x0000C3D8 File Offset: 0x0000A5D8
		[Token(Token = "0x6002787")]
		[Address(RVA = "0x6E7C20", Offset = "0x6E6620", VA = "0x1806E7C20")]
		private float GetSucccessChance(List<ItemInstance> items, float price)
		{
			return 0f;
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002788")]
		[Address(RVA = "0x6E8200", Offset = "0x6E6C00", VA = "0x1806E8200")]
		public Billy()
		{
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002789")]
		[Address(RVA = "0x6E8030", Offset = "0x6E6A30", VA = "0x1806E8030", Slot = "99")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600278A")]
		[Address(RVA = "0x6E8010", Offset = "0x6E6A10", VA = "0x1806E8010", Slot = "100")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600278B")]
		[Address(RVA = "0x687D80", Offset = "0x686780", VA = "0x180687D80", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600278C RID: 10124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600278C")]
		[Address(RVA = "0x6E78E0", Offset = "0x6E62E0", VA = "0x1806E78E0", Slot = "108")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.Billy_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001E4A RID: 7754
		[Token(Token = "0x4001E4A")]
		public const int REQUESTED_PRODUCT_AMOUNT = 20;

		// Token: 0x04001E4B RID: 7755
		[Token(Token = "0x4001E4B")]
		public const string REQUESTED_PRODUCT_ID = "cocaine";

		// Token: 0x04001E4C RID: 7756
		[Token(Token = "0x4001E4C")]
		[FieldOffset(Offset = "0x2F0")]
		[Header("References")]
		public Contract TradeContract;

		// Token: 0x04001E4D RID: 7757
		[Token(Token = "0x4001E4D")]
		[FieldOffset(Offset = "0x2F8")]
		public ItemDefinition RDXDefinition;

		// Token: 0x04001E4E RID: 7758
		[Token(Token = "0x4001E4E")]
		[FieldOffset(Offset = "0x300")]
		private Customer customerComp;

		// Token: 0x04001E4F RID: 7759
		[Token(Token = "0x4001E4F")]
		[FieldOffset(Offset = "0x308")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.BillyAssembly-CSharp.dll_Excuted;

		// Token: 0x04001E50 RID: 7760
		[Token(Token = "0x4001E50")]
		[FieldOffset(Offset = "0x309")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.BillyAssembly-CSharp.dll_Excuted;
	}
}
