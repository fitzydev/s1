using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace ScheduleOne.Management
{
	// Token: 0x020004E2 RID: 1250
	[Token(Token = "0x20004E2")]
	public abstract class ConfigField
	{
		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06001944 RID: 6468 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001945 RID: 6469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700046D")]
		public EntityConfiguration ParentConfig
		{
			[Token(Token = "0x6001944")]
			[Address(RVA = "0x42FFD0", Offset = "0x42E9D0", VA = "0x18042FFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001945")]
			[Address(RVA = "0x4A4990", Offset = "0x4A3390", VA = "0x1804A4990")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001946")]
		[Address(RVA = "0x631DF0", Offset = "0x6307F0", VA = "0x180631DF0")]
		public ConfigField(EntityConfiguration parentConfig)
		{
		}

		// Token: 0x06001947 RID: 6471
		[Token(Token = "0x6001947")]
		public abstract bool IsValueDefault();
	}
}
