using System;
using FishNet.Object;
using Il2CppDummyDll;

namespace ScheduleOne.Vision
{
	// Token: 0x02000379 RID: 889
	[Token(Token = "0x2000379")]
	public interface ISightable
	{
		// Token: 0x170003BD RID: 957
		// (get) Token: 0x060013D2 RID: 5074
		[Token(Token = "0x170003BD")]
		NetworkObject NetworkObject
		{
			[Token(Token = "0x60013D2")]
			get;
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x060013D3 RID: 5075
		// (set) Token: 0x060013D4 RID: 5076
		[Token(Token = "0x170003BE")]
		VisionEvent HighestProgressionEvent
		{
			[Token(Token = "0x60013D3")]
			get;
			[Token(Token = "0x60013D4")]
			set;
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x060013D5 RID: 5077
		[Token(Token = "0x170003BF")]
		EntityVisibility VisibilityComponent
		{
			[Token(Token = "0x60013D5")]
			get;
		}

		// Token: 0x060013D6 RID: 5078
		[Token(Token = "0x60013D6")]
		bool IsCurrentlySightable();
	}
}
