using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Clothing
{
	// Token: 0x020007C5 RID: 1989
	[Token(Token = "0x20007C5")]
	public static class ClothingColorExtensions
	{
		// Token: 0x0600359F RID: 13727 RVA: 0x0000EA48 File Offset: 0x0000CC48
		[Token(Token = "0x600359F")]
		[Address(RVA = "0x7CC4A0", Offset = "0x7CAEA0", VA = "0x1807CC4A0")]
		public static Color GetActualColor(this EClothingColor color)
		{
			return default(Color);
		}

		// Token: 0x060035A0 RID: 13728 RVA: 0x0000EA60 File Offset: 0x0000CC60
		[Token(Token = "0x60035A0")]
		[Address(RVA = "0x7CC8D0", Offset = "0x7CB2D0", VA = "0x1807CC8D0")]
		public static Color GetLabelColor(this EClothingColor color)
		{
			return default(Color);
		}

		// Token: 0x060035A1 RID: 13729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035A1")]
		[Address(RVA = "0x7CC970", Offset = "0x7CB370", VA = "0x1807CC970")]
		public static string GetLabel(this EClothingColor color)
		{
			return null;
		}

		// Token: 0x060035A2 RID: 13730 RVA: 0x0000EA78 File Offset: 0x0000CC78
		[Token(Token = "0x60035A2")]
		[Address(RVA = "0x7CC540", Offset = "0x7CAF40", VA = "0x1807CC540")]
		public static EClothingColor GetClothingColor(Color color)
		{
			return EClothingColor.White;
		}

		// Token: 0x060035A3 RID: 13731 RVA: 0x0000EA90 File Offset: 0x0000CC90
		[Token(Token = "0x60035A3")]
		[Address(RVA = "0x7CC430", Offset = "0x7CAE30", VA = "0x1807CC430")]
		public static bool ColorEquals(Color a, Color b, float tolerance = 0.004f)
		{
			return default(bool);
		}
	}
}
