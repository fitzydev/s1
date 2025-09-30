using System;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts.HandheldBin;

namespace ScheduleOne.Equipping
{
	// Token: 0x020009C2 RID: 2498
	[Token(Token = "0x20009C2")]
	public class Equippable_Bin : Equippable_Viewmodel
	{
		// Token: 0x06004442 RID: 17474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004442")]
		[Address(RVA = "0x850250", Offset = "0x84EC50", VA = "0x180850250")]
		public Equippable_Bin()
		{
		}

		// Token: 0x04002FC3 RID: 12227
		[Token(Token = "0x4002FC3")]
		[FieldOffset(Offset = "0x68")]
		public HandheldBin_Functional bin;
	}
}
