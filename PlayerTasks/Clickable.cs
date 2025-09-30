using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x0200034A RID: 842
	[Token(Token = "0x200034A")]
	public class Clickable : MonoBehaviour
	{
		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06001284 RID: 4740 RVA: 0x00007EC0 File Offset: 0x000060C0
		// (set) Token: 0x06001285 RID: 4741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000387")]
		public virtual CursorManager.ECursorType HoveredCursor
		{
			[Token(Token = "0x6001284")]
			[Address(RVA = "0x47D5D0", Offset = "0x47BFD0", VA = "0x18047D5D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return CursorManager.ECursorType.Default;
			}
			[Token(Token = "0x6001285")]
			[Address(RVA = "0x47D7A0", Offset = "0x47C1A0", VA = "0x18047D7A0", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06001286 RID: 4742 RVA: 0x00007ED8 File Offset: 0x000060D8
		// (set) Token: 0x06001287 RID: 4743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000388")]
		public Vector3 originalHitPoint
		{
			[Token(Token = "0x6001286")]
			[Address(RVA = "0x590690", Offset = "0x58F090", VA = "0x180590690")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6001287")]
			[Address(RVA = "0x5905A0", Offset = "0x58EFA0", VA = "0x1805905A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06001288 RID: 4744 RVA: 0x00007EF0 File Offset: 0x000060F0
		// (set) Token: 0x06001289 RID: 4745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000389")]
		public bool IsHeld
		{
			[Token(Token = "0x6001288")]
			[Address(RVA = "0x4FA8A0", Offset = "0x4F92A0", VA = "0x1804FA8A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001289")]
			[Address(RVA = "0x4FAC50", Offset = "0x4F9650", VA = "0x1804FAC50")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600128A")]
		[Address(RVA = "0x590510", Offset = "0x58EF10", VA = "0x180590510")]
		private void Awake()
		{
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600128B")]
		[Address(RVA = "0x5905B0", Offset = "0x58EFB0", VA = "0x1805905B0", Slot = "6")]
		public virtual void StartClick(RaycastHit hit)
		{
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600128C")]
		[Address(RVA = "0x590570", Offset = "0x58EF70", VA = "0x180590570", Slot = "7")]
		public virtual void EndClick()
		{
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600128D")]
		[Address(RVA = "0x5905A0", Offset = "0x58EFA0", VA = "0x1805905A0")]
		public void SetOriginalHitPoint(Vector3 hitPoint)
		{
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600128E")]
		[Address(RVA = "0x590630", Offset = "0x58F030", VA = "0x180590630")]
		public Clickable()
		{
		}

		// Token: 0x040011A6 RID: 4518
		[Token(Token = "0x40011A6")]
		[FieldOffset(Offset = "0x20")]
		public bool ClickableEnabled;

		// Token: 0x040011A7 RID: 4519
		[Token(Token = "0x40011A7")]
		[FieldOffset(Offset = "0x21")]
		public bool AutoCalculateOffset;

		// Token: 0x040011A8 RID: 4520
		[Token(Token = "0x40011A8")]
		[FieldOffset(Offset = "0x22")]
		public bool FlattenZOffset;

		// Token: 0x040011AB RID: 4523
		[Token(Token = "0x40011AB")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent<RaycastHit> onClickStart;

		// Token: 0x040011AC RID: 4524
		[Token(Token = "0x40011AC")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent onClickEnd;
	}
}
