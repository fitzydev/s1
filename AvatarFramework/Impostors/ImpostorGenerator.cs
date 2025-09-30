using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Impostors
{
	// Token: 0x02000A25 RID: 2597
	[Token(Token = "0x2000A25")]
	public class ImpostorGenerator : MonoBehaviour
	{
		// Token: 0x06004742 RID: 18242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004742")]
		[Address(RVA = "0x8F7B80", Offset = "0x8F6580", VA = "0x1808F7B80")]
		public ImpostorGenerator()
		{
		}

		// Token: 0x04003213 RID: 12819
		[Token(Token = "0x4003213")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public Camera ImpostorCamera;

		// Token: 0x04003214 RID: 12820
		[Token(Token = "0x4003214")]
		[FieldOffset(Offset = "0x28")]
		public Avatar Avatar;

		// Token: 0x04003215 RID: 12821
		[Token(Token = "0x4003215")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public List<AvatarSettings> GenerationQueue;

		// Token: 0x04003216 RID: 12822
		[Token(Token = "0x4003216")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Texture2D output;
	}
}
