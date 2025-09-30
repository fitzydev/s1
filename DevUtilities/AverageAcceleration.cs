using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000747 RID: 1863
	[Token(Token = "0x2000747")]
	public class AverageAcceleration : MonoBehaviour
	{
		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06003289 RID: 12937 RVA: 0x0000DED8 File Offset: 0x0000C0D8
		// (set) Token: 0x0600328A RID: 12938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000750")]
		public Vector3 Acceleration
		{
			[Token(Token = "0x6003289")]
			[Address(RVA = "0x4FE8A0", Offset = "0x4FD2A0", VA = "0x1804FE8A0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600328A")]
			[Address(RVA = "0x4FE9A0", Offset = "0x4FD3A0", VA = "0x1804FE9A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600328B RID: 12939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600328B")]
		[Address(RVA = "0x774A20", Offset = "0x773420", VA = "0x180774A20")]
		private void Start()
		{
		}

		// Token: 0x0600328C RID: 12940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600328C")]
		[Address(RVA = "0x774780", Offset = "0x773180", VA = "0x180774780")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600328D RID: 12941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600328D")]
		[Address(RVA = "0x774BF0", Offset = "0x7735F0", VA = "0x180774BF0")]
		public AverageAcceleration()
		{
		}

		// Token: 0x040022F4 RID: 8948
		[Token(Token = "0x40022F4")]
		[FieldOffset(Offset = "0x30")]
		public Rigidbody Rb;

		// Token: 0x040022F5 RID: 8949
		[Token(Token = "0x40022F5")]
		[FieldOffset(Offset = "0x38")]
		public float TimeWindow;

		// Token: 0x040022F6 RID: 8950
		[Token(Token = "0x40022F6")]
		[FieldOffset(Offset = "0x40")]
		private Vector3[] accelerations;

		// Token: 0x040022F7 RID: 8951
		[Token(Token = "0x40022F7")]
		[FieldOffset(Offset = "0x48")]
		private int currentIndex;

		// Token: 0x040022F8 RID: 8952
		[Token(Token = "0x40022F8")]
		[FieldOffset(Offset = "0x4C")]
		private float timer;

		// Token: 0x040022F9 RID: 8953
		[Token(Token = "0x40022F9")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 prevVelocity;
	}
}
