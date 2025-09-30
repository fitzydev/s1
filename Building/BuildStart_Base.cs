using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Building
{
	// Token: 0x02000821 RID: 2081
	[Token(Token = "0x2000821")]
	public abstract class BuildStart_Base : MonoBehaviour
	{
		// Token: 0x0600394B RID: 14667
		[Token(Token = "0x600394B")]
		public abstract void StartBuilding(ItemInstance item);

		// Token: 0x0600394C RID: 14668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600394C")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		protected BuildStart_Base()
		{
		}
	}
}
