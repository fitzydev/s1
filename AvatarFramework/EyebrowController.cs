using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x02000A1C RID: 2588
	[Token(Token = "0x2000A1C")]
	public class EyebrowController : MonoBehaviour
	{
		// Token: 0x060046FE RID: 18174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046FE")]
		[Address(RVA = "0x8F73C0", Offset = "0x8F5DC0", VA = "0x1808F73C0")]
		public void ApplySettings(AvatarSettings settings)
		{
		}

		// Token: 0x060046FF RID: 18175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046FF")]
		[Address(RVA = "0x8F7660", Offset = "0x8F6060", VA = "0x1808F7660")]
		public void SetLeftBrowRestingHeight(float normalizedHeight)
		{
		}

		// Token: 0x06004700 RID: 18176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004700")]
		[Address(RVA = "0x8F7680", Offset = "0x8F6080", VA = "0x1808F7680")]
		public void SetRightBrowRestingHeight(float normalizedHeight)
		{
		}

		// Token: 0x06004701 RID: 18177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004701")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public EyebrowController()
		{
		}

		// Token: 0x040031DD RID: 12765
		[Token(Token = "0x40031DD")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public Eyebrow leftBrow;

		// Token: 0x040031DE RID: 12766
		[Token(Token = "0x40031DE")]
		[FieldOffset(Offset = "0x28")]
		public Eyebrow rightBrow;
	}
}
