using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Animation
{
	// Token: 0x02000A3D RID: 2621
	[Token(Token = "0x2000A3D")]
	public class AvatarSeatSet : MonoBehaviour
	{
		// Token: 0x060047D3 RID: 18387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047D3")]
		[Address(RVA = "0x8F2D10", Offset = "0x8F1710", VA = "0x1808F2D10")]
		public AvatarSeat GetFirstFreeSeat()
		{
			return null;
		}

		// Token: 0x060047D4 RID: 18388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047D4")]
		[Address(RVA = "0x8F2E60", Offset = "0x8F1860", VA = "0x1808F2E60")]
		public AvatarSeat GetRandomFreeSeat()
		{
			return null;
		}

		// Token: 0x060047D5 RID: 18389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047D5")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public AvatarSeatSet()
		{
		}

		// Token: 0x040032C6 RID: 12998
		[Token(Token = "0x40032C6")]
		[FieldOffset(Offset = "0x20")]
		public AvatarSeat[] Seats;
	}
}
