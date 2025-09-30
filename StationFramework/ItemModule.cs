using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	// Token: 0x02000971 RID: 2417
	[Token(Token = "0x2000971")]
	public abstract class ItemModule : MonoBehaviour
	{
		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x0600424E RID: 16974 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600424F RID: 16975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000947")]
		public StationItem Item
		{
			[Token(Token = "0x600424E")]
			[Address(RVA = "0x42FFC0", Offset = "0x42E9C0", VA = "0x18042FFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600424F")]
			[Address(RVA = "0x42FFF0", Offset = "0x42E9F0", VA = "0x18042FFF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06004250 RID: 16976 RVA: 0x000116B8 File Offset: 0x0000F8B8
		// (set) Token: 0x06004251 RID: 16977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000948")]
		public bool IsModuleActive
		{
			[Token(Token = "0x6004250")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004251")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06004252 RID: 16978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004252")]
		[Address(RVA = "0x87CA10", Offset = "0x87B410", VA = "0x18087CA10", Slot = "4")]
		public virtual void ActivateModule(StationItem item)
		{
		}

		// Token: 0x06004253 RID: 16979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004253")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		protected ItemModule()
		{
		}
	}
}
