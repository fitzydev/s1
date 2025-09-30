using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Packaging;

namespace ScheduleOne.StationFramework
{
	// Token: 0x02000980 RID: 2432
	[Token(Token = "0x2000980")]
	public class WeedStationItem : StationItem
	{
		// Token: 0x06004297 RID: 17047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004297")]
		[Address(RVA = "0x892290", Offset = "0x890C90", VA = "0x180892290", Slot = "5")]
		public override void Initialize(StorableItemDefinition itemDefinition)
		{
		}

		// Token: 0x06004298 RID: 17048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004298")]
		[Address(RVA = "0x87B810", Offset = "0x87A210", VA = "0x18087B810")]
		public WeedStationItem()
		{
		}

		// Token: 0x04002EB9 RID: 11961
		[Token(Token = "0x4002EB9")]
		[FieldOffset(Offset = "0x38")]
		public FilledPackagingVisuals[] Visuals;
	}
}
