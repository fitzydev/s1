using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;

namespace ScheduleOne
{
	// Token: 0x0200028F RID: 655
	[Token(Token = "0x200028F")]
	public class AchievementManager : PersistentSingleton<AchievementManager>
	{
		// Token: 0x06000DC1 RID: 3521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DC1")]
		[Address(RVA = "0xA9A610", Offset = "0xA99010", VA = "0x180A9A610", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DC2")]
		[Address(RVA = "0xA9AA30", Offset = "0xA99430", VA = "0x180A9AA30", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DC3")]
		[Address(RVA = "0xA9A8A0", Offset = "0xA992A0", VA = "0x180A9A8A0")]
		private void PullAchievements()
		{
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DC4")]
		[Address(RVA = "0xA9ACD0", Offset = "0xA996D0", VA = "0x180A9ACD0")]
		public void UnlockAchievement(AchievementManager.EAchievement achievement)
		{
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DC5")]
		[Address(RVA = "0xA9AF50", Offset = "0xA99950", VA = "0x180A9AF50")]
		public AchievementManager()
		{
		}

		// Token: 0x04000DDD RID: 3549
		[Token(Token = "0x4000DDD")]
		[FieldOffset(Offset = "0x28")]
		private AchievementManager.EAchievement[] achievements;

		// Token: 0x04000DDE RID: 3550
		[Token(Token = "0x4000DDE")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<AchievementManager.EAchievement, bool> achievementUnlocked;

		// Token: 0x02000290 RID: 656
		[Token(Token = "0x2000290")]
		public enum EAchievement
		{
			// Token: 0x04000DE0 RID: 3552
			[Token(Token = "0x4000DE0")]
			COMPLETE_PROLOGUE,
			// Token: 0x04000DE1 RID: 3553
			[Token(Token = "0x4000DE1")]
			RV_DESTROYED,
			// Token: 0x04000DE2 RID: 3554
			[Token(Token = "0x4000DE2")]
			DEALER_RECRUITED,
			// Token: 0x04000DE3 RID: 3555
			[Token(Token = "0x4000DE3")]
			MASTER_CHEF,
			// Token: 0x04000DE4 RID: 3556
			[Token(Token = "0x4000DE4")]
			BUSINESSMAN,
			// Token: 0x04000DE5 RID: 3557
			[Token(Token = "0x4000DE5")]
			BIGWIG,
			// Token: 0x04000DE6 RID: 3558
			[Token(Token = "0x4000DE6")]
			MAGNATE,
			// Token: 0x04000DE7 RID: 3559
			[Token(Token = "0x4000DE7")]
			UPSTANDING_CITIZEN,
			// Token: 0x04000DE8 RID: 3560
			[Token(Token = "0x4000DE8")]
			ROLLING_IN_STYLE,
			// Token: 0x04000DE9 RID: 3561
			[Token(Token = "0x4000DE9")]
			LONG_ARM_OF_THE_LAW,
			// Token: 0x04000DEA RID: 3562
			[Token(Token = "0x4000DEA")]
			INDIAN_DEALER,
			// Token: 0x04000DEB RID: 3563
			[Token(Token = "0x4000DEB")]
			URBAN_ARTIST,
			// Token: 0x04000DEC RID: 3564
			[Token(Token = "0x4000DEC")]
			FINISHING_THE_JOB
		}
	}
}
