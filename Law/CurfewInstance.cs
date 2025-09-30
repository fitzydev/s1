using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Law
{
	// Token: 0x02000538 RID: 1336
	[Token(Token = "0x2000538")]
	[Serializable]
	public class CurfewInstance
	{
		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06001B31 RID: 6961 RVA: 0x000096A8 File Offset: 0x000078A8
		// (set) Token: 0x06001B32 RID: 6962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004C8")]
		public bool Enabled
		{
			[Token(Token = "0x6001B31")]
			[Address(RVA = "0x4A1AC0", Offset = "0x4A04C0", VA = "0x1804A1AC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001B32")]
			[Address(RVA = "0x632790", Offset = "0x631190", VA = "0x180632790")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B33")]
		[Address(RVA = "0x632470", Offset = "0x630E70", VA = "0x180632470")]
		public void Evaluate(bool ignoreSleepReq = false)
		{
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B34")]
		[Address(RVA = "0x632540", Offset = "0x630F40", VA = "0x180632540")]
		private void MinPass()
		{
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B35")]
		[Address(RVA = "0x6322D0", Offset = "0x630CD0", VA = "0x1806322D0")]
		public void Enable()
		{
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B36")]
		[Address(RVA = "0x632150", Offset = "0x630B50", VA = "0x180632150")]
		public void Disable()
		{
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B37")]
		[Address(RVA = "0x632780", Offset = "0x631180", VA = "0x180632780")]
		public CurfewInstance()
		{
		}

		// Token: 0x04001744 RID: 5956
		[Token(Token = "0x4001744")]
		[FieldOffset(Offset = "0x0")]
		public static CurfewInstance ActiveInstance;

		// Token: 0x04001745 RID: 5957
		[Token(Token = "0x4001745")]
		[FieldOffset(Offset = "0x10")]
		[Range(1f, 10f)]
		public int IntensityRequirement;

		// Token: 0x04001747 RID: 5959
		[Token(Token = "0x4001747")]
		[FieldOffset(Offset = "0x15")]
		[HideInInspector]
		public bool shouldDisable;
	}
}
