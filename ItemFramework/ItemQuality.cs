using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x020009FD RID: 2557
	[Token(Token = "0x20009FD")]
	public static class ItemQuality
	{
		// Token: 0x060045BE RID: 17854 RVA: 0x000125B8 File Offset: 0x000107B8
		[Token(Token = "0x60045BE")]
		[Address(RVA = "0x8C1BF0", Offset = "0x8C05F0", VA = "0x1808C1BF0")]
		public static EQuality GetQuality(float qualityScalar)
		{
			return EQuality.Trash;
		}

		// Token: 0x060045BF RID: 17855 RVA: 0x000125D0 File Offset: 0x000107D0
		[Token(Token = "0x60045BF")]
		[Address(RVA = "0x8C1A20", Offset = "0x8C0420", VA = "0x1808C1A20")]
		public static Color GetColor(EQuality quality)
		{
			return default(Color);
		}

		// Token: 0x040030E8 RID: 12520
		[Token(Token = "0x40030E8")]
		public const float Heavenly_Threshold = 0.9f;

		// Token: 0x040030E9 RID: 12521
		[Token(Token = "0x40030E9")]
		public const float Premium_Threshold = 0.75f;

		// Token: 0x040030EA RID: 12522
		[Token(Token = "0x40030EA")]
		public const float Standard_Threshold = 0.4f;

		// Token: 0x040030EB RID: 12523
		[Token(Token = "0x40030EB")]
		public const float Poor_Threshold = 0.25f;

		// Token: 0x040030EC RID: 12524
		[Token(Token = "0x40030EC")]
		[FieldOffset(Offset = "0x0")]
		public static Color Heavenly_Color;

		// Token: 0x040030ED RID: 12525
		[Token(Token = "0x40030ED")]
		[FieldOffset(Offset = "0x10")]
		public static Color Premium_Color;

		// Token: 0x040030EE RID: 12526
		[Token(Token = "0x40030EE")]
		[FieldOffset(Offset = "0x20")]
		public static Color Standard_Color;

		// Token: 0x040030EF RID: 12527
		[Token(Token = "0x40030EF")]
		[FieldOffset(Offset = "0x30")]
		public static Color Poor_Color;

		// Token: 0x040030F0 RID: 12528
		[Token(Token = "0x40030F0")]
		[FieldOffset(Offset = "0x40")]
		public static Color Trash_Color;
	}
}
