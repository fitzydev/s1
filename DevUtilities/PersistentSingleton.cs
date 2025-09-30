using System;
using Il2CppDummyDll;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000763 RID: 1891
	[Token(Token = "0x2000763")]
	public abstract class PersistentSingleton<T> : Singleton<T> where T : Singleton<T>
	{
		// Token: 0x06003341 RID: 13121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003341")]
		protected override void Awake()
		{
		}

		// Token: 0x06003342 RID: 13122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003342")]
		protected PersistentSingleton()
		{
		}
	}
}
