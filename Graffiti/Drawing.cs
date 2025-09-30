using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Graffiti
{
	// Token: 0x02000585 RID: 1413
	[Token(Token = "0x2000585")]
	public class Drawing
	{
		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001FBF RID: 8127 RVA: 0x0000A560 File Offset: 0x00008760
		// (set) Token: 0x06001FC0 RID: 8128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000576")]
		public int Width
		{
			[Token(Token = "0x6001FBF")]
			[Address(RVA = "0x42D220", Offset = "0x42BC20", VA = "0x18042D220")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001FC0")]
			[Address(RVA = "0x493F90", Offset = "0x492990", VA = "0x180493F90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06001FC1 RID: 8129 RVA: 0x0000A578 File Offset: 0x00008778
		// (set) Token: 0x06001FC2 RID: 8130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000577")]
		public int Height
		{
			[Token(Token = "0x6001FC1")]
			[Address(RVA = "0x4BE490", Offset = "0x4BCE90", VA = "0x1804BE490")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001FC2")]
			[Address(RVA = "0x670030", Offset = "0x66EA30", VA = "0x180670030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001FC3 RID: 8131 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FC4 RID: 8132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000578")]
		public Texture2D OutputTexture
		{
			[Token(Token = "0x6001FC3")]
			[Address(RVA = "0x42FFB0", Offset = "0x42E9B0", VA = "0x18042FFB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FC4")]
			[Address(RVA = "0x42FFE0", Offset = "0x42E9E0", VA = "0x18042FFE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001FC5 RID: 8133 RVA: 0x0000A590 File Offset: 0x00008790
		[Token(Token = "0x17000579")]
		public int StrokeCount
		{
			[Token(Token = "0x6001FC5")]
			[Address(RVA = "0x66FFF0", Offset = "0x66E9F0", VA = "0x18066FFF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001FC6 RID: 8134 RVA: 0x0000A5A8 File Offset: 0x000087A8
		// (set) Token: 0x06001FC7 RID: 8135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700057A")]
		public int PaintedPixelCount
		{
			[Token(Token = "0x6001FC6")]
			[Address(RVA = "0x47D5C0", Offset = "0x47BFC0", VA = "0x18047D5C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001FC7")]
			[Address(RVA = "0x47D790", Offset = "0x47C190", VA = "0x18047D790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001FC8 RID: 8136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FC8")]
		[Address(RVA = "0x4423A0", Offset = "0x440DA0", VA = "0x1804423A0")]
		public List<SprayStroke> GetStrokes()
		{
			return null;
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FC9")]
		[Address(RVA = "0x66FE50", Offset = "0x66E850", VA = "0x18066FE50")]
		public Drawing(int width, int height, ushort falloffRadius, float[] falloffTable, bool initPixels)
		{
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FCA")]
		[Address(RVA = "0x66FB60", Offset = "0x66E560", VA = "0x18066FB60")]
		public Drawing GetCopy()
		{
			return null;
		}

		// Token: 0x06001FCB RID: 8139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FCB")]
		[Address(RVA = "0x66F780", Offset = "0x66E180", VA = "0x18066F780")]
		public void DrawPaintedPixel(PixelData data, bool applyTexture)
		{
		}

		// Token: 0x06001FCC RID: 8140 RVA: 0x0000A5C0 File Offset: 0x000087C0
		[Token(Token = "0x6001FCC")]
		[Address(RVA = "0x66FDE0", Offset = "0x66E7E0", VA = "0x18066FDE0")]
		[MethodImpl(256)]
		public static Color LerpUnclampedFast(Color a, Color b, float t)
		{
			return default(Color);
		}

		// Token: 0x06001FCD RID: 8141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FCD")]
		[Address(RVA = "0x66F730", Offset = "0x66E130", VA = "0x18066F730")]
		private void ApplyTexture()
		{
		}

		// Token: 0x06001FCE RID: 8142 RVA: 0x0000A5D8 File Offset: 0x000087D8
		[Token(Token = "0x6001FCE")]
		[Address(RVA = "0x66FDC0", Offset = "0x66E7C0", VA = "0x18066FDC0")]
		private bool IsCoordinateInBounds(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06001FCF RID: 8143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FCF")]
		[Address(RVA = "0x66F3F0", Offset = "0x66DDF0", VA = "0x18066F3F0")]
		public void AddStroke(SprayStroke stroke)
		{
		}

		// Token: 0x06001FD0 RID: 8144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FD0")]
		[Address(RVA = "0x66F540", Offset = "0x66DF40", VA = "0x18066F540")]
		public void AddStrokes(List<SprayStroke> newStrokes)
		{
		}

		// Token: 0x04001A14 RID: 6676
		[Token(Token = "0x4001A14")]
		[FieldOffset(Offset = "0x24")]
		private ushort falloffRadius;

		// Token: 0x04001A15 RID: 6677
		[Token(Token = "0x4001A15")]
		[FieldOffset(Offset = "0x28")]
		private float[] falloffTable;

		// Token: 0x04001A16 RID: 6678
		[Token(Token = "0x4001A16")]
		[FieldOffset(Offset = "0x30")]
		private List<SprayStroke> strokes;

		// Token: 0x04001A17 RID: 6679
		[Token(Token = "0x4001A17")]
		[FieldOffset(Offset = "0x38")]
		public Action onTextureChanged;
	}
}
