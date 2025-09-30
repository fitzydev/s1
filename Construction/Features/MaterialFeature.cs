using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.UI.Construction.Features;
using UnityEngine;

namespace ScheduleOne.Construction.Features
{
	// Token: 0x0200079C RID: 1948
	[Token(Token = "0x200079C")]
	public class MaterialFeature : OptionListFeature
	{
		// Token: 0x0600348D RID: 13453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600348D")]
		[Address(RVA = "0x7A4BF0", Offset = "0x7A35F0", VA = "0x1807A4BF0", Slot = "26")]
		public override void SelectOption(int optionIndex)
		{
		}

		// Token: 0x0600348E RID: 13454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600348E")]
		[Address(RVA = "0x7A4880", Offset = "0x7A3280", VA = "0x1807A4880")]
		private void ApplyMaterial(MaterialFeature.NamedMaterial mat)
		{
		}

		// Token: 0x0600348F RID: 13455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600348F")]
		[Address(RVA = "0x7A4930", Offset = "0x7A3330", VA = "0x1807A4930", Slot = "25")]
		protected override List<FI_OptionList.Option> GetOptions()
		{
			return null;
		}

		// Token: 0x06003490 RID: 13456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003490")]
		[Address(RVA = "0x7A4CE0", Offset = "0x7A36E0", VA = "0x1807A4CE0")]
		public MaterialFeature()
		{
		}

		// Token: 0x06003491 RID: 13457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003491")]
		[Address(RVA = "0x7A4BD0", Offset = "0x7A35D0", VA = "0x1807A4BD0", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003492 RID: 13458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003492")]
		[Address(RVA = "0x7A4B60", Offset = "0x7A3560", VA = "0x1807A4B60", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003493 RID: 13459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003493")]
		[Address(RVA = "0x5B3020", Offset = "0x5B1A20", VA = "0x1805B3020", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003494 RID: 13460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003494")]
		[Address(RVA = "0x7A2D40", Offset = "0x7A1740", VA = "0x1807A2D40", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x0400248F RID: 9359
		[Token(Token = "0x400248F")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		[Header("References")]
		protected List<MeshRenderer> materialTargets;

		// Token: 0x04002490 RID: 9360
		[Token(Token = "0x4002490")]
		[FieldOffset(Offset = "0x160")]
		[Header("Material settings")]
		public List<MaterialFeature.NamedMaterial> materials;

		// Token: 0x04002491 RID: 9361
		[Token(Token = "0x4002491")]
		[FieldOffset(Offset = "0x168")]
		private bool NetworkInitialize___EarlyScheduleOne.Construction.Features.MaterialFeatureAssembly-CSharp.dll_Excuted;

		// Token: 0x04002492 RID: 9362
		[Token(Token = "0x4002492")]
		[FieldOffset(Offset = "0x169")]
		private bool NetworkInitialize__LateScheduleOne.Construction.Features.MaterialFeatureAssembly-CSharp.dll_Excuted;

		// Token: 0x0200079D RID: 1949
		[Token(Token = "0x200079D")]
		[Serializable]
		public class NamedMaterial
		{
			// Token: 0x06003495 RID: 13461 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003495")]
			[Address(RVA = "0x7A4E00", Offset = "0x7A3800", VA = "0x1807A4E00")]
			public NamedMaterial()
			{
			}

			// Token: 0x04002493 RID: 9363
			[Token(Token = "0x4002493")]
			[FieldOffset(Offset = "0x10")]
			public string matName;

			// Token: 0x04002494 RID: 9364
			[Token(Token = "0x4002494")]
			[FieldOffset(Offset = "0x18")]
			public Color buttonColor;

			// Token: 0x04002495 RID: 9365
			[Token(Token = "0x4002495")]
			[FieldOffset(Offset = "0x28")]
			public Material mat;

			// Token: 0x04002496 RID: 9366
			[Token(Token = "0x4002496")]
			[FieldOffset(Offset = "0x30")]
			public float price;
		}
	}
}
