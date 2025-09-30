using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x02000A13 RID: 2579
	[Token(Token = "0x2000A13")]
	public class CharacterCustomizationShop : MonoBehaviour
	{
		// Token: 0x060046D3 RID: 18131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D3")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public CharacterCustomizationShop()
		{
		}

		// Token: 0x040031A3 RID: 12707
		[Token(Token = "0x40031A3")]
		[FieldOffset(Offset = "0x20")]
		public Transform CameraPosition;

		// Token: 0x040031A4 RID: 12708
		[Token(Token = "0x40031A4")]
		[FieldOffset(Offset = "0x28")]
		public Transform RigContainer;

		// Token: 0x040031A5 RID: 12709
		[Token(Token = "0x40031A5")]
		[FieldOffset(Offset = "0x30")]
		public Avatar AvatarRig;
	}
}
