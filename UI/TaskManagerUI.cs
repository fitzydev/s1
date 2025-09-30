using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000B07 RID: 2823
	[Token(Token = "0x2000B07")]
	public class TaskManagerUI : Singleton<TaskManagerUI>
	{
		// Token: 0x06004CB6 RID: 19638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CB6")]
		[Address(RVA = "0x9371D0", Offset = "0x935BD0", VA = "0x1809371D0", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x06004CB7 RID: 19639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CB7")]
		[Address(RVA = "0x936CE0", Offset = "0x9356E0", VA = "0x180936CE0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06004CB8 RID: 19640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CB8")]
		[Address(RVA = "0x937010", Offset = "0x935A10", VA = "0x180937010", Slot = "8")]
		protected virtual void UpdateInstructionLabel()
		{
		}

		// Token: 0x06004CB9 RID: 19641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CB9")]
		[Address(RVA = "0x936E70", Offset = "0x935870", VA = "0x180936E70")]
		private void TaskStarted(Task task)
		{
		}

		// Token: 0x06004CBA RID: 19642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CBA")]
		[Address(RVA = "0x937280", Offset = "0x935C80", VA = "0x180937280")]
		public TaskManagerUI()
		{
		}

		// Token: 0x0400378B RID: 14219
		[Token(Token = "0x400378B")]
		[FieldOffset(Offset = "0x28")]
		private bool textShown;

		// Token: 0x0400378C RID: 14220
		[Token(Token = "0x400378C")]
		[FieldOffset(Offset = "0x30")]
		public GenericUIScreen inputPromptUI;

		// Token: 0x0400378D RID: 14221
		[Token(Token = "0x400378D")]
		[FieldOffset(Offset = "0x38")]
		public Canvas canvas;

		// Token: 0x0400378E RID: 14222
		[Token(Token = "0x400378E")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform multiGrabIndicator;

		// Token: 0x0400378F RID: 14223
		[Token(Token = "0x400378F")]
		[FieldOffset(Offset = "0x48")]
		public GenericUIScreen PackagingStationMK2TutorialDone;
	}
}
