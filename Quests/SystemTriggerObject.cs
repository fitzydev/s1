using System;
using EasyButtons;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Quests
{
	// Token: 0x02000311 RID: 785
	[Token(Token = "0x2000311")]
	public class SystemTriggerObject : MonoBehaviour
	{
		// Token: 0x0600117E RID: 4478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600117E")]
		[Address(RVA = "0x5A3160", Offset = "0x5A1B60", VA = "0x1805A3160")]
		[Button]
		public void Trigger()
		{
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600117F")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public SystemTriggerObject()
		{
		}

		// Token: 0x0400113C RID: 4412
		[Token(Token = "0x400113C")]
		[FieldOffset(Offset = "0x20")]
		public SystemTrigger SystemTrigger;
	}
}
