using System;
using Il2CppDummyDll;
using ScheduleOne.Interaction;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x020009BA RID: 2490
	[Token(Token = "0x20009BA")]
	public class MixChute : MonoBehaviour
	{
		// Token: 0x0600441B RID: 17435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600441B")]
		[Address(RVA = "0x895250", Offset = "0x893C50", VA = "0x180895250")]
		private void Update()
		{
		}

		// Token: 0x0600441C RID: 17436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600441C")]
		[Address(RVA = "0x8950C0", Offset = "0x893AC0", VA = "0x1808950C0")]
		private void UpdateDoor()
		{
		}

		// Token: 0x0600441D RID: 17437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600441D")]
		[Address(RVA = "0x894E00", Offset = "0x893800", VA = "0x180894E00")]
		public void Hovered()
		{
		}

		// Token: 0x0600441E RID: 17438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600441E")]
		[Address(RVA = "0x894F50", Offset = "0x893950", VA = "0x180894F50")]
		public void Interacted()
		{
		}

		// Token: 0x0600441F RID: 17439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600441F")]
		[Address(RVA = "0x895050", Offset = "0x893A50", VA = "0x180895050")]
		public void SetDoorOpen(bool isOpen)
		{
		}

		// Token: 0x06004420 RID: 17440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004420")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public MixChute()
		{
		}

		// Token: 0x04002F96 RID: 12182
		[Token(Token = "0x4002F96")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public InteractableObject IntObj;

		// Token: 0x04002F97 RID: 12183
		[Token(Token = "0x4002F97")]
		[FieldOffset(Offset = "0x28")]
		public Animation DoorAnim;

		// Token: 0x04002F98 RID: 12184
		[Token(Token = "0x4002F98")]
		[FieldOffset(Offset = "0x30")]
		private bool isDoorOpen;
	}
}
