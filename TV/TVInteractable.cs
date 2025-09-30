using System;
using Il2CppDummyDll;
using ScheduleOne.Interaction;
using UnityEngine;

namespace ScheduleOne.TV
{
	// Token: 0x020002B7 RID: 695
	[Token(Token = "0x20002B7")]
	public class TVInteractable : MonoBehaviour
	{
		// Token: 0x06000E8F RID: 3727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E8F")]
		[Address(RVA = "0xAC7540", Offset = "0xAC5F40", VA = "0x180AC7540")]
		private void Start()
		{
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E90")]
		[Address(RVA = "0xAC7490", Offset = "0xAC5E90", VA = "0x180AC7490")]
		private void Hovered()
		{
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E91")]
		[Address(RVA = "0xAC7510", Offset = "0xAC5F10", VA = "0x180AC7510")]
		private void Interacted()
		{
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E92")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public TVInteractable()
		{
		}

		// Token: 0x04000EE2 RID: 3810
		[Token(Token = "0x4000EE2")]
		[FieldOffset(Offset = "0x20")]
		public InteractableObject IntObj;

		// Token: 0x04000EE3 RID: 3811
		[Token(Token = "0x4000EE3")]
		[FieldOffset(Offset = "0x28")]
		public TVInterface Interface;
	}
}
