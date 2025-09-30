using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Networking
{
	// Token: 0x020004A6 RID: 1190
	[Token(Token = "0x20004A6")]
	public class NetworkConditionalObject : MonoBehaviour
	{
		// Token: 0x0600174F RID: 5967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600174F")]
		[Address(RVA = "0x5F1260", Offset = "0x5EFC60", VA = "0x1805F1260")]
		private void Awake()
		{
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001750")]
		[Address(RVA = "0x5F1470", Offset = "0x5EFE70", VA = "0x1805F1470")]
		public void Check()
		{
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001751")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public NetworkConditionalObject()
		{
		}

		// Token: 0x0400154A RID: 5450
		[Token(Token = "0x400154A")]
		[FieldOffset(Offset = "0x20")]
		public NetworkConditionalObject.ECondition condition;

		// Token: 0x020004A7 RID: 1191
		[Token(Token = "0x20004A7")]
		public enum ECondition
		{
			// Token: 0x0400154C RID: 5452
			[Token(Token = "0x400154C")]
			All,
			// Token: 0x0400154D RID: 5453
			[Token(Token = "0x400154D")]
			HostOnly
		}
	}
}
