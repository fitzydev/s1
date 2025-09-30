using System;
using Il2CppDummyDll;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000C88 RID: 3208
	[Token(Token = "0x2000C88")]
	public class CocaineVisuals : MonoBehaviour
	{
		// Token: 0x0600574B RID: 22347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600574B")]
		[Address(RVA = "0xA1D100", Offset = "0xA1BB00", VA = "0x180A1D100")]
		public void Setup(CocaineDefinition definition)
		{
		}

		// Token: 0x0600574C RID: 22348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600574C")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public CocaineVisuals()
		{
		}

		// Token: 0x04004095 RID: 16533
		[Token(Token = "0x4004095")]
		[FieldOffset(Offset = "0x20")]
		public MeshRenderer[] Meshes;
	}
}
