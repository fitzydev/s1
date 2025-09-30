using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000D0A RID: 3338
	[Token(Token = "0x2000D0A")]
	public class ScheduledMaterialChange : MonoBehaviour
	{
		// Token: 0x06005E5A RID: 24154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E5A")]
		[Address(RVA = "0xA65AB0", Offset = "0xA644B0", VA = "0x180A65AB0", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x06005E5B RID: 24155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E5B")]
		[Address(RVA = "0xA65BF0", Offset = "0xA645F0", VA = "0x180A65BF0", Slot = "5")]
		protected virtual void Tick()
		{
		}

		// Token: 0x06005E5C RID: 24156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E5C")]
		[Address(RVA = "0xA65940", Offset = "0xA64340", VA = "0x180A65940")]
		private void SetMaterial(bool insideTimeRange)
		{
		}

		// Token: 0x06005E5D RID: 24157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E5D")]
		[Address(RVA = "0xA65D80", Offset = "0xA64780", VA = "0x180A65D80")]
		public ScheduledMaterialChange()
		{
		}

		// Token: 0x04004496 RID: 17558
		[Token(Token = "0x4004496")]
		[FieldOffset(Offset = "0x20")]
		public MeshRenderer[] Renderers;

		// Token: 0x04004497 RID: 17559
		[Token(Token = "0x4004497")]
		[FieldOffset(Offset = "0x28")]
		public int MaterialIndex;

		// Token: 0x04004498 RID: 17560
		[Token(Token = "0x4004498")]
		[FieldOffset(Offset = "0x2C")]
		[Header("Settings")]
		public bool Enabled;

		// Token: 0x04004499 RID: 17561
		[Token(Token = "0x4004499")]
		[FieldOffset(Offset = "0x30")]
		public Material OutsideTimeRangeMaterial;

		// Token: 0x0400449A RID: 17562
		[Token(Token = "0x400449A")]
		[FieldOffset(Offset = "0x38")]
		public Material InsideTimeRangeMaterial;

		// Token: 0x0400449B RID: 17563
		[Token(Token = "0x400449B")]
		[FieldOffset(Offset = "0x40")]
		public int TimeRangeMin;

		// Token: 0x0400449C RID: 17564
		[Token(Token = "0x400449C")]
		[FieldOffset(Offset = "0x44")]
		public int TimeRangeMax;

		// Token: 0x0400449D RID: 17565
		[Token(Token = "0x400449D")]
		[FieldOffset(Offset = "0x48")]
		public int TimeRangeShift;

		// Token: 0x0400449E RID: 17566
		[Token(Token = "0x400449E")]
		[FieldOffset(Offset = "0x4C")]
		public int TimeRangeRandomization;

		// Token: 0x0400449F RID: 17567
		[Token(Token = "0x400449F")]
		[FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		public float TurnOnChance;

		// Token: 0x040044A0 RID: 17568
		[Token(Token = "0x40044A0")]
		[FieldOffset(Offset = "0x54")]
		private bool appliedInsideTimeRange;

		// Token: 0x040044A1 RID: 17569
		[Token(Token = "0x40044A1")]
		[FieldOffset(Offset = "0x58")]
		private ScheduledMaterialChange.EOnState onState;

		// Token: 0x040044A2 RID: 17570
		[Token(Token = "0x40044A2")]
		[FieldOffset(Offset = "0x5C")]
		private int randomShift;

		// Token: 0x02000D0B RID: 3339
		[Token(Token = "0x2000D0B")]
		private enum EOnState
		{
			// Token: 0x040044A4 RID: 17572
			[Token(Token = "0x40044A4")]
			Undecided,
			// Token: 0x040044A5 RID: 17573
			[Token(Token = "0x40044A5")]
			On,
			// Token: 0x040044A6 RID: 17574
			[Token(Token = "0x40044A6")]
			Off
		}
	}
}
