using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Skating
{
	// Token: 0x020002DF RID: 735
	[Token(Token = "0x20002DF")]
	[RequireComponent(typeof(Skateboard))]
	public class SkateboardVisuals : MonoBehaviour
	{
		// Token: 0x06000FF9 RID: 4089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FF9")]
		[Address(RVA = "0xAE7E00", Offset = "0xAE6800", VA = "0x180AE7E00")]
		private void Awake()
		{
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FFA")]
		[Address(RVA = "0xAE7E50", Offset = "0xAE6850", VA = "0x180AE7E50")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FFB")]
		[Address(RVA = "0xAE7F50", Offset = "0xAE6950", VA = "0x180AE7F50")]
		public SkateboardVisuals()
		{
		}

		// Token: 0x0400103F RID: 4159
		[Token(Token = "0x400103F")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		public float MaxBoardLean;

		// Token: 0x04001040 RID: 4160
		[Token(Token = "0x4001040")]
		[FieldOffset(Offset = "0x24")]
		public float BoardLeanRate;

		// Token: 0x04001041 RID: 4161
		[Token(Token = "0x4001041")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public Transform Board;

		// Token: 0x04001042 RID: 4162
		[Token(Token = "0x4001042")]
		[FieldOffset(Offset = "0x30")]
		private Skateboard skateboard;
	}
}
