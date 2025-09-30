using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.StationFramework;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x0200035D RID: 861
	[Token(Token = "0x200035D")]
	public class LabOvenSolidTask : Task
	{
		// Token: 0x1700039D RID: 925
		// (get) Token: 0x0600130E RID: 4878 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600130F RID: 4879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700039D")]
		public LabOven Oven
		{
			[Token(Token = "0x600130E")]
			[Address(RVA = "0x5904C0", Offset = "0x58EEC0", VA = "0x1805904C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600130F")]
			[Address(RVA = "0x5904E0", Offset = "0x58EEE0", VA = "0x1805904E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06001310 RID: 4880 RVA: 0x00008058 File Offset: 0x00006258
		// (set) Token: 0x06001311 RID: 4881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700039E")]
		public LabOvenSolidTask.EStep CurrentStep
		{
			[Token(Token = "0x6001310")]
			[Address(RVA = "0x5904D0", Offset = "0x58EED0", VA = "0x1805904D0")]
			[CompilerGenerated]
			get
			{
				return LabOvenSolidTask.EStep.OpenDoor;
			}
			[Token(Token = "0x6001311")]
			[Address(RVA = "0x590500", Offset = "0x58EF00", VA = "0x180590500")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001312")]
		[Address(RVA = "0x597E70", Offset = "0x596870", VA = "0x180597E70")]
		public LabOvenSolidTask(LabOven oven)
		{
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001313")]
		[Address(RVA = "0x597DA0", Offset = "0x5967A0", VA = "0x180597DA0", Slot = "9")]
		public override void Update()
		{
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001314")]
		[Address(RVA = "0x597B70", Offset = "0x596570", VA = "0x180597B70", Slot = "7")]
		public override void Success()
		{
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001315")]
		[Address(RVA = "0x5977B0", Offset = "0x5961B0", VA = "0x1805977B0", Slot = "6")]
		public override void StopTask()
		{
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001316")]
		[Address(RVA = "0x596E30", Offset = "0x595830", VA = "0x180596E30")]
		private void CheckProgress()
		{
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001317")]
		[Address(RVA = "0x597580", Offset = "0x595F80", VA = "0x180597580")]
		private void ProgressStep()
		{
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001318")]
		[Address(RVA = "0x597220", Offset = "0x595C20", VA = "0x180597220")]
		private void CheckStep_OpenDoor()
		{
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001319")]
		[Address(RVA = "0x5972C0", Offset = "0x595CC0", VA = "0x1805972C0")]
		private void CheckStep_PlaceItems()
		{
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600131A")]
		[Address(RVA = "0x597190", Offset = "0x595B90", VA = "0x180597190")]
		private void CheckStep_CloseDoor()
		{
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600131B")]
		[Address(RVA = "0x597480", Offset = "0x595E80", VA = "0x180597480")]
		private void CheckStep_PressButton()
		{
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600131C")]
		[Address(RVA = "0x5974C0", Offset = "0x595EC0", VA = "0x1805974C0")]
		public static string GetStepInstruction(LabOvenSolidTask.EStep step)
		{
			return null;
		}

		// Token: 0x0400122D RID: 4653
		[Token(Token = "0x400122D")]
		[FieldOffset(Offset = "0xA8")]
		private ItemInstance ingredient;

		// Token: 0x0400122E RID: 4654
		[Token(Token = "0x400122E")]
		[FieldOffset(Offset = "0xB0")]
		private int ingredientQuantity;

		// Token: 0x0400122F RID: 4655
		[Token(Token = "0x400122F")]
		[FieldOffset(Offset = "0xB8")]
		private StationItem[] stationItems;

		// Token: 0x04001230 RID: 4656
		[Token(Token = "0x4001230")]
		[FieldOffset(Offset = "0xC0")]
		private Draggable[] stationDraggables;

		// Token: 0x0200035E RID: 862
		[Token(Token = "0x200035E")]
		public enum EStep
		{
			// Token: 0x04001232 RID: 4658
			[Token(Token = "0x4001232")]
			OpenDoor,
			// Token: 0x04001233 RID: 4659
			[Token(Token = "0x4001233")]
			PlaceItems,
			// Token: 0x04001234 RID: 4660
			[Token(Token = "0x4001234")]
			CloseDoor,
			// Token: 0x04001235 RID: 4661
			[Token(Token = "0x4001235")]
			PressButton
		}
	}
}
