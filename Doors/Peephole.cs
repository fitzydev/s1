using System;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.Doors
{
	// Token: 0x02000605 RID: 1541
	[Token(Token = "0x2000605")]
	public class Peephole : MonoBehaviour
	{
		// Token: 0x06002625 RID: 9765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002625")]
		[Address(RVA = "0x6FD410", Offset = "0x6FBE10", VA = "0x1806FD410")]
		public void Open()
		{
		}

		// Token: 0x06002626 RID: 9766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002626")]
		[Address(RVA = "0x6FD3A0", Offset = "0x6FBDA0", VA = "0x1806FD3A0")]
		public void Close()
		{
		}

		// Token: 0x06002627 RID: 9767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002627")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public Peephole()
		{
		}

		// Token: 0x04001D62 RID: 7522
		[Token(Token = "0x4001D62")]
		[FieldOffset(Offset = "0x20")]
		public Animation DoorAnim;

		// Token: 0x04001D63 RID: 7523
		[Token(Token = "0x4001D63")]
		[FieldOffset(Offset = "0x28")]
		public AudioSourceController OpenSound;

		// Token: 0x04001D64 RID: 7524
		[Token(Token = "0x4001D64")]
		[FieldOffset(Offset = "0x30")]
		public AudioSourceController CloseSound;
	}
}
