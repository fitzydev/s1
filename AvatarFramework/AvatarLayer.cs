using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x02000A0E RID: 2574
	[Token(Token = "0x2000A0E")]
	[CreateAssetMenu(fileName = "Avatar Layer", menuName = "ScriptableObjects/Avatar Layer", order = 1)]
	[Serializable]
	public class AvatarLayer : ScriptableObject
	{
		// Token: 0x0600469D RID: 18077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600469D")]
		[Address(RVA = "0x599570", Offset = "0x597F70", VA = "0x180599570")]
		public AvatarLayer()
		{
		}

		// Token: 0x0400317C RID: 12668
		[Token(Token = "0x400317C")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		// Token: 0x0400317D RID: 12669
		[Token(Token = "0x400317D")]
		[FieldOffset(Offset = "0x20")]
		public string AssetPath;

		// Token: 0x0400317E RID: 12670
		[Token(Token = "0x400317E")]
		[FieldOffset(Offset = "0x28")]
		public Texture2D Texture;

		// Token: 0x0400317F RID: 12671
		[Token(Token = "0x400317F")]
		[FieldOffset(Offset = "0x30")]
		public Texture2D Normal;

		// Token: 0x04003180 RID: 12672
		[Token(Token = "0x4003180")]
		[FieldOffset(Offset = "0x38")]
		public Texture2D Normal_DefaultFormat;

		// Token: 0x04003181 RID: 12673
		[Token(Token = "0x4003181")]
		[FieldOffset(Offset = "0x40")]
		public int Order;

		// Token: 0x04003182 RID: 12674
		[Token(Token = "0x4003182")]
		[FieldOffset(Offset = "0x48")]
		public Material CombinedMaterial;
	}
}
