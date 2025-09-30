using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x0200084C RID: 2124
	[Token(Token = "0x200084C")]
	public class GameVolumeSetter : MonoBehaviour
	{
		// Token: 0x06003A2F RID: 14895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A2F")]
		[Address(RVA = "0x80FA20", Offset = "0x80E420", VA = "0x18080FA20")]
		private void Update()
		{
		}

		// Token: 0x06003A30 RID: 14896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A30")]
		[Address(RVA = "0x583E00", Offset = "0x582800", VA = "0x180583E00")]
		public GameVolumeSetter()
		{
		}

		// Token: 0x04002889 RID: 10377
		[Token(Token = "0x4002889")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float VolumeMultiplier;
	}
}
