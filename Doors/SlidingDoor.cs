using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Doors
{
	// Token: 0x02000609 RID: 1545
	[Token(Token = "0x2000609")]
	public class SlidingDoor : MonoBehaviour
	{
		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06002637 RID: 9783 RVA: 0x0000BCB8 File Offset: 0x00009EB8
		// (set) Token: 0x06002638 RID: 9784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000645")]
		public bool IsOpen
		{
			[Token(Token = "0x6002637")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002638")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002639")]
		[Address(RVA = "0x6FDCC0", Offset = "0x6FC6C0", VA = "0x1806FDCC0", Slot = "4")]
		public virtual void Opened(EDoorSide openSide)
		{
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600263A")]
		[Address(RVA = "0x6FDC10", Offset = "0x6FC610", VA = "0x1806FDC10", Slot = "5")]
		public virtual void Closed()
		{
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600263B")]
		[Address(RVA = "0x6FDC20", Offset = "0x6FC620", VA = "0x1806FDC20")]
		private void Move()
		{
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600263C")]
		[Address(RVA = "0x6FDD40", Offset = "0x6FC740", VA = "0x1806FDD40")]
		public SlidingDoor()
		{
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600263D")]
		[Address(RVA = "0x6FDCD0", Offset = "0x6FC6D0", VA = "0x1806FDCD0")]
		[CompilerGenerated]
		private IEnumerator <Move>g__Move|12_0()
		{
			return null;
		}

		// Token: 0x04001D77 RID: 7543
		[Token(Token = "0x4001D77")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		public Transform DoorTransform;

		// Token: 0x04001D78 RID: 7544
		[Token(Token = "0x4001D78")]
		[FieldOffset(Offset = "0x30")]
		public Transform ClosedPosition;

		// Token: 0x04001D79 RID: 7545
		[Token(Token = "0x4001D79")]
		[FieldOffset(Offset = "0x38")]
		public Transform OpenPosition;

		// Token: 0x04001D7A RID: 7546
		[Token(Token = "0x4001D7A")]
		[FieldOffset(Offset = "0x40")]
		public float SlideDuration;

		// Token: 0x04001D7B RID: 7547
		[Token(Token = "0x4001D7B")]
		[FieldOffset(Offset = "0x48")]
		public AnimationCurve SlideCurve;

		// Token: 0x04001D7C RID: 7548
		[Token(Token = "0x4001D7C")]
		[FieldOffset(Offset = "0x50")]
		private Coroutine MoveRoutine;
	}
}
