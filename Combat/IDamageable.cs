using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Combat
{
	// Token: 0x020007AC RID: 1964
	[Token(Token = "0x20007AC")]
	public interface IDamageable
	{
		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x060034F4 RID: 13556
		[Token(Token = "0x170007B1")]
		GameObject gameObject
		{
			[Token(Token = "0x60034F4")]
			get;
		}

		// Token: 0x060034F5 RID: 13557
		[Token(Token = "0x60034F5")]
		void SendImpact(Impact impact);

		// Token: 0x060034F6 RID: 13558
		[Token(Token = "0x60034F6")]
		void ReceiveImpact(Impact impact);
	}
}
