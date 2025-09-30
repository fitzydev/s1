using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Vision
{
	// Token: 0x0200037C RID: 892
	[Token(Token = "0x200037C")]
	[Serializable]
	public class VisibilityAttribute
	{
		// Token: 0x060013DF RID: 5087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013DF")]
		[Address(RVA = "0x5BF470", Offset = "0x5BDE70", VA = "0x1805BF470")]
		public VisibilityAttribute(string _name, float _pointsChange, float _multiplier = 1f, int attributeIndex = -1)
		{
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013E0")]
		[Address(RVA = "0x5BF3D0", Offset = "0x5BDDD0", VA = "0x1805BF3D0")]
		public void Delete()
		{
		}

		// Token: 0x040012C1 RID: 4801
		[Token(Token = "0x40012C1")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x040012C2 RID: 4802
		[Token(Token = "0x40012C2")]
		[FieldOffset(Offset = "0x18")]
		public float pointsChange;

		// Token: 0x040012C3 RID: 4803
		[Token(Token = "0x40012C3")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0f, 5f)]
		public float multiplier;
	}
}
