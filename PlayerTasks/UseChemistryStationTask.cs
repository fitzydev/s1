using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.StationFramework;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000369 RID: 873
	[Token(Token = "0x2000369")]
	public class UseChemistryStationTask : Task
	{
		// Token: 0x170003AB RID: 939
		// (get) Token: 0x0600135D RID: 4957 RVA: 0x000080D0 File Offset: 0x000062D0
		// (set) Token: 0x0600135E RID: 4958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003AB")]
		public ChemistryStation.EStep CurrentStep
		{
			[Token(Token = "0x600135D")]
			[Address(RVA = "0x48DB20", Offset = "0x48C520", VA = "0x18048DB20")]
			[CompilerGenerated]
			get
			{
				return ChemistryStation.EStep.CombineIngredients;
			}
			[Token(Token = "0x600135E")]
			[Address(RVA = "0x4DCAE0", Offset = "0x4DB4E0", VA = "0x1804DCAE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x0600135F RID: 4959 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001360 RID: 4960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003AC")]
		public ChemistryStation Station
		{
			[Token(Token = "0x600135F")]
			[Address(RVA = "0x4DBC30", Offset = "0x4DA630", VA = "0x1804DBC30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001360")]
			[Address(RVA = "0x4DC750", Offset = "0x4DB150", VA = "0x1804DC750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06001361 RID: 4961 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001362 RID: 4962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003AD")]
		public StationRecipe Recipe
		{
			[Token(Token = "0x6001361")]
			[Address(RVA = "0x4DBC40", Offset = "0x4DA640", VA = "0x1804DBC40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001362")]
			[Address(RVA = "0x4DC770", Offset = "0x4DB170", VA = "0x1804DC770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001363")]
		[Address(RVA = "0x5BB1B0", Offset = "0x5B9BB0", VA = "0x1805BB1B0")]
		public static string GetStepDescription(ChemistryStation.EStep step)
		{
			return null;
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001364")]
		[Address(RVA = "0x5BC1F0", Offset = "0x5BABF0", VA = "0x1805BC1F0")]
		public UseChemistryStationTask(ChemistryStation station, StationRecipe recipe)
		{
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001365")]
		[Address(RVA = "0x5BC1C0", Offset = "0x5BABC0", VA = "0x1805BC1C0", Slot = "9")]
		public override void Update()
		{
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001366")]
		[Address(RVA = "0x5BBF80", Offset = "0x5BA980", VA = "0x1805BBF80")]
		private void UpdateInstruction()
		{
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001367")]
		[Address(RVA = "0x5BA710", Offset = "0x5B9110", VA = "0x1805BA710")]
		private void CheckProgress()
		{
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001368")]
		[Address(RVA = "0x5BB2F0", Offset = "0x5B9CF0", VA = "0x1805BB2F0")]
		private void ProgressStep()
		{
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001369")]
		[Address(RVA = "0x5BA8B0", Offset = "0x5B92B0", VA = "0x1805BA8B0")]
		private void CheckStep_CombineIngredients()
		{
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600136A")]
		[Address(RVA = "0x5BAFC0", Offset = "0x5B99C0", VA = "0x1805BAFC0")]
		private void CheckStep_StirMixture()
		{
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600136B")]
		[Address(RVA = "0x5BAB20", Offset = "0x5B9520", VA = "0x1805BAB20")]
		private void CheckStep_LowerBoilingFlask()
		{
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600136C")]
		[Address(RVA = "0x5BABB0", Offset = "0x5B95B0", VA = "0x1805BABB0")]
		private void CheckStep_PourIntoBoilingFlask()
		{
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600136D")]
		[Address(RVA = "0x5BAC40", Offset = "0x5B9640", VA = "0x1805BAC40")]
		private void CheckStep_RaiseBoilingFlask()
		{
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600136E")]
		[Address(RVA = "0x5BACD0", Offset = "0x5B96D0", VA = "0x1805BACD0")]
		private void CheckStep_StartHeat()
		{
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600136F")]
		[Address(RVA = "0x5BBCF0", Offset = "0x5BA6F0", VA = "0x1805BBCF0", Slot = "7")]
		public override void Success()
		{
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001370")]
		[Address(RVA = "0x5BB7C0", Offset = "0x5BA1C0", VA = "0x1805BB7C0", Slot = "6")]
		public override void StopTask()
		{
		}

		// Token: 0x04001269 RID: 4713
		[Token(Token = "0x4001269")]
		public const float STIR_TIME = 1.5f;

		// Token: 0x0400126A RID: 4714
		[Token(Token = "0x400126A")]
		public const float TEMPERATURE_TIME = 2f;

		// Token: 0x0400126E RID: 4718
		[Token(Token = "0x400126E")]
		[FieldOffset(Offset = "0xB0")]
		private Beaker beaker;

		// Token: 0x0400126F RID: 4719
		[Token(Token = "0x400126F")]
		[FieldOffset(Offset = "0xB8")]
		private StirringRod stirringRod;

		// Token: 0x04001270 RID: 4720
		[Token(Token = "0x4001270")]
		[FieldOffset(Offset = "0xC0")]
		private List<StationItem> items;

		// Token: 0x04001271 RID: 4721
		[Token(Token = "0x4001271")]
		[FieldOffset(Offset = "0xC8")]
		private List<IngredientPiece> ingredientPieces;

		// Token: 0x04001272 RID: 4722
		[Token(Token = "0x4001272")]
		[FieldOffset(Offset = "0xD0")]
		private float stirProgress;

		// Token: 0x04001273 RID: 4723
		[Token(Token = "0x4001273")]
		[FieldOffset(Offset = "0xD4")]
		private float timeInTemperatureRange;

		// Token: 0x04001274 RID: 4724
		[Token(Token = "0x4001274")]
		[FieldOffset(Offset = "0xD8")]
		private ItemInstance[] RemovedIngredients;
	}
}
