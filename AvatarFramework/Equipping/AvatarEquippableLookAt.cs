using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x02000A43 RID: 2627
	[Token(Token = "0x2000A43")]
	[RequireComponent(typeof(AvatarEquippable))]
	public class AvatarEquippableLookAt : MonoBehaviour
	{
		// Token: 0x060047E6 RID: 18406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047E6")]
		[Address(RVA = "0x8ECF50", Offset = "0x8EB950", VA = "0x1808ECF50")]
		private void Start()
		{
		}

		// Token: 0x060047E7 RID: 18407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047E7")]
		[Address(RVA = "0x8ECE80", Offset = "0x8EB880", VA = "0x1808ECE80")]
		private void LateUpdate()
		{
		}

		// Token: 0x060047E8 RID: 18408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047E8")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public AvatarEquippableLookAt()
		{
		}

		// Token: 0x040032D7 RID: 13015
		[Token(Token = "0x40032D7")]
		[FieldOffset(Offset = "0x20")]
		public int Priority;

		// Token: 0x040032D8 RID: 13016
		[Token(Token = "0x40032D8")]
		[FieldOffset(Offset = "0x28")]
		private Avatar avatar;
	}
}
