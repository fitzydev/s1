using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EasyButtons;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Misc
{
	// Token: 0x02000CE2 RID: 3298
	[Token(Token = "0x2000CE2")]
	public class UtilityPole : MonoBehaviour
	{
		// Token: 0x06005D7A RID: 23930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D7A")]
		[Address(RVA = "0xA6C280", Offset = "0xA6AC80", VA = "0x180A6C280")]
		private void Awake()
		{
		}

		// Token: 0x06005D7B RID: 23931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D7B")]
		[Address(RVA = "0xA6CE50", Offset = "0xA6B850", VA = "0x180A6CE50")]
		private void Start()
		{
		}

		// Token: 0x06005D7C RID: 23932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D7C")]
		[Address(RVA = "0xA6D1A0", Offset = "0xA6BBA0", VA = "0x180A6D1A0")]
		private void UpdateCulling()
		{
		}

		// Token: 0x06005D7D RID: 23933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D7D")]
		[Address(RVA = "0xA6C9B0", Offset = "0xA6B3B0", VA = "0x180A6C9B0")]
		[Button]
		public void Orient()
		{
		}

		// Token: 0x06005D7E RID: 23934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D7E")]
		[Address(RVA = "0xA6C400", Offset = "0xA6AE00", VA = "0x180A6C400")]
		[Button]
		public void DrawLines()
		{
		}

		// Token: 0x06005D7F RID: 23935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D7F")]
		[Address(RVA = "0xA6D5B0", Offset = "0xA6BFB0", VA = "0x180A6D5B0")]
		public UtilityPole()
		{
		}

		// Token: 0x06005D80 RID: 23936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D80")]
		[Address(RVA = "0xA6CFC0", Offset = "0xA6B9C0", VA = "0x180A6CFC0")]
		[CompilerGenerated]
		private void <Start>g__Register|17_0()
		{
		}

		// Token: 0x040043D0 RID: 17360
		[Token(Token = "0x40043D0")]
		public const float CABLE_CULL_DISTANCE = 100f;

		// Token: 0x040043D1 RID: 17361
		[Token(Token = "0x40043D1")]
		public const float CABLE_CULL_DISTANCE_SQR = 10000f;

		// Token: 0x040043D2 RID: 17362
		[Token(Token = "0x40043D2")]
		[FieldOffset(Offset = "0x20")]
		public UtilityPole previousPole;

		// Token: 0x040043D3 RID: 17363
		[Token(Token = "0x40043D3")]
		[FieldOffset(Offset = "0x28")]
		public UtilityPole nextPole;

		// Token: 0x040043D4 RID: 17364
		[Token(Token = "0x40043D4")]
		[FieldOffset(Offset = "0x30")]
		public bool Connection1Enabled;

		// Token: 0x040043D5 RID: 17365
		[Token(Token = "0x40043D5")]
		[FieldOffset(Offset = "0x31")]
		public bool Connection2Enabled;

		// Token: 0x040043D6 RID: 17366
		[Token(Token = "0x40043D6")]
		[FieldOffset(Offset = "0x34")]
		public float LengthFactor;

		// Token: 0x040043D7 RID: 17367
		[Token(Token = "0x40043D7")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public Transform cable1Connection;

		// Token: 0x040043D8 RID: 17368
		[Token(Token = "0x40043D8")]
		[FieldOffset(Offset = "0x40")]
		public Transform cable2Connection;

		// Token: 0x040043D9 RID: 17369
		[Token(Token = "0x40043D9")]
		[FieldOffset(Offset = "0x48")]
		public List<Transform> cable1Segments;

		// Token: 0x040043DA RID: 17370
		[Token(Token = "0x40043DA")]
		[FieldOffset(Offset = "0x50")]
		public List<Transform> cable2Segments;

		// Token: 0x040043DB RID: 17371
		[Token(Token = "0x40043DB")]
		[FieldOffset(Offset = "0x58")]
		public Transform Cable1Container;

		// Token: 0x040043DC RID: 17372
		[Token(Token = "0x40043DC")]
		[FieldOffset(Offset = "0x60")]
		public Transform Cable2Container;

		// Token: 0x040043DD RID: 17373
		[Token(Token = "0x40043DD")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 cableStart;

		// Token: 0x040043DE RID: 17374
		[Token(Token = "0x40043DE")]
		[FieldOffset(Offset = "0x74")]
		private Vector3 cableEnd;

		// Token: 0x040043DF RID: 17375
		[Token(Token = "0x40043DF")]
		[FieldOffset(Offset = "0x80")]
		private Vector3 cableMid;
	}
}
