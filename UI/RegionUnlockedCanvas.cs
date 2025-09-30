using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Map;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000B02 RID: 2818
	[Token(Token = "0x2000B02")]
	public class RegionUnlockedCanvas : Singleton<RegionUnlockedCanvas>, IPostSleepEvent
	{
		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06004C91 RID: 19601 RVA: 0x00013C20 File Offset: 0x00011E20
		// (set) Token: 0x06004C92 RID: 19602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AC8")]
		public bool IsRunning
		{
			[Token(Token = "0x6004C91")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004C92")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06004C93 RID: 19603 RVA: 0x00013C38 File Offset: 0x00011E38
		// (set) Token: 0x06004C94 RID: 19604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AC9")]
		public int Order
		{
			[Token(Token = "0x6004C93")]
			[Address(RVA = "0x6737E0", Offset = "0x6721E0", VA = "0x1806737E0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004C94")]
			[Address(RVA = "0x673170", Offset = "0x671B70", VA = "0x180673170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004C95 RID: 19605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C95")]
		[Address(RVA = "0x933530", Offset = "0x931F30", VA = "0x180933530")]
		public void QueueUnlocked(EMapRegion _region)
		{
		}

		// Token: 0x06004C96 RID: 19606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C96")]
		[Address(RVA = "0x9335C0", Offset = "0x931FC0", VA = "0x1809335C0", Slot = "9")]
		public void StartEvent()
		{
		}

		// Token: 0x06004C97 RID: 19607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C97")]
		[Address(RVA = "0x9334D0", Offset = "0x931ED0", VA = "0x1809334D0")]
		public void EndEvent()
		{
		}

		// Token: 0x06004C98 RID: 19608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C98")]
		[Address(RVA = "0x933C70", Offset = "0x932670", VA = "0x180933C70")]
		public RegionUnlockedCanvas()
		{
		}

		// Token: 0x04003771 RID: 14193
		[Token(Token = "0x4003771")]
		[FieldOffset(Offset = "0x30")]
		public Animation OpenCloseAnim;

		// Token: 0x04003772 RID: 14194
		[Token(Token = "0x4003772")]
		[FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI RegionLabel;

		// Token: 0x04003773 RID: 14195
		[Token(Token = "0x4003773")]
		[FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI RegionDescription;

		// Token: 0x04003774 RID: 14196
		[Token(Token = "0x4003774")]
		[FieldOffset(Offset = "0x48")]
		public Image RegionImage;

		// Token: 0x04003775 RID: 14197
		[Token(Token = "0x4003775")]
		[FieldOffset(Offset = "0x50")]
		private EMapRegion region;
	}
}
