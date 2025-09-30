using System;
using FishNet.Object;
using Il2CppDummyDll;

namespace ScheduleOne.Management
{
	// Token: 0x020004F0 RID: 1264
	[Token(Token = "0x20004F0")]
	public interface IUsable
	{
		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x060019B9 RID: 6585 RVA: 0x00009210 File Offset: 0x00007410
		[Token(Token = "0x1700048B")]
		bool IsInUse
		{
			[Token(Token = "0x60019B9")]
			[Address(RVA = "0x636EC0", Offset = "0x6358C0", VA = "0x180636EC0", Slot = "0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x060019BA RID: 6586
		// (set) Token: 0x060019BB RID: 6587
		[Token(Token = "0x1700048C")]
		NetworkObject NPCUserObject
		{
			[Token(Token = "0x60019BA")]
			get;
			[Token(Token = "0x60019BB")]
			set;
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x060019BC RID: 6588
		// (set) Token: 0x060019BD RID: 6589
		[Token(Token = "0x1700048D")]
		NetworkObject PlayerUserObject
		{
			[Token(Token = "0x60019BC")]
			get;
			[Token(Token = "0x60019BD")]
			set;
		}

		// Token: 0x060019BE RID: 6590
		[Token(Token = "0x60019BE")]
		void SetPlayerUser(NetworkObject playerObject);

		// Token: 0x060019BF RID: 6591
		[Token(Token = "0x60019BF")]
		void SetNPCUser(NetworkObject playerObject);
	}
}
