using System;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.Combat
{
	// Token: 0x020007A9 RID: 1961
	[Token(Token = "0x20007A9")]
	public class Explosion : MonoBehaviour
	{
		// Token: 0x060034E5 RID: 13541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034E5")]
		[Address(RVA = "0x7A2160", Offset = "0x7A0B60", VA = "0x1807A2160")]
		public void Initialize(Vector3 origin, ExplosionData data)
		{
		}

		// Token: 0x060034E6 RID: 13542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034E6")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public Explosion()
		{
		}

		// Token: 0x040024C3 RID: 9411
		[Token(Token = "0x40024C3")]
		[FieldOffset(Offset = "0x20")]
		public AudioSourceController Sound;
	}
}
