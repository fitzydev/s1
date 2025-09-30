using System;
using Il2CppDummyDll;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000C89 RID: 3209
	[Token(Token = "0x2000C89")]
	public class MethVisuals : MonoBehaviour
	{
		// Token: 0x0600574D RID: 22349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600574D")]
		[Address(RVA = "0xA1D100", Offset = "0xA1BB00", VA = "0x180A1D100")]
		public void Setup(MethDefinition definition)
		{
		}

		// Token: 0x0600574E RID: 22350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600574E")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public MethVisuals()
		{
		}

		// Token: 0x04004096 RID: 16534
		[Token(Token = "0x4004096")]
		[FieldOffset(Offset = "0x20")]
		public MeshRenderer[] Meshes;
	}
}
