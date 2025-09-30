using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Product.Packaging;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x02000997 RID: 2455
	[Token(Token = "0x2000997")]
	public class ProductIconManager : Singleton<ProductIconManager>
	{
		// Token: 0x060042F9 RID: 17145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F9")]
		[Address(RVA = "0x883100", Offset = "0x881B00", VA = "0x180883100")]
		public Sprite GetIcon(string productID, string packagingID, bool ignoreError = false)
		{
			return null;
		}

		// Token: 0x060042FA RID: 17146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042FA")]
		[Address(RVA = "0x882B20", Offset = "0x881520", VA = "0x180882B20")]
		public Sprite GenerateIcons(string productID)
		{
			return null;
		}

		// Token: 0x060042FB RID: 17147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042FB")]
		[Address(RVA = "0x8830D0", Offset = "0x881AD0", VA = "0x1808830D0")]
		private Texture2D GenerateProductTexture(string productID, string packagingID)
		{
			return null;
		}

		// Token: 0x060042FC RID: 17148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042FC")]
		[Address(RVA = "0x883340", Offset = "0x881D40", VA = "0x180883340")]
		public ProductIconManager()
		{
		}

		// Token: 0x04002F0D RID: 12045
		[Token(Token = "0x4002F0D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<ProductIconManager.ProductIcon> icons;

		// Token: 0x04002F0E RID: 12046
		[Token(Token = "0x4002F0E")]
		[FieldOffset(Offset = "0x30")]
		[Header("Product and packaging")]
		public IconGenerator IconGenerator;

		// Token: 0x04002F0F RID: 12047
		[Token(Token = "0x4002F0F")]
		[FieldOffset(Offset = "0x38")]
		public string IconContainerPath;

		// Token: 0x04002F10 RID: 12048
		[Token(Token = "0x4002F10")]
		[FieldOffset(Offset = "0x40")]
		public ProductDefinition[] Products;

		// Token: 0x04002F11 RID: 12049
		[Token(Token = "0x4002F11")]
		[FieldOffset(Offset = "0x48")]
		public PackagingDefinition[] Packaging;

		// Token: 0x02000998 RID: 2456
		[Token(Token = "0x2000998")]
		[Serializable]
		public class ProductIcon
		{
			// Token: 0x060042FD RID: 17149 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042FD")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public ProductIcon()
			{
			}

			// Token: 0x04002F12 RID: 12050
			[Token(Token = "0x4002F12")]
			[FieldOffset(Offset = "0x10")]
			public string ProductID;

			// Token: 0x04002F13 RID: 12051
			[Token(Token = "0x4002F13")]
			[FieldOffset(Offset = "0x18")]
			public string PackagingID;

			// Token: 0x04002F14 RID: 12052
			[Token(Token = "0x4002F14")]
			[FieldOffset(Offset = "0x20")]
			public Sprite Icon;
		}
	}
}
