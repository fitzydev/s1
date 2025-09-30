using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Building.Doors
{
	// Token: 0x02000836 RID: 2102
	[Token(Token = "0x2000836")]
	public class DoorKnocker : MonoBehaviour
	{
		// Token: 0x060039A9 RID: 14761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039A9")]
		[Address(RVA = "0x809020", Offset = "0x807A20", VA = "0x180809020")]
		public void Knock()
		{
		}

		// Token: 0x060039AA RID: 14762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039AA")]
		[Address(RVA = "0x809070", Offset = "0x807A70", VA = "0x180809070")]
		public void PlayKnockingSound()
		{
		}

		// Token: 0x060039AB RID: 14763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039AB")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public DoorKnocker()
		{
		}

		// Token: 0x04002801 RID: 10241
		[Token(Token = "0x4002801")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public Animation Anim;

		// Token: 0x04002802 RID: 10242
		[Token(Token = "0x4002802")]
		[FieldOffset(Offset = "0x28")]
		public string KnockingSoundClipName;

		// Token: 0x04002803 RID: 10243
		[Token(Token = "0x4002803")]
		[FieldOffset(Offset = "0x30")]
		public AudioSource KnockingSound;
	}
}
