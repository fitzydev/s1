using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts;
using ScheduleOne.StationFramework;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000355 RID: 853
	[Token(Token = "0x2000355")]
	public class CauldronTask : Task
	{
		// Token: 0x17000394 RID: 916
		// (get) Token: 0x060012DB RID: 4827 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060012DC RID: 4828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000394")]
		public Cauldron Cauldron
		{
			[Token(Token = "0x60012DB")]
			[Address(RVA = "0x5904C0", Offset = "0x58EEC0", VA = "0x1805904C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60012DC")]
			[Address(RVA = "0x5904E0", Offset = "0x58EEE0", VA = "0x1805904E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x060012DD RID: 4829 RVA: 0x00008010 File Offset: 0x00006210
		// (set) Token: 0x060012DE RID: 4830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000395")]
		public CauldronTask.EStep CurrentStep
		{
			[Token(Token = "0x60012DD")]
			[Address(RVA = "0x5904D0", Offset = "0x58EED0", VA = "0x1805904D0")]
			[CompilerGenerated]
			get
			{
				return CauldronTask.EStep.CombineIngredients;
			}
			[Token(Token = "0x60012DE")]
			[Address(RVA = "0x590500", Offset = "0x58EF00", VA = "0x180590500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012DF")]
		[Address(RVA = "0x58F060", Offset = "0x58DA60", VA = "0x18058F060")]
		public static string GetStepDescription(CauldronTask.EStep step)
		{
			return null;
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012E0")]
		[Address(RVA = "0x58FB20", Offset = "0x58E520", VA = "0x18058FB20")]
		public CauldronTask(Cauldron caudron)
		{
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012E1")]
		[Address(RVA = "0x58F770", Offset = "0x58E170", VA = "0x18058F770", Slot = "7")]
		public override void Success()
		{
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012E2")]
		[Address(RVA = "0x58F450", Offset = "0x58DE50", VA = "0x18058F450", Slot = "6")]
		public override void StopTask()
		{
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012E3")]
		[Address(RVA = "0x58F940", Offset = "0x58E340", VA = "0x18058F940", Slot = "9")]
		public override void Update()
		{
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012E4")]
		[Address(RVA = "0x58EDB0", Offset = "0x58D7B0", VA = "0x18058EDB0")]
		private void CheckProgress()
		{
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012E5")]
		[Address(RVA = "0x58EF10", Offset = "0x58D910", VA = "0x18058EF10")]
		private void CheckStep_CombineIngredients()
		{
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012E6")]
		[Address(RVA = "0x58F0F0", Offset = "0x58DAF0", VA = "0x18058F0F0")]
		private void StartMixing()
		{
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012E7")]
		[Address(RVA = "0x58F8C0", Offset = "0x58E2C0", VA = "0x18058F8C0")]
		private void UpdateInstruction()
		{
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012E8")]
		[Address(RVA = "0x58F0D0", Offset = "0x58DAD0", VA = "0x18058F0D0")]
		private void StartButtonPressed()
		{
		}

		// Token: 0x04001209 RID: 4617
		[Token(Token = "0x4001209")]
		[FieldOffset(Offset = "0xA8")]
		private StationItem[] CocaLeaves;

		// Token: 0x0400120A RID: 4618
		[Token(Token = "0x400120A")]
		[FieldOffset(Offset = "0xB0")]
		private StationItem Gasoline;

		// Token: 0x0400120B RID: 4619
		[Token(Token = "0x400120B")]
		[FieldOffset(Offset = "0xB8")]
		private Draggable Tub;

		// Token: 0x02000356 RID: 854
		[Token(Token = "0x2000356")]
		public enum EStep
		{
			// Token: 0x0400120D RID: 4621
			[Token(Token = "0x400120D")]
			CombineIngredients,
			// Token: 0x0400120E RID: 4622
			[Token(Token = "0x400120E")]
			StartMixing
		}
	}
}
