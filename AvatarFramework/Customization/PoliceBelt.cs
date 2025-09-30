using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000A4F RID: 2639
	[Token(Token = "0x2000A4F")]
	public class PoliceBelt : Accessory
	{
		// Token: 0x06004825 RID: 18469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004825")]
		[Address(RVA = "0x90DA10", Offset = "0x90C410", VA = "0x18090DA10")]
		public void SetBatonVisible(bool vis)
		{
		}

		// Token: 0x06004826 RID: 18470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004826")]
		[Address(RVA = "0x90DA90", Offset = "0x90C490", VA = "0x18090DA90")]
		public void SetTaserVisible(bool vis)
		{
		}

		// Token: 0x06004827 RID: 18471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004827")]
		[Address(RVA = "0x90DA50", Offset = "0x90C450", VA = "0x18090DA50")]
		public void SetGunVisible(bool vis)
		{
		}

		// Token: 0x06004828 RID: 18472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004828")]
		[Address(RVA = "0x8F7B70", Offset = "0x8F6570", VA = "0x1808F7B70")]
		public PoliceBelt()
		{
		}

		// Token: 0x04003328 RID: 13096
		[Token(Token = "0x4003328")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Header("References")]
		protected GameObject BatonObject;

		// Token: 0x04003329 RID: 13097
		[Token(Token = "0x4003329")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected GameObject TaserObject;

		// Token: 0x0400332A RID: 13098
		[Token(Token = "0x400332A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected GameObject GunObject;
	}
}
