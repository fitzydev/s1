using System;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000353 RID: 851
	[Token(Token = "0x2000353")]
	public class TaskManager : Singleton<TaskManager>
	{
		// Token: 0x060012CE RID: 4814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012CE")]
		[Address(RVA = "0x5A34A0", Offset = "0x5A1EA0", VA = "0x1805A34A0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012CF")]
		[Address(RVA = "0x5A3550", Offset = "0x5A1F50", VA = "0x1805A3550", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012D0")]
		[Address(RVA = "0x5A3370", Offset = "0x5A1D70", VA = "0x1805A3370")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012D1")]
		[Address(RVA = "0x5A3400", Offset = "0x5A1E00", VA = "0x1805A3400", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012D2")]
		[Address(RVA = "0x5A33E0", Offset = "0x5A1DE0", VA = "0x1805A33E0", Slot = "9")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012D3")]
		[Address(RVA = "0x5A3420", Offset = "0x5A1E20", VA = "0x1805A3420")]
		public void PlayTaskCompleteSound()
		{
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012D4")]
		[Address(RVA = "0x5A3450", Offset = "0x5A1E50", VA = "0x1805A3450")]
		public void StartTask(Task task)
		{
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012D5")]
		[Address(RVA = "0x5A3570", Offset = "0x5A1F70", VA = "0x1805A3570")]
		public TaskManager()
		{
		}

		// Token: 0x04001203 RID: 4611
		[Token(Token = "0x4001203")]
		[FieldOffset(Offset = "0x28")]
		public Task currentTask;

		// Token: 0x04001204 RID: 4612
		[Token(Token = "0x4001204")]
		[FieldOffset(Offset = "0x30")]
		public AudioSourceController TaskCompleteSound;

		// Token: 0x04001205 RID: 4613
		[Token(Token = "0x4001205")]
		[FieldOffset(Offset = "0x38")]
		public Action<Task> OnTaskStarted;
	}
}
