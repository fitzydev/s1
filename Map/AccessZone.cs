using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Doors;
using ScheduleOne.Misc;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Map
{
	// Token: 0x02000CE8 RID: 3304
	[Token(Token = "0x2000CE8")]
	public class AccessZone : MonoBehaviour
	{
		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x06005D90 RID: 23952 RVA: 0x00016800 File Offset: 0x00014A00
		// (set) Token: 0x06005D91 RID: 23953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D0C")]
		public bool IsOpen
		{
			[Token(Token = "0x6005D90")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005D91")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005D92 RID: 23954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D92")]
		[Address(RVA = "0xA54950", Offset = "0xA53350", VA = "0x180A54950", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06005D93 RID: 23955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D93")]
		[Address(RVA = "0xA54970", Offset = "0xA53370", VA = "0x180A54970", Slot = "5")]
		public virtual void SetIsOpen(bool open)
		{
		}

		// Token: 0x06005D94 RID: 23956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D94")]
		[Address(RVA = "0xA54B90", Offset = "0xA53590", VA = "0x180A54B90")]
		public AccessZone()
		{
		}

		// Token: 0x040043F7 RID: 17399
		[Token(Token = "0x40043F7")]
		[FieldOffset(Offset = "0x21")]
		[Header("Settings")]
		public bool AllowExitWhenClosed;

		// Token: 0x040043F8 RID: 17400
		[Token(Token = "0x40043F8")]
		[FieldOffset(Offset = "0x22")]
		public bool AutoCloseDoor;

		// Token: 0x040043F9 RID: 17401
		[Token(Token = "0x40043F9")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public DoorController[] Doors;

		// Token: 0x040043FA RID: 17402
		[Token(Token = "0x40043FA")]
		[FieldOffset(Offset = "0x30")]
		public ToggleableLight[] Lights;

		// Token: 0x040043FB RID: 17403
		[Token(Token = "0x40043FB")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent onOpen;

		// Token: 0x040043FC RID: 17404
		[Token(Token = "0x40043FC")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent onClose;
	}
}
