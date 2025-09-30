using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Product;

namespace ScheduleOne.StationFramework
{
	// Token: 0x02000963 RID: 2403
	[Token(Token = "0x2000963")]
	public class LiquidMeth_StationItem : StationItem
	{
		// Token: 0x06004212 RID: 16914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004212")]
		[Address(RVA = "0x87D800", Offset = "0x87C200", VA = "0x18087D800", Slot = "5")]
		public override void Initialize(StorableItemDefinition itemDefinition)
		{
		}

		// Token: 0x06004213 RID: 16915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004213")]
		[Address(RVA = "0x87B810", Offset = "0x87A210", VA = "0x18087B810")]
		public LiquidMeth_StationItem()
		{
		}

		// Token: 0x04002E37 RID: 11831
		[Token(Token = "0x4002E37")]
		[FieldOffset(Offset = "0x38")]
		public LiquidMethVisuals Visuals;
	}
}
