using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Dialogue;
using ScheduleOne.Doors;
using ScheduleOne.Interaction;
using ScheduleOne.NPCs.CharacterClasses;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000CEC RID: 3308
	[Token(Token = "0x2000CEC")]
	public class DarkMarketMainDoor : MonoBehaviour
	{
		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x06005DB2 RID: 23986 RVA: 0x00016878 File Offset: 0x00014A78
		// (set) Token: 0x06005DB3 RID: 23987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D0F")]
		public bool KnockingEnabled
		{
			[Token(Token = "0x6005DB2")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005DB3")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005DB4 RID: 23988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DB4")]
		[Address(RVA = "0x900640", Offset = "0x8FF040", VA = "0x180900640")]
		private void Start()
		{
		}

		// Token: 0x06005DB5 RID: 23989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DB5")]
		[Address(RVA = "0xA57360", Offset = "0xA55D60", VA = "0x180A57360")]
		public void SetKnockingEnabled(bool enabled)
		{
		}

		// Token: 0x06005DB6 RID: 23990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DB6")]
		[Address(RVA = "0xA571F0", Offset = "0xA55BF0", VA = "0x180A571F0")]
		public void Hovered()
		{
		}

		// Token: 0x06005DB7 RID: 23991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DB7")]
		[Address(RVA = "0xA572D0", Offset = "0xA55CD0", VA = "0x180A572D0")]
		public void Interacted()
		{
		}

		// Token: 0x06005DB8 RID: 23992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DB8")]
		[Address(RVA = "0xA572D0", Offset = "0xA55CD0", VA = "0x180A572D0")]
		private void Knocked()
		{
		}

		// Token: 0x06005DB9 RID: 23993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DB9")]
		[Address(RVA = "0x6504E0", Offset = "0x64EEE0", VA = "0x1806504E0")]
		public DarkMarketMainDoor()
		{
		}

		// Token: 0x06005DBA RID: 23994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DBA")]
		[Address(RVA = "0xA573E0", Offset = "0xA55DE0", VA = "0x180A573E0")]
		[CompilerGenerated]
		private IEnumerator <Knocked>g__Knock|16_0()
		{
			return null;
		}

		// Token: 0x04004409 RID: 17417
		[Token(Token = "0x4004409")]
		[FieldOffset(Offset = "0x28")]
		public AudioSource KnockSound;

		// Token: 0x0400440A RID: 17418
		[Token(Token = "0x400440A")]
		[FieldOffset(Offset = "0x30")]
		public InteractableObject InteractableObject;

		// Token: 0x0400440B RID: 17419
		[Token(Token = "0x400440B")]
		[FieldOffset(Offset = "0x38")]
		public Peephole Peephole;

		// Token: 0x0400440C RID: 17420
		[Token(Token = "0x400440C")]
		[FieldOffset(Offset = "0x40")]
		public Igor Igor;

		// Token: 0x0400440D RID: 17421
		[Token(Token = "0x400440D")]
		[FieldOffset(Offset = "0x48")]
		public DialogueContainer FailDialogue;

		// Token: 0x0400440E RID: 17422
		[Token(Token = "0x400440E")]
		[FieldOffset(Offset = "0x50")]
		public DialogueContainer SuccessDialogue;

		// Token: 0x0400440F RID: 17423
		[Token(Token = "0x400440F")]
		[FieldOffset(Offset = "0x58")]
		public DialogueContainer SuccessDialogueNotOpen;

		// Token: 0x04004410 RID: 17424
		[Token(Token = "0x4004410")]
		[FieldOffset(Offset = "0x60")]
		private Coroutine knockRoutine;
	}
}
