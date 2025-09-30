using System;
using EasyButtons;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x0200091C RID: 2332
	[Token(Token = "0x200091C")]
	public class SetRendererMaterial : MonoBehaviour
	{
		// Token: 0x06004004 RID: 16388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004004")]
		[Address(RVA = "0x874010", Offset = "0x872A10", VA = "0x180874010")]
		[Button]
		public void SetMaterial()
		{
		}

		// Token: 0x06004005 RID: 16389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004005")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public SetRendererMaterial()
		{
		}

		// Token: 0x04002CDA RID: 11482
		[Token(Token = "0x4002CDA")]
		[FieldOffset(Offset = "0x20")]
		public Material Material;
	}
}
