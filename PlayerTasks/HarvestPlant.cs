using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Growing;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x0200035C RID: 860
	[Token(Token = "0x200035C")]
	public class HarvestPlant : Task
	{
		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06001306 RID: 4870 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001307 RID: 4871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700039C")]
		public override string TaskName
		{
			[Token(Token = "0x6001306")]
			[Address(RVA = "0x5904C0", Offset = "0x58EEC0", VA = "0x1805904C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001307")]
			[Address(RVA = "0x5904E0", Offset = "0x58EEE0", VA = "0x1805904E0", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001308")]
		[Address(RVA = "0x5963E0", Offset = "0x594DE0", VA = "0x1805963E0")]
		public HarvestPlant(Pot _pot, bool canDrag, AudioSourceController soundLoopPrefab)
		{
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001309")]
		[Address(RVA = "0x595B10", Offset = "0x594510", VA = "0x180595B10")]
		private void UpdateInstructionText()
		{
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600130A")]
		[Address(RVA = "0x5955E0", Offset = "0x593FE0", VA = "0x1805955E0", Slot = "6")]
		public override void StopTask()
		{
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600130B")]
		[Address(RVA = "0x595A00", Offset = "0x594400", VA = "0x180595A00", Slot = "10")]
		protected override void UpdateCursor()
		{
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600130C")]
		[Address(RVA = "0x595D80", Offset = "0x594780", VA = "0x180595D80", Slot = "9")]
		public override void Update()
		{
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600130D")]
		[Address(RVA = "0x595480", Offset = "0x593E80", VA = "0x180595480")]
		private PlantHarvestable GetHoveredHarvestable()
		{
			return null;
		}

		// Token: 0x04001224 RID: 4644
		[Token(Token = "0x4001224")]
		[FieldOffset(Offset = "0xA0")]
		protected Pot pot;

		// Token: 0x04001225 RID: 4645
		[Token(Token = "0x4001225")]
		[FieldOffset(Offset = "0xA8")]
		private int HarvestCount;

		// Token: 0x04001226 RID: 4646
		[Token(Token = "0x4001226")]
		[FieldOffset(Offset = "0xAC")]
		private int HarvestTotal;

		// Token: 0x04001227 RID: 4647
		[Token(Token = "0x4001227")]
		[FieldOffset(Offset = "0xB0")]
		private float rotation;

		// Token: 0x04001228 RID: 4648
		[Token(Token = "0x4001228")]
		[FieldOffset(Offset = "0x0")]
		private static bool hintShown;

		// Token: 0x04001229 RID: 4649
		[Token(Token = "0x4001229")]
		[FieldOffset(Offset = "0x1")]
		private static bool CanDrag;

		// Token: 0x0400122A RID: 4650
		[Token(Token = "0x400122A")]
		[FieldOffset(Offset = "0xB8")]
		private AudioSourceController SoundLoop;
	}
}
