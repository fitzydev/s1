using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Noise
{
	// Token: 0x020004A0 RID: 1184
	[Token(Token = "0x20004A0")]
	public class NoiseEvent
	{
		// Token: 0x0600172F RID: 5935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600172F")]
		[Address(RVA = "0x5F14C0", Offset = "0x5EFEC0", VA = "0x1805F14C0")]
		public NoiseEvent(Vector3 _origin, float _range, ENoiseType _type, [Optional] GameObject _source)
		{
		}

		// Token: 0x04001532 RID: 5426
		[Token(Token = "0x4001532")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 origin;

		// Token: 0x04001533 RID: 5427
		[Token(Token = "0x4001533")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float range;

		// Token: 0x04001534 RID: 5428
		[Token(Token = "0x4001534")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ENoiseType type;

		// Token: 0x04001535 RID: 5429
		[Token(Token = "0x4001535")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject source;
	}
}
