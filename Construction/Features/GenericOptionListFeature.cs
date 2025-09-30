using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.UI.Construction.Features;
using UnityEngine;

namespace ScheduleOne.Construction.Features
{
	// Token: 0x0200079B RID: 1947
	[Token(Token = "0x200079B")]
	public class GenericOptionListFeature : OptionListFeature
	{
		// Token: 0x06003484 RID: 13444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003484")]
		[Address(RVA = "0x7A2DD0", Offset = "0x7A17D0", VA = "0x1807A2DD0", Slot = "21")]
		public override void Default()
		{
		}

		// Token: 0x06003485 RID: 13445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003485")]
		[Address(RVA = "0x7A2E90", Offset = "0x7A1890", VA = "0x1807A2E90", Slot = "25")]
		protected override List<FI_OptionList.Option> GetOptions()
		{
			return null;
		}

		// Token: 0x06003486 RID: 13446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003486")]
		[Address(RVA = "0x7A32E0", Offset = "0x7A1CE0", VA = "0x1807A32E0", Slot = "26")]
		public override void SelectOption(int optionIndex)
		{
		}

		// Token: 0x06003487 RID: 13447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003487")]
		[Address(RVA = "0x7A3180", Offset = "0x7A1B80", VA = "0x1807A3180", Slot = "28")]
		public override void PurchaseOption(int optionIndex)
		{
		}

		// Token: 0x06003488 RID: 13448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003488")]
		[Address(RVA = "0x7A3430", Offset = "0x7A1E30", VA = "0x1807A3430")]
		public GenericOptionListFeature()
		{
		}

		// Token: 0x06003489 RID: 13449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003489")]
		[Address(RVA = "0x7A3160", Offset = "0x7A1B60", VA = "0x1807A3160", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600348A RID: 13450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600348A")]
		[Address(RVA = "0x7A30F0", Offset = "0x7A1AF0", VA = "0x1807A30F0", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600348B RID: 13451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600348B")]
		[Address(RVA = "0x5B3020", Offset = "0x5B1A20", VA = "0x1805B3020", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600348C RID: 13452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600348C")]
		[Address(RVA = "0x7A2D40", Offset = "0x7A1740", VA = "0x1807A2D40", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x0400248A RID: 9354
		[Token(Token = "0x400248A")]
		[FieldOffset(Offset = "0x158")]
		[Header("References")]
		[SerializeField]
		protected List<GenericOption> options;

		// Token: 0x0400248B RID: 9355
		[Token(Token = "0x400248B")]
		[FieldOffset(Offset = "0x160")]
		private GenericOption visibleOption;

		// Token: 0x0400248C RID: 9356
		[Token(Token = "0x400248C")]
		[FieldOffset(Offset = "0x168")]
		private GenericOption installedOption;

		// Token: 0x0400248D RID: 9357
		[Token(Token = "0x400248D")]
		[FieldOffset(Offset = "0x170")]
		private bool NetworkInitialize___EarlyScheduleOne.Construction.Features.GenericOptionListFeatureAssembly-CSharp.dll_Excuted;

		// Token: 0x0400248E RID: 9358
		[Token(Token = "0x400248E")]
		[FieldOffset(Offset = "0x171")]
		private bool NetworkInitialize__LateScheduleOne.Construction.Features.GenericOptionListFeatureAssembly-CSharp.dll_Excuted;
	}
}
