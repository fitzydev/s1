using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000B04 RID: 2820
	[Token(Token = "0x2000B04")]
	public class SaveIndicator : MonoBehaviour
	{
		// Token: 0x06004C9E RID: 19614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C9E")]
		[Address(RVA = "0x8EEA50", Offset = "0x8ED450", VA = "0x1808EEA50")]
		public void Awake()
		{
		}

		// Token: 0x06004C9F RID: 19615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C9F")]
		[Address(RVA = "0x933E30", Offset = "0x932830", VA = "0x180933E30")]
		public void Start()
		{
		}

		// Token: 0x06004CA0 RID: 19616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CA0")]
		[Address(RVA = "0x933D30", Offset = "0x932730", VA = "0x180933D30")]
		public void OnDestroy()
		{
		}

		// Token: 0x06004CA1 RID: 19617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CA1")]
		[Address(RVA = "0x933CB0", Offset = "0x9326B0", VA = "0x180933CB0")]
		public void Display()
		{
		}

		// Token: 0x06004CA2 RID: 19618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CA2")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public SaveIndicator()
		{
		}

		// Token: 0x06004CA3 RID: 19619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CA3")]
		[Address(RVA = "0x933F10", Offset = "0x932910", VA = "0x180933F10")]
		[CompilerGenerated]
		private IEnumerator <Display>g__Routine|6_0()
		{
			return null;
		}

		// Token: 0x0400377A RID: 14202
		[Token(Token = "0x400377A")]
		[FieldOffset(Offset = "0x20")]
		public Canvas Canvas;

		// Token: 0x0400377B RID: 14203
		[Token(Token = "0x400377B")]
		[FieldOffset(Offset = "0x28")]
		public RectTransform Icon;

		// Token: 0x0400377C RID: 14204
		[Token(Token = "0x400377C")]
		[FieldOffset(Offset = "0x30")]
		public Animation Anim;
	}
}
