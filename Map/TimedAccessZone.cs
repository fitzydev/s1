using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000D0C RID: 3340
	[Token(Token = "0x2000D0C")]
	public class TimedAccessZone : AccessZone
	{
		// Token: 0x06005E5E RID: 24158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E5E")]
		[Address(RVA = "0xA691C0", Offset = "0xA67BC0", VA = "0x180A691C0", Slot = "6")]
		protected virtual void Start()
		{
		}

		// Token: 0x06005E5F RID: 24159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E5F")]
		[Address(RVA = "0xA69180", Offset = "0xA67B80", VA = "0x180A69180", Slot = "7")]
		protected virtual void MinPass()
		{
		}

		// Token: 0x06005E60 RID: 24160 RVA: 0x00016AB8 File Offset: 0x00014CB8
		[Token(Token = "0x6005E60")]
		[Address(RVA = "0xA690F0", Offset = "0xA67AF0", VA = "0x180A690F0", Slot = "8")]
		protected virtual bool GetIsOpen()
		{
			return default(bool);
		}

		// Token: 0x06005E61 RID: 24161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E61")]
		[Address(RVA = "0xA571D0", Offset = "0xA55BD0", VA = "0x180A571D0")]
		public TimedAccessZone()
		{
		}

		// Token: 0x040044A7 RID: 17575
		[Token(Token = "0x40044A7")]
		[FieldOffset(Offset = "0x48")]
		[Header("Timing Settings")]
		public int OpenTime;

		// Token: 0x040044A8 RID: 17576
		[Token(Token = "0x40044A8")]
		[FieldOffset(Offset = "0x4C")]
		public int CloseTime;
	}
}
