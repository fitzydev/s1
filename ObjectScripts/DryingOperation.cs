using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000CA5 RID: 3237
	[Token(Token = "0x2000CA5")]
	[Serializable]
	public class DryingOperation
	{
		// Token: 0x0600594B RID: 22859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600594B")]
		[Address(RVA = "0xA1F020", Offset = "0xA1DA20", VA = "0x180A1F020")]
		public DryingOperation(string itemID, int quantity, EQuality startQuality, int time)
		{
		}

		// Token: 0x0600594C RID: 22860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600594C")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public DryingOperation()
		{
		}

		// Token: 0x0600594D RID: 22861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600594D")]
		[Address(RVA = "0xA1F010", Offset = "0xA1DA10", VA = "0x180A1F010")]
		public void IncreaseQuality()
		{
		}

		// Token: 0x0600594E RID: 22862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600594E")]
		[Address(RVA = "0xA1EF40", Offset = "0xA1D940", VA = "0x180A1EF40")]
		public QualityItemInstance GetQualityItemInstance()
		{
			return null;
		}

		// Token: 0x0600594F RID: 22863 RVA: 0x00015ED0 File Offset: 0x000140D0
		[Token(Token = "0x600594F")]
		[Address(RVA = "0xA1EFF0", Offset = "0xA1D9F0", VA = "0x180A1EFF0")]
		public EQuality GetQuality()
		{
			return EQuality.Trash;
		}

		// Token: 0x040041AC RID: 16812
		[Token(Token = "0x40041AC")]
		[FieldOffset(Offset = "0x10")]
		public string ItemID;

		// Token: 0x040041AD RID: 16813
		[Token(Token = "0x40041AD")]
		[FieldOffset(Offset = "0x18")]
		public int Quantity;

		// Token: 0x040041AE RID: 16814
		[Token(Token = "0x40041AE")]
		[FieldOffset(Offset = "0x1C")]
		public EQuality StartQuality;

		// Token: 0x040041AF RID: 16815
		[Token(Token = "0x40041AF")]
		[FieldOffset(Offset = "0x20")]
		public int Time;
	}
}
