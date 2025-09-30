using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x02000A3F RID: 2623
	[Token(Token = "0x2000A3F")]
	public class FlashlightAvatarEquippable : AvatarEquippable
	{
		// Token: 0x060047D9 RID: 18393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047D9")]
		[Address(RVA = "0x8F7960", Offset = "0x8F6360", VA = "0x1808F7960", Slot = "5")]
		public override void Equip(Avatar _avatar)
		{
		}

		// Token: 0x060047DA RID: 18394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047DA")]
		[Address(RVA = "0x8F7A50", Offset = "0x8F6450", VA = "0x1808F7A50")]
		public FlashlightAvatarEquippable()
		{
		}

		// Token: 0x040032C9 RID: 13001
		[Token(Token = "0x40032C9")]
		[FieldOffset(Offset = "0x50")]
		public OptimizedLight Light;
	}
}
