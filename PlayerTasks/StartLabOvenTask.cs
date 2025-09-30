using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.StationFramework;
using UnityEngine;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000362 RID: 866
	[Token(Token = "0x2000362")]
	public class StartLabOvenTask : Task
	{
		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06001331 RID: 4913 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001332 RID: 4914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A2")]
		public LabOven Oven
		{
			[Token(Token = "0x6001331")]
			[Address(RVA = "0x5904C0", Offset = "0x58EEC0", VA = "0x1805904C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001332")]
			[Address(RVA = "0x5904E0", Offset = "0x58EEE0", VA = "0x1805904E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06001333 RID: 4915 RVA: 0x00008070 File Offset: 0x00006270
		// (set) Token: 0x06001334 RID: 4916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A3")]
		public StartLabOvenTask.EStep CurrentStep
		{
			[Token(Token = "0x6001333")]
			[Address(RVA = "0x5904D0", Offset = "0x58EED0", VA = "0x1805904D0")]
			[CompilerGenerated]
			get
			{
				return StartLabOvenTask.EStep.OpenDoor;
			}
			[Token(Token = "0x6001334")]
			[Address(RVA = "0x590500", Offset = "0x58EF00", VA = "0x180590500")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001335")]
		[Address(RVA = "0x5B8A10", Offset = "0x5B7410", VA = "0x1805B8A10")]
		public StartLabOvenTask(LabOven oven)
		{
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001336")]
		[Address(RVA = "0x5B87B0", Offset = "0x5B71B0", VA = "0x1805B87B0", Slot = "9")]
		public override void Update()
		{
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001337")]
		[Address(RVA = "0x5B8590", Offset = "0x5B6F90", VA = "0x1805B8590", Slot = "7")]
		public override void Success()
		{
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001338")]
		[Address(RVA = "0x5B81D0", Offset = "0x5B6BD0", VA = "0x1805B81D0", Slot = "6")]
		public override void StopTask()
		{
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001339")]
		[Address(RVA = "0x5B7BF0", Offset = "0x5B65F0", VA = "0x1805B7BF0")]
		private void CheckProgress()
		{
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600133A")]
		[Address(RVA = "0x5B8050", Offset = "0x5B6A50", VA = "0x1805B8050")]
		private void ProgressStep()
		{
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600133B")]
		[Address(RVA = "0x5B7E20", Offset = "0x5B6820", VA = "0x1805B7E20")]
		private void CheckStep_OpenDoor()
		{
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600133C")]
		[Address(RVA = "0x5B7EC0", Offset = "0x5B68C0", VA = "0x1805B7EC0")]
		private void CheckStep_Pour()
		{
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600133D")]
		[Address(RVA = "0x5B7D90", Offset = "0x5B6790", VA = "0x1805B7D90")]
		private void CheckStep_CloseDoor()
		{
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600133E")]
		[Address(RVA = "0x5B7EE0", Offset = "0x5B68E0", VA = "0x1805B7EE0")]
		private void CheckStep_PressButton()
		{
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600133F")]
		[Address(RVA = "0x5B7FE0", Offset = "0x5B69E0", VA = "0x1805B7FE0")]
		private IEnumerator PlayPourAnimation()
		{
			return null;
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001340")]
		[Address(RVA = "0x5B7F20", Offset = "0x5B6920", VA = "0x1805B7F20")]
		public static string GetStepInstruction(StartLabOvenTask.EStep step)
		{
			return null;
		}

		// Token: 0x04001249 RID: 4681
		[Token(Token = "0x4001249")]
		[FieldOffset(Offset = "0xA8")]
		private ItemInstance ingredient;

		// Token: 0x0400124A RID: 4682
		[Token(Token = "0x400124A")]
		[FieldOffset(Offset = "0xB0")]
		private Coroutine pourRoutine;

		// Token: 0x0400124B RID: 4683
		[Token(Token = "0x400124B")]
		[FieldOffset(Offset = "0xB8")]
		private StationItem stationItem;

		// Token: 0x0400124C RID: 4684
		[Token(Token = "0x400124C")]
		[FieldOffset(Offset = "0xC0")]
		private PourableModule pourableModule;

		// Token: 0x0400124D RID: 4685
		[Token(Token = "0x400124D")]
		[FieldOffset(Offset = "0xC8")]
		private bool pourAnimDone;

		// Token: 0x02000363 RID: 867
		[Token(Token = "0x2000363")]
		public enum EStep
		{
			// Token: 0x0400124F RID: 4687
			[Token(Token = "0x400124F")]
			OpenDoor,
			// Token: 0x04001250 RID: 4688
			[Token(Token = "0x4001250")]
			Pour,
			// Token: 0x04001251 RID: 4689
			[Token(Token = "0x4001251")]
			CloseDoor,
			// Token: 0x04001252 RID: 4690
			[Token(Token = "0x4001252")]
			PressButton
		}
	}
}
