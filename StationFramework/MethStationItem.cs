using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Packaging;

namespace ScheduleOne.StationFramework
{
	// Token: 0x02000975 RID: 2421
	[Token(Token = "0x2000975")]
	public class MethStationItem : StationItem
	{
		// Token: 0x06004264 RID: 16996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004264")]
		[Address(RVA = "0x87F2D0", Offset = "0x87DCD0", VA = "0x18087F2D0", Slot = "5")]
		public override void Initialize(StorableItemDefinition itemDefinition)
		{
		}

		// Token: 0x06004265 RID: 16997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004265")]
		[Address(RVA = "0x87B810", Offset = "0x87A210", VA = "0x18087B810")]
		public MethStationItem()
		{
		}

		// Token: 0x04002E83 RID: 11907
		[Token(Token = "0x4002E83")]
		[FieldOffset(Offset = "0x38")]
		public FilledPackagingVisuals[] Visuals;
	}
}
