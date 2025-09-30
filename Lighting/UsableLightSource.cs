using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Lighting
{
	// Token: 0x0200051B RID: 1307
	[Token(Token = "0x200051B")]
	public class UsableLightSource : MonoBehaviour
	{
		// Token: 0x06001A96 RID: 6806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A96")]
		[Address(RVA = "0x64FBB0", Offset = "0x64E5B0", VA = "0x18064FBB0")]
		public UsableLightSource()
		{
		}

		// Token: 0x040016EC RID: 5868
		[Token(Token = "0x40016EC")]
		[FieldOffset(Offset = "0x20")]
		[Range(0.5f, 2f)]
		public float GrowSpeedMultiplier;

		// Token: 0x040016ED RID: 5869
		[Token(Token = "0x40016ED")]
		[FieldOffset(Offset = "0x24")]
		public bool isEmitting;
	}
}
