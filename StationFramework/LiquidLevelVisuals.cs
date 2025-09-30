using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	// Token: 0x02000973 RID: 2419
	[Token(Token = "0x2000973")]
	public class LiquidLevelVisuals : MonoBehaviour
	{
		// Token: 0x06004260 RID: 16992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004260")]
		[Address(RVA = "0x87D380", Offset = "0x87BD80", VA = "0x18087D380")]
		private void Update()
		{
		}

		// Token: 0x06004261 RID: 16993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004261")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public LiquidLevelVisuals()
		{
		}

		// Token: 0x04002E7E RID: 11902
		[Token(Token = "0x4002E7E")]
		[FieldOffset(Offset = "0x20")]
		public LiquidContainer Container;

		// Token: 0x04002E7F RID: 11903
		[Token(Token = "0x4002E7F")]
		[FieldOffset(Offset = "0x28")]
		public Transform LiquidSurface;

		// Token: 0x04002E80 RID: 11904
		[Token(Token = "0x4002E80")]
		[FieldOffset(Offset = "0x30")]
		public Transform LiquidSurface_Min;

		// Token: 0x04002E81 RID: 11905
		[Token(Token = "0x4002E81")]
		[FieldOffset(Offset = "0x38")]
		public Transform LiquidSurface_Max;
	}
}
