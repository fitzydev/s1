using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x02000A20 RID: 2592
	[Token(Token = "0x2000A20")]
	public class Hair : Accessory
	{
		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06004723 RID: 18211 RVA: 0x00012B10 File Offset: 0x00010D10
		// (set) Token: 0x06004724 RID: 18212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A06")]
		public bool BlockedByHat
		{
			[Token(Token = "0x6004723")]
			[Address(RVA = "0x4E6CD0", Offset = "0x4E56D0", VA = "0x1804E6CD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004724")]
			[Address(RVA = "0x67F260", Offset = "0x67DC60", VA = "0x18067F260")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06004725 RID: 18213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004725")]
		[Address(RVA = "0x8F7AD0", Offset = "0x8F64D0", VA = "0x1808F7AD0")]
		public void SetBlockedByHat(bool blocked)
		{
		}

		// Token: 0x06004726 RID: 18214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004726")]
		[Address(RVA = "0x8F7A60", Offset = "0x8F6460", VA = "0x1808F7A60", Slot = "4")]
		protected virtual void BlockHair()
		{
		}

		// Token: 0x06004727 RID: 18215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004727")]
		[Address(RVA = "0x8F7B00", Offset = "0x8F6500", VA = "0x1808F7B00", Slot = "5")]
		protected virtual void UnBlockHair()
		{
		}

		// Token: 0x06004728 RID: 18216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004728")]
		[Address(RVA = "0x8F7B70", Offset = "0x8F6570", VA = "0x1808F7B70")]
		public Hair()
		{
		}

		// Token: 0x040031FE RID: 12798
		[Token(Token = "0x40031FE")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject[] hairToHide;
	}
}
