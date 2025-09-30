using System;
using HSVPicker;
using Il2CppDummyDll;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000A64 RID: 2660
	[Token(Token = "0x2000A64")]
	public class ACColorPickerReplicator : ACReplicator
	{
		// Token: 0x0600488E RID: 18574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600488E")]
		[Address(RVA = "0x8FB940", Offset = "0x8FA340", VA = "0x1808FB940", Slot = "4")]
		protected override void AvatarSettingsChanged(AvatarSettings newSettings)
		{
		}

		// Token: 0x0600488F RID: 18575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600488F")]
		[Address(RVA = "0x8FB9F0", Offset = "0x8FA3F0", VA = "0x1808FB9F0")]
		public ACColorPickerReplicator()
		{
		}

		// Token: 0x04003383 RID: 13187
		[Token(Token = "0x4003383")]
		[FieldOffset(Offset = "0x28")]
		public global::HSVPicker.ColorPicker picker;
	}
}
