using System;
using EasyButtons;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000919 RID: 2329
	[Token(Token = "0x2000919")]
	public class RoadCracksRandomizer : MonoBehaviour
	{
		// Token: 0x06003FFB RID: 16379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FFB")]
		[Address(RVA = "0x873A50", Offset = "0x872450", VA = "0x180873A50")]
		[Button]
		private void Randomize()
		{
		}

		// Token: 0x06003FFC RID: 16380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FFC")]
		[Address(RVA = "0x873BD0", Offset = "0x8725D0", VA = "0x180873BD0")]
		public RoadCracksRandomizer()
		{
		}

		// Token: 0x04002CD1 RID: 11473
		[Token(Token = "0x4002CD1")]
		[FieldOffset(Offset = "0x20")]
		public Transform[] Cracks;

		// Token: 0x04002CD2 RID: 11474
		[Token(Token = "0x4002CD2")]
		[FieldOffset(Offset = "0x28")]
		public int MinCount;

		// Token: 0x04002CD3 RID: 11475
		[Token(Token = "0x4002CD3")]
		[FieldOffset(Offset = "0x2C")]
		public int MaxCount;
	}
}
