using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Animation
{
	// Token: 0x02000A3C RID: 2620
	[Token(Token = "0x2000A3C")]
	public class AvatarSeat : MonoBehaviour
	{
		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x060047CD RID: 18381 RVA: 0x00012DB0 File Offset: 0x00010FB0
		[Token(Token = "0x17000A1F")]
		public bool IsOccupied
		{
			[Token(Token = "0x60047CD")]
			[Address(RVA = "0x8F3150", Offset = "0x8F1B50", VA = "0x1808F3150")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x060047CE RID: 18382 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060047CF RID: 18383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A20")]
		public NPC Occupant
		{
			[Token(Token = "0x60047CE")]
			[Address(RVA = "0x42FFC0", Offset = "0x42E9C0", VA = "0x18042FFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60047CF")]
			[Address(RVA = "0x42FFF0", Offset = "0x42E9F0", VA = "0x18042FFF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060047D0 RID: 18384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047D0")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80")]
		private void Awake()
		{
		}

		// Token: 0x060047D1 RID: 18385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047D1")]
		[Address(RVA = "0x8F3040", Offset = "0x8F1A40", VA = "0x1808F3040")]
		public void SetOccupant(NPC npc)
		{
		}

		// Token: 0x060047D2 RID: 18386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047D2")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public AvatarSeat()
		{
		}

		// Token: 0x040032C4 RID: 12996
		[Token(Token = "0x40032C4")]
		[FieldOffset(Offset = "0x28")]
		public Transform SittingPoint;

		// Token: 0x040032C5 RID: 12997
		[Token(Token = "0x40032C5")]
		[FieldOffset(Offset = "0x30")]
		public Transform AccessPoint;
	}
}
