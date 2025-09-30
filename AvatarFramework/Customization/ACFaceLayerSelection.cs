using System;
using Il2CppDummyDll;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000A55 RID: 2645
	[Token(Token = "0x2000A55")]
	public class ACFaceLayerSelection : ACSelection<FaceLayer>
	{
		// Token: 0x06004837 RID: 18487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004837")]
		[Address(RVA = "0x8FBD40", Offset = "0x8FA740", VA = "0x1808FBD40", Slot = "6")]
		public override string GetOptionLabel(int index)
		{
			return null;
		}

		// Token: 0x06004838 RID: 18488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004838")]
		[Address(RVA = "0x8FBB10", Offset = "0x8FA510", VA = "0x1808FBB10", Slot = "5")]
		public override void CallValueChange()
		{
		}

		// Token: 0x06004839 RID: 18489 RVA: 0x00012F60 File Offset: 0x00011160
		[Token(Token = "0x6004839")]
		[Address(RVA = "0x8FBBF0", Offset = "0x8FA5F0", VA = "0x1808FBBF0", Slot = "7")]
		public override int GetAssetPathIndex(string path)
		{
			return 0;
		}

		// Token: 0x0600483A RID: 18490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600483A")]
		[Address(RVA = "0x8FBDA0", Offset = "0x8FA7A0", VA = "0x1808FBDA0")]
		public ACFaceLayerSelection()
		{
		}
	}
}
