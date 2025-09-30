using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Construction.Features
{
	// Token: 0x0200079A RID: 1946
	[Token(Token = "0x200079A")]
	public class GenericOption : MonoBehaviour
	{
		// Token: 0x0600347F RID: 13439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600347F")]
		[Address(RVA = "0x7A34F0", Offset = "0x7A1EF0", VA = "0x1807A34F0", Slot = "4")]
		public virtual void Install()
		{
		}

		// Token: 0x06003480 RID: 13440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003480")]
		[Address(RVA = "0x7A3550", Offset = "0x7A1F50", VA = "0x1807A3550", Slot = "5")]
		public virtual void Uninstall()
		{
		}

		// Token: 0x06003481 RID: 13441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003481")]
		[Address(RVA = "0x7A3530", Offset = "0x7A1F30", VA = "0x1807A3530", Slot = "6")]
		public virtual void SetVisible()
		{
		}

		// Token: 0x06003482 RID: 13442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003482")]
		[Address(RVA = "0x7A20C0", Offset = "0x7A0AC0", VA = "0x1807A20C0", Slot = "7")]
		public virtual void SetInvisible()
		{
		}

		// Token: 0x06003483 RID: 13443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003483")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public GenericOption()
		{
		}

		// Token: 0x04002483 RID: 9347
		[Token(Token = "0x4002483")]
		[FieldOffset(Offset = "0x20")]
		[Header("Interface settings")]
		public string optionName;

		// Token: 0x04002484 RID: 9348
		[Token(Token = "0x4002484")]
		[FieldOffset(Offset = "0x28")]
		public Color optionButtonColor;

		// Token: 0x04002485 RID: 9349
		[Token(Token = "0x4002485")]
		[FieldOffset(Offset = "0x38")]
		public float optionPrice;

		// Token: 0x04002486 RID: 9350
		[Token(Token = "0x4002486")]
		[FieldOffset(Offset = "0x40")]
		[Header("Events")]
		public UnityEvent onInstalled;

		// Token: 0x04002487 RID: 9351
		[Token(Token = "0x4002487")]
		[FieldOffset(Offset = "0x48")]
		public UnityEvent onUninstalled;

		// Token: 0x04002488 RID: 9352
		[Token(Token = "0x4002488")]
		[FieldOffset(Offset = "0x50")]
		public UnityEvent onSetVisible;

		// Token: 0x04002489 RID: 9353
		[Token(Token = "0x4002489")]
		[FieldOffset(Offset = "0x58")]
		public UnityEvent onSetInvisible;
	}
}
