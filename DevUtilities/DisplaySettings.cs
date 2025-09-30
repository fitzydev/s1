using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000773 RID: 1907
	[Token(Token = "0x2000773")]
	[Serializable]
	public struct DisplaySettings
	{
		// Token: 0x0600338D RID: 13197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600338D")]
		[Address(RVA = "0x776FA0", Offset = "0x7759A0", VA = "0x180776FA0")]
		public static List<Resolution> GetResolutions()
		{
			return null;
		}

		// Token: 0x040023C9 RID: 9161
		[Token(Token = "0x40023C9")]
		[FieldOffset(Offset = "0x0")]
		public int ResolutionIndex;

		// Token: 0x040023CA RID: 9162
		[Token(Token = "0x40023CA")]
		[FieldOffset(Offset = "0x4")]
		public DisplaySettings.EDisplayMode DisplayMode;

		// Token: 0x040023CB RID: 9163
		[Token(Token = "0x40023CB")]
		[FieldOffset(Offset = "0x8")]
		public bool VSync;

		// Token: 0x040023CC RID: 9164
		[Token(Token = "0x40023CC")]
		[FieldOffset(Offset = "0xC")]
		public int TargetFPS;

		// Token: 0x040023CD RID: 9165
		[Token(Token = "0x40023CD")]
		[FieldOffset(Offset = "0x10")]
		public float UIScale;

		// Token: 0x040023CE RID: 9166
		[Token(Token = "0x40023CE")]
		[FieldOffset(Offset = "0x14")]
		public float CameraBobbing;

		// Token: 0x040023CF RID: 9167
		[Token(Token = "0x40023CF")]
		[FieldOffset(Offset = "0x18")]
		public int ActiveDisplayIndex;

		// Token: 0x02000774 RID: 1908
		[Token(Token = "0x2000774")]
		public enum EDisplayMode
		{
			// Token: 0x040023D1 RID: 9169
			[Token(Token = "0x40023D1")]
			Windowed,
			// Token: 0x040023D2 RID: 9170
			[Token(Token = "0x40023D2")]
			FullscreenWindow,
			// Token: 0x040023D3 RID: 9171
			[Token(Token = "0x40023D3")]
			ExclusiveFullscreen
		}
	}
}
