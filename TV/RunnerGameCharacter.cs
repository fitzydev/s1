using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.TV
{
	// Token: 0x020002AE RID: 686
	[Token(Token = "0x20002AE")]
	public class RunnerGameCharacter : MonoBehaviour
	{
		// Token: 0x06000E4E RID: 3662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E4E")]
		[Address(RVA = "0xABEB10", Offset = "0xABD510", VA = "0x180ABEB10")]
		public void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E4F")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public RunnerGameCharacter()
		{
		}

		// Token: 0x04000E9F RID: 3743
		[Token(Token = "0x4000E9F")]
		[FieldOffset(Offset = "0x20")]
		public RunnerGame Game;

		// Token: 0x04000EA0 RID: 3744
		[Token(Token = "0x4000EA0")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent onHit;
	}
}
