using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	// Token: 0x020009C8 RID: 2504
	[Token(Token = "0x20009C8")]
	public class Equippable_AvatarViewmodel : Equippable_Viewmodel
	{
		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x06004464 RID: 17508 RVA: 0x00011EC8 File Offset: 0x000100C8
		[Token(Token = "0x17000980")]
		protected bool equipAnimDone
		{
			[Token(Token = "0x6004464")]
			[Address(RVA = "0x8B82E0", Offset = "0x8B6CE0", VA = "0x1808B82E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004465 RID: 17509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004465")]
		[Address(RVA = "0x8B7CC0", Offset = "0x8B66C0", VA = "0x1808B7CC0", Slot = "4")]
		public override void Equip(ItemInstance item)
		{
		}

		// Token: 0x06004466 RID: 17510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004466")]
		[Address(RVA = "0x8B80B0", Offset = "0x8B6AB0", VA = "0x1808B80B0", Slot = "5")]
		public override void Unequip()
		{
		}

		// Token: 0x06004467 RID: 17511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004467")]
		[Address(RVA = "0x8B7F40", Offset = "0x8B6940", VA = "0x1808B7F40", Slot = "9")]
		protected override void PlayEquipAnimation()
		{
		}

		// Token: 0x06004468 RID: 17512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004468")]
		[Address(RVA = "0x8B8160", Offset = "0x8B6B60", VA = "0x1808B8160", Slot = "6")]
		protected override void Update()
		{
		}

		// Token: 0x06004469 RID: 17513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004469")]
		[Address(RVA = "0x8B81C0", Offset = "0x8B6BC0", VA = "0x1808B81C0")]
		public Equippable_AvatarViewmodel()
		{
		}

		// Token: 0x04002FDF RID: 12255
		[Token(Token = "0x4002FDF")]
		[FieldOffset(Offset = "0x68")]
		public RuntimeAnimatorController AnimatorController;

		// Token: 0x04002FE0 RID: 12256
		[Token(Token = "0x4002FE0")]
		[FieldOffset(Offset = "0x70")]
		public Vector3 ViewmodelAvatarOffset;

		// Token: 0x04002FE1 RID: 12257
		[Token(Token = "0x4002FE1")]
		[FieldOffset(Offset = "0x7C")]
		public Vector3 ViewmodelAvatarRotationOffset;

		// Token: 0x04002FE2 RID: 12258
		[Token(Token = "0x4002FE2")]
		[FieldOffset(Offset = "0x88")]
		[Header("Equipping")]
		public float EquipTime;

		// Token: 0x04002FE3 RID: 12259
		[Token(Token = "0x4002FE3")]
		[FieldOffset(Offset = "0x90")]
		public string EquipTrigger;

		// Token: 0x04002FE4 RID: 12260
		[Token(Token = "0x4002FE4")]
		[FieldOffset(Offset = "0x98")]
		protected float timeEquipped;
	}
}
