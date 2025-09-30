using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.Interaction
{
	// Token: 0x02000583 RID: 1411
	[Token(Token = "0x2000583")]
	public class WorldSpaceLabel
	{
		// Token: 0x06001FBA RID: 8122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FBA")]
		[Address(RVA = "0x685010", Offset = "0x683A10", VA = "0x180685010")]
		public WorldSpaceLabel(string _text, Vector3 _position)
		{
		}

		// Token: 0x06001FBB RID: 8123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FBB")]
		[Address(RVA = "0x684C50", Offset = "0x683650", VA = "0x180684C50")]
		public void RefreshDisplay()
		{
		}

		// Token: 0x06001FBC RID: 8124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FBC")]
		[Address(RVA = "0x684B50", Offset = "0x683550", VA = "0x180684B50")]
		public void Destroy()
		{
		}

		// Token: 0x04001A06 RID: 6662
		[Token(Token = "0x4001A06")]
		[FieldOffset(Offset = "0x10")]
		public string text;

		// Token: 0x04001A07 RID: 6663
		[Token(Token = "0x4001A07")]
		[FieldOffset(Offset = "0x18")]
		public Color32 color;

		// Token: 0x04001A08 RID: 6664
		[Token(Token = "0x4001A08")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		// Token: 0x04001A09 RID: 6665
		[Token(Token = "0x4001A09")]
		[FieldOffset(Offset = "0x28")]
		public float scale;

		// Token: 0x04001A0A RID: 6666
		[Token(Token = "0x4001A0A")]
		[FieldOffset(Offset = "0x30")]
		public RectTransform rect;

		// Token: 0x04001A0B RID: 6667
		[Token(Token = "0x4001A0B")]
		[FieldOffset(Offset = "0x38")]
		public Text textComp;

		// Token: 0x04001A0C RID: 6668
		[Token(Token = "0x4001A0C")]
		[FieldOffset(Offset = "0x40")]
		public bool active;
	}
}
