using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Doors
{
	// Token: 0x02000607 RID: 1543
	[Token(Token = "0x2000607")]
	public class RollerDoor : MonoBehaviour
	{
		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x0600262D RID: 9773 RVA: 0x0000BC88 File Offset: 0x00009E88
		// (set) Token: 0x0600262E RID: 9774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000644")]
		public bool IsOpen
		{
			[Token(Token = "0x600262D")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600262E")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600262F")]
		[Address(RVA = "0x6FD5E0", Offset = "0x6FBFE0", VA = "0x1806FD5E0")]
		private void Awake()
		{
		}

		// Token: 0x06002630 RID: 9776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002630")]
		[Address(RVA = "0x6FD680", Offset = "0x6FC080", VA = "0x1806FD680")]
		private void LateUpdate()
		{
		}

		// Token: 0x06002631 RID: 9777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002631")]
		[Address(RVA = "0x6FD830", Offset = "0x6FC230", VA = "0x1806FD830")]
		public void Open()
		{
		}

		// Token: 0x06002632 RID: 9778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002632")]
		[Address(RVA = "0x6FD630", Offset = "0x6FC030", VA = "0x1806FD630")]
		public void Close()
		{
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x0000BCA0 File Offset: 0x00009EA0
		[Token(Token = "0x6002633")]
		[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0", Slot = "4")]
		protected virtual bool CanOpen()
		{
			return default(bool);
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002634")]
		[Address(RVA = "0x6FD8A0", Offset = "0x6FC2A0", VA = "0x1806FD8A0")]
		public RollerDoor()
		{
		}

		// Token: 0x04001D6C RID: 7532
		[Token(Token = "0x4001D6C")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		public Transform Door;

		// Token: 0x04001D6D RID: 7533
		[Token(Token = "0x4001D6D")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 LocalPos_Open;

		// Token: 0x04001D6E RID: 7534
		[Token(Token = "0x4001D6E")]
		[FieldOffset(Offset = "0x3C")]
		public Vector3 LocalPos_Closed;

		// Token: 0x04001D6F RID: 7535
		[Token(Token = "0x4001D6F")]
		[FieldOffset(Offset = "0x48")]
		public float LerpTime;

		// Token: 0x04001D70 RID: 7536
		[Token(Token = "0x4001D70")]
		[FieldOffset(Offset = "0x50")]
		public GameObject Blocker;

		// Token: 0x04001D71 RID: 7537
		[Token(Token = "0x4001D71")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 startPos;

		// Token: 0x04001D72 RID: 7538
		[Token(Token = "0x4001D72")]
		[FieldOffset(Offset = "0x64")]
		private float timeSinceValueChange;
	}
}
