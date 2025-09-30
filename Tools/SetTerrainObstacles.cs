using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x0200091D RID: 2333
	[Token(Token = "0x200091D")]
	public class SetTerrainObstacles : MonoBehaviour
	{
		// Token: 0x06004006 RID: 16390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004006")]
		[Address(RVA = "0x874170", Offset = "0x872B70", VA = "0x180874170")]
		private void Start()
		{
		}

		// Token: 0x06004007 RID: 16391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004007")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public SetTerrainObstacles()
		{
		}

		// Token: 0x04002CDB RID: 11483
		[Token(Token = "0x4002CDB")]
		[FieldOffset(Offset = "0x20")]
		public BoxCollider Bounds;

		// Token: 0x04002CDC RID: 11484
		[Token(Token = "0x4002CDC")]
		[FieldOffset(Offset = "0x28")]
		private TreeInstance[] Obstacle;

		// Token: 0x04002CDD RID: 11485
		[Token(Token = "0x4002CDD")]
		[FieldOffset(Offset = "0x30")]
		private Terrain terrain;

		// Token: 0x04002CDE RID: 11486
		[Token(Token = "0x4002CDE")]
		[FieldOffset(Offset = "0x38")]
		private float width;

		// Token: 0x04002CDF RID: 11487
		[Token(Token = "0x4002CDF")]
		[FieldOffset(Offset = "0x3C")]
		private float lenght;

		// Token: 0x04002CE0 RID: 11488
		[Token(Token = "0x4002CE0")]
		[FieldOffset(Offset = "0x40")]
		private float hight;

		// Token: 0x04002CE1 RID: 11489
		[Token(Token = "0x4002CE1")]
		[FieldOffset(Offset = "0x44")]
		private bool isError;
	}
}
