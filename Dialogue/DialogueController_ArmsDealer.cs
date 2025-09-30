using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Quests;

namespace ScheduleOne.Dialogue
{
	// Token: 0x0200060D RID: 1549
	[Token(Token = "0x200060D")]
	public class DialogueController_ArmsDealer : DialogueController
	{
		// Token: 0x06002655 RID: 9813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002655")]
		[Address(RVA = "0x6E9620", Offset = "0x6E8020", VA = "0x1806E9620")]
		private void Awake()
		{
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002656")]
		[Address(RVA = "0x6EA420", Offset = "0x6E8E20", VA = "0x1806EA420", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06002657 RID: 9815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002657")]
		[Address(RVA = "0x6E9AC0", Offset = "0x6E84C0", VA = "0x1806E9AC0", Slot = "12")]
		public override void ChoiceCallback(string choiceLabel)
		{
		}

		// Token: 0x06002658 RID: 9816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002658")]
		[Address(RVA = "0x6E9FF0", Offset = "0x6E89F0", VA = "0x1806E9FF0", Slot = "11")]
		public override void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
		}

		// Token: 0x06002659 RID: 9817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002659")]
		[Address(RVA = "0x6E9D30", Offset = "0x6E8730", VA = "0x1806E9D30")]
		private List<DialogueChoiceData> GetWeaponChoices(List<DialogueController_ArmsDealer.WeaponOption> options)
		{
			return null;
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x0000BD30 File Offset: 0x00009F30
		[Token(Token = "0x600265A")]
		[Address(RVA = "0x6E9710", Offset = "0x6E8110", VA = "0x1806E9710", Slot = "13")]
		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600265B")]
		[Address(RVA = "0x6EA150", Offset = "0x6E8B50", VA = "0x1806EA150", Slot = "9")]
		public override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		// Token: 0x0600265C RID: 9820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600265C")]
		[Address(RVA = "0x6EA6D0", Offset = "0x6E90D0", VA = "0x1806EA6D0")]
		private void TradeRDXForBomb()
		{
		}

		// Token: 0x0600265D RID: 9821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600265D")]
		[Address(RVA = "0x6EA7F0", Offset = "0x6E91F0", VA = "0x1806EA7F0")]
		public DialogueController_ArmsDealer()
		{
		}

		// Token: 0x04001D90 RID: 7568
		[Token(Token = "0x4001D90")]
		[FieldOffset(Offset = "0x80")]
		public List<DialogueController_ArmsDealer.WeaponOption> MeleeWeapons;

		// Token: 0x04001D91 RID: 7569
		[Token(Token = "0x4001D91")]
		[FieldOffset(Offset = "0x88")]
		public List<DialogueController_ArmsDealer.WeaponOption> RangedWeapons;

		// Token: 0x04001D92 RID: 7570
		[Token(Token = "0x4001D92")]
		[FieldOffset(Offset = "0x90")]
		public List<DialogueController_ArmsDealer.WeaponOption> Ammo;

		// Token: 0x04001D93 RID: 7571
		[Token(Token = "0x4001D93")]
		[FieldOffset(Offset = "0x98")]
		public ItemDefinition RDX;

		// Token: 0x04001D94 RID: 7572
		[Token(Token = "0x4001D94")]
		[FieldOffset(Offset = "0xA0")]
		public ItemDefinition Bomb;

		// Token: 0x04001D95 RID: 7573
		[Token(Token = "0x4001D95")]
		[FieldOffset(Offset = "0xA8")]
		private List<DialogueController_ArmsDealer.WeaponOption> allWeapons;

		// Token: 0x04001D96 RID: 7574
		[Token(Token = "0x4001D96")]
		[FieldOffset(Offset = "0xB0")]
		private DialogueController_ArmsDealer.WeaponOption chosenWeapon;

		// Token: 0x04001D97 RID: 7575
		[Token(Token = "0x4001D97")]
		[FieldOffset(Offset = "0xB8")]
		private Quest_DefeatCartel questDefeatCartel;

		// Token: 0x0200060E RID: 1550
		[Token(Token = "0x200060E")]
		[Serializable]
		public class WeaponOption
		{
			// Token: 0x1700064A RID: 1610
			// (get) Token: 0x0600265E RID: 9822 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700064A")]
			public string Name
			{
				[Token(Token = "0x600265E")]
				[Address(RVA = "0x700F60", Offset = "0x6FF960", VA = "0x180700F60")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700064B RID: 1611
			// (get) Token: 0x0600265F RID: 9823 RVA: 0x0000BD48 File Offset: 0x00009F48
			[Token(Token = "0x1700064B")]
			public float Price
			{
				[Token(Token = "0x600265F")]
				[Address(RVA = "0x701000", Offset = "0x6FFA00", VA = "0x180701000")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06002660 RID: 9824 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002660")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public WeaponOption()
			{
			}

			// Token: 0x04001D98 RID: 7576
			[Token(Token = "0x4001D98")]
			[FieldOffset(Offset = "0x10")]
			public bool IsAvailable;

			// Token: 0x04001D99 RID: 7577
			[Token(Token = "0x4001D99")]
			[FieldOffset(Offset = "0x18")]
			public string NotAvailableReason;

			// Token: 0x04001D9A RID: 7578
			[Token(Token = "0x4001D9A")]
			[FieldOffset(Offset = "0x20")]
			public StorableItemDefinition Item;
		}
	}
}
