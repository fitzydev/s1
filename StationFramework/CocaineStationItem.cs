using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Packaging;

namespace ScheduleOne.StationFramework
{
	// Token: 0x02000965 RID: 2405
	[Token(Token = "0x2000965")]
	public class CocaineStationItem : StationItem
	{
		// Token: 0x06004225 RID: 16933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004225")]
		[Address(RVA = "0x87B6B0", Offset = "0x87A0B0", VA = "0x18087B6B0", Slot = "5")]
		public override void Initialize(StorableItemDefinition itemDefinition)
		{
		}

		// Token: 0x06004226 RID: 16934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004226")]
		[Address(RVA = "0x87B810", Offset = "0x87A210", VA = "0x18087B810")]
		public CocaineStationItem()
		{
		}

		// Token: 0x04002E4B RID: 11851
		[Token(Token = "0x4002E4B")]
		[FieldOffset(Offset = "0x38")]
		public FilledPackagingVisuals[] Visuals;
	}
}
