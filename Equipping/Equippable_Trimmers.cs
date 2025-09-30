using System;
using Il2CppDummyDll;
using ScheduleOne.Audio;

namespace ScheduleOne.Equipping
{
	// Token: 0x020009C4 RID: 2500
	[Token(Token = "0x20009C4")]
	public class Equippable_Trimmers : Equippable_Viewmodel
	{
		// Token: 0x06004453 RID: 17491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004453")]
		[Address(RVA = "0x8BDC30", Offset = "0x8BC630", VA = "0x1808BDC30", Slot = "6")]
		protected override void Update()
		{
		}

		// Token: 0x06004454 RID: 17492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004454")]
		[Address(RVA = "0x8BDFE0", Offset = "0x8BC9E0", VA = "0x1808BDFE0")]
		public Equippable_Trimmers()
		{
		}

		// Token: 0x04002FD6 RID: 12246
		[Token(Token = "0x4002FD6")]
		[FieldOffset(Offset = "0x68")]
		public bool CanClickAndDrag;

		// Token: 0x04002FD7 RID: 12247
		[Token(Token = "0x4002FD7")]
		[FieldOffset(Offset = "0x70")]
		public AudioSourceController SoundLoopPrefab;
	}
}
