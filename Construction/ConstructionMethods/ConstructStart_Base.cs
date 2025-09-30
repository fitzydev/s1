using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using ScheduleOne.ConstructableScripts;
using UnityEngine;

namespace ScheduleOne.Construction.ConstructionMethods
{
	// Token: 0x0200079F RID: 1951
	[Token(Token = "0x200079F")]
	public abstract class ConstructStart_Base : MonoBehaviour
	{
		// Token: 0x060034A9 RID: 13481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034A9")]
		[Address(RVA = "0x797D20", Offset = "0x796720", VA = "0x180797D20", Slot = "4")]
		public virtual void StartConstruction(string constructableID, [Optional] Constructable_GridBased movedConstructable)
		{
		}

		// Token: 0x060034AA RID: 13482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034AA")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		protected ConstructStart_Base()
		{
		}
	}
}
