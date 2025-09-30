using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

namespace ScheduleOne.Misc
{
	// Token: 0x02000CDF RID: 3295
	[Token(Token = "0x2000CDF")]
	public class CarStopper : MonoBehaviour
	{
		// Token: 0x06005D5E RID: 23902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D5E")]
		[Address(RVA = "0xA54E20", Offset = "0xA53820", VA = "0x180A54E20", Slot = "4")]
		protected virtual void Update()
		{
		}

		// Token: 0x06005D5F RID: 23903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D5F")]
		[Address(RVA = "0x54D470", Offset = "0x54BE70", VA = "0x18054D470")]
		public CarStopper()
		{
		}

		// Token: 0x040043C0 RID: 17344
		[Token(Token = "0x40043C0")]
		[FieldOffset(Offset = "0x20")]
		public bool isActive;

		// Token: 0x040043C1 RID: 17345
		[Token(Token = "0x40043C1")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		[SerializeField]
		protected Transform blocker;

		// Token: 0x040043C2 RID: 17346
		[Token(Token = "0x40043C2")]
		[FieldOffset(Offset = "0x30")]
		public NavMeshObstacle Obstacle;

		// Token: 0x040043C3 RID: 17347
		[Token(Token = "0x40043C3")]
		[FieldOffset(Offset = "0x38")]
		private float moveTime;
	}
}
