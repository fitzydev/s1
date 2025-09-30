using System;
using Il2CppDummyDll;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000777 RID: 1911
	[Token(Token = "0x2000777")]
	[Serializable]
	public class GraphicsSettings
	{
		// Token: 0x06003391 RID: 13201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003391")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public GraphicsSettings()
		{
		}

		// Token: 0x040023D8 RID: 9176
		[Token(Token = "0x40023D8")]
		[FieldOffset(Offset = "0x10")]
		public GraphicsSettings.EGraphicsQuality GraphicsQuality;

		// Token: 0x040023D9 RID: 9177
		[Token(Token = "0x40023D9")]
		[FieldOffset(Offset = "0x14")]
		public GraphicsSettings.EAntiAliasingMode AntiAliasingMode;

		// Token: 0x040023DA RID: 9178
		[Token(Token = "0x40023DA")]
		[FieldOffset(Offset = "0x18")]
		public float FOV;

		// Token: 0x040023DB RID: 9179
		[Token(Token = "0x40023DB")]
		[FieldOffset(Offset = "0x1C")]
		public bool SSAO;

		// Token: 0x040023DC RID: 9180
		[Token(Token = "0x40023DC")]
		[FieldOffset(Offset = "0x1D")]
		public bool GodRays;

		// Token: 0x02000778 RID: 1912
		[Token(Token = "0x2000778")]
		public enum EAntiAliasingMode
		{
			// Token: 0x040023DE RID: 9182
			[Token(Token = "0x40023DE")]
			Off,
			// Token: 0x040023DF RID: 9183
			[Token(Token = "0x40023DF")]
			FXAA,
			// Token: 0x040023E0 RID: 9184
			[Token(Token = "0x40023E0")]
			SMAA
		}

		// Token: 0x02000779 RID: 1913
		[Token(Token = "0x2000779")]
		public enum EGraphicsQuality
		{
			// Token: 0x040023E2 RID: 9186
			[Token(Token = "0x40023E2")]
			Low,
			// Token: 0x040023E3 RID: 9187
			[Token(Token = "0x40023E3")]
			Medium,
			// Token: 0x040023E4 RID: 9188
			[Token(Token = "0x40023E4")]
			High,
			// Token: 0x040023E5 RID: 9189
			[Token(Token = "0x40023E5")]
			Ultra
		}
	}
}
