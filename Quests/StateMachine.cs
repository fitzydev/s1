using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Quests
{
	// Token: 0x0200030F RID: 783
	[Token(Token = "0x200030F")]
	public class StateMachine : MonoBehaviour
	{
		// Token: 0x06001177 RID: 4471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001177")]
		[Address(RVA = "0x5A3010", Offset = "0x5A1A10", VA = "0x1805A3010")]
		private void Start()
		{
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001178")]
		[Address(RVA = "0x5A30F0", Offset = "0x5A1AF0", VA = "0x1805A30F0")]
		private void Update()
		{
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001179")]
		[Address(RVA = "0x5A2F80", Offset = "0x5A1980", VA = "0x1805A2F80")]
		private void Clean()
		{
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600117A")]
		[Address(RVA = "0x5A2F40", Offset = "0x5A1940", VA = "0x1805A2F40")]
		public static void ChangeState()
		{
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600117B")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public StateMachine()
		{
		}

		// Token: 0x04001133 RID: 4403
		[Token(Token = "0x4001133")]
		[FieldOffset(Offset = "0x0")]
		public static Action OnStateChange;

		// Token: 0x04001134 RID: 4404
		[Token(Token = "0x4001134")]
		[FieldOffset(Offset = "0x8")]
		private static bool stateChanged;
	}
}
