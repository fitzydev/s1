using System;
using EasyButtons;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000CE6 RID: 3302
	[Token(Token = "0x2000CE6")]
	public class Grave : MonoBehaviour
	{
		// Token: 0x06005D8D RID: 23949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D8D")]
		[Address(RVA = "0xA5C9D0", Offset = "0xA5B3D0", VA = "0x180A5C9D0")]
		[Button]
		public void RandomizeGrave()
		{
		}

		// Token: 0x06005D8E RID: 23950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D8E")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public Grave()
		{
		}

		// Token: 0x040043EF RID: 17391
		[Token(Token = "0x40043EF")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public Grave.GraveSuface[] Surfaces;

		// Token: 0x040043F0 RID: 17392
		[Token(Token = "0x40043F0")]
		[FieldOffset(Offset = "0x28")]
		public GameObject[] HeadstoneObjects;

		// Token: 0x040043F1 RID: 17393
		[Token(Token = "0x40043F1")]
		[FieldOffset(Offset = "0x30")]
		public MeshRenderer[] HeadstoneMeshes;

		// Token: 0x040043F2 RID: 17394
		[Token(Token = "0x40043F2")]
		[FieldOffset(Offset = "0x38")]
		public Material[] HeadstoneMaterials;

		// Token: 0x02000CE7 RID: 3303
		[Token(Token = "0x2000CE7")]
		[Serializable]
		public class GraveSuface
		{
			// Token: 0x06005D8F RID: 23951 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005D8F")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public GraveSuface()
			{
			}

			// Token: 0x040043F3 RID: 17395
			[Token(Token = "0x40043F3")]
			[FieldOffset(Offset = "0x10")]
			public GameObject Object;

			// Token: 0x040043F4 RID: 17396
			[Token(Token = "0x40043F4")]
			[FieldOffset(Offset = "0x18")]
			public MeshRenderer Mesh;

			// Token: 0x040043F5 RID: 17397
			[Token(Token = "0x40043F5")]
			[FieldOffset(Offset = "0x20")]
			public Material[] Materials;
		}
	}
}
