using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Product;

namespace ScheduleOne.Properties
{
	// Token: 0x02000339 RID: 825
	[Token(Token = "0x2000339")]
	public static class PropertyMixCalculator
	{
		// Token: 0x06001241 RID: 4673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001241")]
		[Address(RVA = "0x59BF50", Offset = "0x59A950", VA = "0x18059BF50")]
		public static List<Property> MixProperties(List<Property> existingProperties, Property newProperty, EDrugType drugType)
		{
			return null;
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001242")]
		public static void Shuffle<T>(List<T> list, int seed)
		{
		}

		// Token: 0x04001169 RID: 4457
		[Token(Token = "0x4001169")]
		public const int MAX_PROPERTIES = 8;

		// Token: 0x0400116A RID: 4458
		[Token(Token = "0x400116A")]
		public const float MAX_DELTA_DIFFERENCE = 0.5f;

		// Token: 0x0200033A RID: 826
		[Token(Token = "0x200033A")]
		private class Reaction
		{
			// Token: 0x06001243 RID: 4675 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001243")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public Reaction()
			{
			}

			// Token: 0x0400116B RID: 4459
			[Token(Token = "0x400116B")]
			[FieldOffset(Offset = "0x10")]
			public Property Existing;

			// Token: 0x0400116C RID: 4460
			[Token(Token = "0x400116C")]
			[FieldOffset(Offset = "0x18")]
			public Property Output;
		}
	}
}
