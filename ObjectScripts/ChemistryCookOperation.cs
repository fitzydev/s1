using System;
using FishNet.Serializing.Helping;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.StationFramework;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000C9E RID: 3230
	[Token(Token = "0x2000C9E")]
	public class ChemistryCookOperation
	{
		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x06005899 RID: 22681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C46")]
		[CodegenExclude]
		public StationRecipe Recipe
		{
			[Token(Token = "0x6005899")]
			[Address(RVA = "0xA14CB0", Offset = "0xA136B0", VA = "0x180A14CB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600589A RID: 22682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600589A")]
		[Address(RVA = "0xA14C30", Offset = "0xA13630", VA = "0x180A14C30")]
		public ChemistryCookOperation(StationRecipe recipe, EQuality productQuality, Color startLiquidColor, float liquidLevel, int currentTime = 0)
		{
		}

		// Token: 0x0600589B RID: 22683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600589B")]
		[Address(RVA = "0xA14BC0", Offset = "0xA135C0", VA = "0x180A14BC0")]
		public ChemistryCookOperation(string recipeID, EQuality productQuality, Color startLiquidColor, float liquidLevel, int currentTime = 0)
		{
		}

		// Token: 0x0600589C RID: 22684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600589C")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public ChemistryCookOperation()
		{
		}

		// Token: 0x0600589D RID: 22685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600589D")]
		[Address(RVA = "0xA14B60", Offset = "0xA13560", VA = "0x180A14B60")]
		public void Progress(int mins)
		{
		}

		// Token: 0x0400414A RID: 16714
		[Token(Token = "0x400414A")]
		[FieldOffset(Offset = "0x10")]
		[CodegenExclude]
		private StationRecipe recipe;

		// Token: 0x0400414B RID: 16715
		[Token(Token = "0x400414B")]
		[FieldOffset(Offset = "0x18")]
		public string RecipeID;

		// Token: 0x0400414C RID: 16716
		[Token(Token = "0x400414C")]
		[FieldOffset(Offset = "0x20")]
		public EQuality ProductQuality;

		// Token: 0x0400414D RID: 16717
		[Token(Token = "0x400414D")]
		[FieldOffset(Offset = "0x24")]
		public Color StartLiquidColor;

		// Token: 0x0400414E RID: 16718
		[Token(Token = "0x400414E")]
		[FieldOffset(Offset = "0x34")]
		public float LiquidLevel;

		// Token: 0x0400414F RID: 16719
		[Token(Token = "0x400414F")]
		[FieldOffset(Offset = "0x38")]
		public int CurrentTime;
	}
}
