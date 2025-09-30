using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts.WateringCan;
using ScheduleOne.Property.Utilities.Water;
using UnityEngine;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000357 RID: 855
	[Token(Token = "0x2000357")]
	public class FillWateringCan : Task
	{
		// Token: 0x17000396 RID: 918
		// (get) Token: 0x060012E9 RID: 4841 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060012EA RID: 4842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000396")]
		public new string TaskName
		{
			[Token(Token = "0x60012E9")]
			[Address(RVA = "0x5904C0", Offset = "0x58EEC0", VA = "0x1805904C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60012EA")]
			[Address(RVA = "0x5904E0", Offset = "0x58EEE0", VA = "0x1805904E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012EB")]
		[Address(RVA = "0x593AA0", Offset = "0x5924A0", VA = "0x180593AA0")]
		public FillWateringCan(Tap _tap, WateringCanInstance _instance)
		{
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012EC")]
		[Address(RVA = "0x593750", Offset = "0x592150", VA = "0x180593750", Slot = "9")]
		public override void Update()
		{
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012ED")]
		[Address(RVA = "0x5934B0", Offset = "0x591EB0", VA = "0x1805934B0", Slot = "6")]
		public override void StopTask()
		{
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012EE")]
		[Address(RVA = "0x593480", Offset = "0x591E80", VA = "0x180593480")]
		private void HandleClickStart(RaycastHit hit)
		{
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012EF")]
		[Address(RVA = "0x593450", Offset = "0x591E50", VA = "0x180593450")]
		private void HandleClickEnd()
		{
		}

		// Token: 0x04001210 RID: 4624
		[Token(Token = "0x4001210")]
		[FieldOffset(Offset = "0xA0")]
		protected Tap tap;

		// Token: 0x04001211 RID: 4625
		[Token(Token = "0x4001211")]
		[FieldOffset(Offset = "0xA8")]
		protected WateringCanInstance instance;

		// Token: 0x04001212 RID: 4626
		[Token(Token = "0x4001212")]
		[FieldOffset(Offset = "0xB0")]
		protected WateringCanVisuals visuals;

		// Token: 0x04001213 RID: 4627
		[Token(Token = "0x4001213")]
		[FieldOffset(Offset = "0xB8")]
		private bool audioPlayed;
	}
}
