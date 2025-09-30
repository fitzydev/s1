using System;
using System.Collections.Generic;
using EasyButtons;
using Il2CppDummyDll;
using ScheduleOne.Packaging;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x0200074F RID: 1871
	[Token(Token = "0x200074F")]
	public class IconGenerator : Singleton<IconGenerator>
	{
		// Token: 0x060032CE RID: 13006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032CE")]
		[Address(RVA = "0x7782F0", Offset = "0x776CF0", VA = "0x1807782F0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x060032CF RID: 13007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032CF")]
		[Address(RVA = "0x778440", Offset = "0x776E40", VA = "0x180778440")]
		[Button]
		public void GenerateIcon()
		{
		}

		// Token: 0x060032D0 RID: 13008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032D0")]
		[Address(RVA = "0x778700", Offset = "0x777100", VA = "0x180778700")]
		public Texture2D GeneratePackagingIcon(string packagingID, string productID)
		{
			return null;
		}

		// Token: 0x060032D1 RID: 13009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032D1")]
		[Address(RVA = "0x778C40", Offset = "0x777640", VA = "0x180778C40")]
		public Texture2D GetTexture(Transform model)
		{
			return null;
		}

		// Token: 0x060032D2 RID: 13010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032D2")]
		[Address(RVA = "0x778F60", Offset = "0x777960", VA = "0x180778F60")]
		public IconGenerator()
		{
		}

		// Token: 0x04002339 RID: 9017
		[Token(Token = "0x4002339")]
		[FieldOffset(Offset = "0x28")]
		public int IconSize;

		// Token: 0x0400233A RID: 9018
		[Token(Token = "0x400233A")]
		[FieldOffset(Offset = "0x30")]
		public string OutputPath;

		// Token: 0x0400233B RID: 9019
		[Token(Token = "0x400233B")]
		[FieldOffset(Offset = "0x38")]
		public bool ModifyLighting;

		// Token: 0x0400233C RID: 9020
		[Token(Token = "0x400233C")]
		[FieldOffset(Offset = "0x40")]
		[Header("References")]
		public Registry Registry;

		// Token: 0x0400233D RID: 9021
		[Token(Token = "0x400233D")]
		[FieldOffset(Offset = "0x48")]
		public Camera CameraPosition;

		// Token: 0x0400233E RID: 9022
		[Token(Token = "0x400233E")]
		[FieldOffset(Offset = "0x50")]
		public Transform MainContainer;

		// Token: 0x0400233F RID: 9023
		[Token(Token = "0x400233F")]
		[FieldOffset(Offset = "0x58")]
		public Transform ItemContainer;

		// Token: 0x04002340 RID: 9024
		[Token(Token = "0x4002340")]
		[FieldOffset(Offset = "0x60")]
		public GameObject Canvas;

		// Token: 0x04002341 RID: 9025
		[Token(Token = "0x4002341")]
		[FieldOffset(Offset = "0x68")]
		public List<IconGenerator.PackagingVisuals> Visuals;

		// Token: 0x02000750 RID: 1872
		[Token(Token = "0x2000750")]
		[Serializable]
		public class PackagingVisuals
		{
			// Token: 0x060032D3 RID: 13011 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60032D3")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public PackagingVisuals()
			{
			}

			// Token: 0x04002342 RID: 9026
			[Token(Token = "0x4002342")]
			[FieldOffset(Offset = "0x10")]
			public string PackagingID;

			// Token: 0x04002343 RID: 9027
			[Token(Token = "0x4002343")]
			[FieldOffset(Offset = "0x18")]
			public FilledPackagingVisuals Visuals;
		}
	}
}
