using System;
using Il2CppDummyDll;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000A52 RID: 2642
	[Token(Token = "0x2000A52")]
	public class ACAvatarLayerSelection : ACSelection<AvatarLayer>
	{
		// Token: 0x0600482F RID: 18479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600482F")]
		[Address(RVA = "0x8FB8A0", Offset = "0x8FA2A0", VA = "0x1808FB8A0", Slot = "6")]
		public override string GetOptionLabel(int index)
		{
			return null;
		}

		// Token: 0x06004830 RID: 18480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004830")]
		[Address(RVA = "0x8FB670", Offset = "0x8FA070", VA = "0x1808FB670", Slot = "5")]
		public override void CallValueChange()
		{
		}

		// Token: 0x06004831 RID: 18481 RVA: 0x00012F30 File Offset: 0x00011130
		[Token(Token = "0x6004831")]
		[Address(RVA = "0x8FB750", Offset = "0x8FA150", VA = "0x1808FB750", Slot = "7")]
		public override int GetAssetPathIndex(string path)
		{
			return 0;
		}

		// Token: 0x06004832 RID: 18482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004832")]
		[Address(RVA = "0x8FB900", Offset = "0x8FA300", VA = "0x1808FB900")]
		public ACAvatarLayerSelection()
		{
		}
	}
}
