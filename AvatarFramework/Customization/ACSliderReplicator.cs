using System;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000A67 RID: 2663
	[Token(Token = "0x2000A67")]
	public class ACSliderReplicator : ACReplicator
	{
		// Token: 0x06004894 RID: 18580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004894")]
		[Address(RVA = "0x8FBFF0", Offset = "0x8FA9F0", VA = "0x1808FBFF0", Slot = "4")]
		protected override void AvatarSettingsChanged(AvatarSettings newSettings)
		{
		}

		// Token: 0x06004895 RID: 18581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004895")]
		[Address(RVA = "0x8FB9F0", Offset = "0x8FA3F0", VA = "0x1808FB9F0")]
		public ACSliderReplicator()
		{
		}

		// Token: 0x04003385 RID: 13189
		[Token(Token = "0x4003385")]
		[FieldOffset(Offset = "0x28")]
		public Slider slider;
	}
}
