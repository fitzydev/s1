using System;
using Il2CppDummyDll;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000A50 RID: 2640
	[Token(Token = "0x2000A50")]
	public class ACAccessorySelection : ACSelection<Accessory>
	{
		// Token: 0x06004829 RID: 18473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004829")]
		[Address(RVA = "0x8FB590", Offset = "0x8F9F90", VA = "0x1808FB590", Slot = "6")]
		public override string GetOptionLabel(int index)
		{
			return null;
		}

		// Token: 0x0600482A RID: 18474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600482A")]
		[Address(RVA = "0x8FB360", Offset = "0x8F9D60", VA = "0x1808FB360", Slot = "5")]
		public override void CallValueChange()
		{
		}

		// Token: 0x0600482B RID: 18475 RVA: 0x00012F00 File Offset: 0x00011100
		[Token(Token = "0x600482B")]
		[Address(RVA = "0x8FB440", Offset = "0x8F9E40", VA = "0x1808FB440", Slot = "7")]
		public override int GetAssetPathIndex(string path)
		{
			return 0;
		}

		// Token: 0x0600482C RID: 18476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600482C")]
		[Address(RVA = "0x8FB5F0", Offset = "0x8F9FF0", VA = "0x1808FB5F0")]
		public ACAccessorySelection()
		{
		}
	}
}
