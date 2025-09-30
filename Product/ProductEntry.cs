using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.Product
{
	// Token: 0x020009BB RID: 2491
	[Token(Token = "0x20009BB")]
	public class ProductEntry : MonoBehaviour
	{
		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06004421 RID: 17441 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004422 RID: 17442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000977")]
		public ProductDefinition Definition
		{
			[Token(Token = "0x6004421")]
			[Address(RVA = "0x42FFC0", Offset = "0x42E9C0", VA = "0x18042FFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004422")]
			[Address(RVA = "0x42FFF0", Offset = "0x42E9F0", VA = "0x18042FFF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004423 RID: 17443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004423")]
		[Address(RVA = "0x895560", Offset = "0x893F60", VA = "0x180895560")]
		public void Initialize(ProductDefinition definition)
		{
		}

		// Token: 0x06004424 RID: 17444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004424")]
		[Address(RVA = "0x8953B0", Offset = "0x893DB0", VA = "0x1808953B0")]
		public void Destroy()
		{
		}

		// Token: 0x06004425 RID: 17445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004425")]
		[Address(RVA = "0x895D10", Offset = "0x894710", VA = "0x180895D10")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004426 RID: 17446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004426")]
		[Address(RVA = "0x895320", Offset = "0x893D20", VA = "0x180895320")]
		private void Clicked()
		{
		}

		// Token: 0x06004427 RID: 17447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004427")]
		[Address(RVA = "0x895430", Offset = "0x893E30", VA = "0x180895430")]
		private void FavouriteClicked()
		{
		}

		// Token: 0x06004428 RID: 17448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004428")]
		[Address(RVA = "0x896310", Offset = "0x894D10", VA = "0x180896310")]
		private void ProductListedOrDelisted(ProductDefinition def)
		{
		}

		// Token: 0x06004429 RID: 17449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004429")]
		[Address(RVA = "0x8966B0", Offset = "0x8950B0", VA = "0x1808966B0")]
		public void UpdateListed()
		{
		}

		// Token: 0x0600442A RID: 17450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600442A")]
		[Address(RVA = "0x896290", Offset = "0x894C90", VA = "0x180896290")]
		private void ProductFavouritedOrUnFavourited(ProductDefinition def)
		{
		}

		// Token: 0x0600442B RID: 17451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600442B")]
		[Address(RVA = "0x896570", Offset = "0x894F70", VA = "0x180896570")]
		public void UpdateFavourited()
		{
		}

		// Token: 0x0600442C RID: 17452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600442C")]
		[Address(RVA = "0x8963C0", Offset = "0x894DC0", VA = "0x1808963C0")]
		public void UpdateDiscovered(ProductDefinition def)
		{
		}

		// Token: 0x0600442D RID: 17453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600442D")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public ProductEntry()
		{
		}

		// Token: 0x04002F9A RID: 12186
		[Token(Token = "0x4002F9A")]
		[FieldOffset(Offset = "0x28")]
		public Color SelectedColor;

		// Token: 0x04002F9B RID: 12187
		[Token(Token = "0x4002F9B")]
		[FieldOffset(Offset = "0x38")]
		public Color DeselectedColor;

		// Token: 0x04002F9C RID: 12188
		[Token(Token = "0x4002F9C")]
		[FieldOffset(Offset = "0x48")]
		public Color FavouritedColor;

		// Token: 0x04002F9D RID: 12189
		[Token(Token = "0x4002F9D")]
		[FieldOffset(Offset = "0x58")]
		public Color UnfavouritedColor;

		// Token: 0x04002F9E RID: 12190
		[Token(Token = "0x4002F9E")]
		[FieldOffset(Offset = "0x68")]
		[Header("References")]
		public Button Button;

		// Token: 0x04002F9F RID: 12191
		[Token(Token = "0x4002F9F")]
		[FieldOffset(Offset = "0x70")]
		public Image Frame;

		// Token: 0x04002FA0 RID: 12192
		[Token(Token = "0x4002FA0")]
		[FieldOffset(Offset = "0x78")]
		public Image Icon;

		// Token: 0x04002FA1 RID: 12193
		[Token(Token = "0x4002FA1")]
		[FieldOffset(Offset = "0x80")]
		public RectTransform Tick;

		// Token: 0x04002FA2 RID: 12194
		[Token(Token = "0x4002FA2")]
		[FieldOffset(Offset = "0x88")]
		public RectTransform Cross;

		// Token: 0x04002FA3 RID: 12195
		[Token(Token = "0x4002FA3")]
		[FieldOffset(Offset = "0x90")]
		public EventTrigger Trigger;

		// Token: 0x04002FA4 RID: 12196
		[Token(Token = "0x4002FA4")]
		[FieldOffset(Offset = "0x98")]
		public Button FavouriteButton;

		// Token: 0x04002FA5 RID: 12197
		[Token(Token = "0x4002FA5")]
		[FieldOffset(Offset = "0xA0")]
		public Image FavouriteIcon;

		// Token: 0x04002FA6 RID: 12198
		[Token(Token = "0x4002FA6")]
		[FieldOffset(Offset = "0xA8")]
		public UnityEvent onHovered;

		// Token: 0x04002FA7 RID: 12199
		[Token(Token = "0x4002FA7")]
		[FieldOffset(Offset = "0xB0")]
		private bool destroyed;
	}
}
