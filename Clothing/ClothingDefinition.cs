using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Clothing
{
	// Token: 0x020007B9 RID: 1977
	[Token(Token = "0x20007B9")]
	[CreateAssetMenu(fileName = "ClothingDefinition", menuName = "ScriptableObjects/ClothingDefinition", order = 1)]
	[Serializable]
	public class ClothingDefinition : StorableItemDefinition
	{
		// Token: 0x06003587 RID: 13703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003587")]
		[Address(RVA = "0x78FB80", Offset = "0x78E580", VA = "0x18078FB80", Slot = "4")]
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}

		// Token: 0x06003588 RID: 13704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003588")]
		[Address(RVA = "0x78FC00", Offset = "0x78E600", VA = "0x18078FC00")]
		public ClothingDefinition()
		{
		}

		// Token: 0x04002532 RID: 9522
		[Token(Token = "0x4002532")]
		[FieldOffset(Offset = "0xB8")]
		public EClothingSlot Slot;

		// Token: 0x04002533 RID: 9523
		[Token(Token = "0x4002533")]
		[FieldOffset(Offset = "0xBC")]
		public EClothingApplicationType ApplicationType;

		// Token: 0x04002534 RID: 9524
		[Token(Token = "0x4002534")]
		[FieldOffset(Offset = "0xC0")]
		public string ClothingAssetPath;

		// Token: 0x04002535 RID: 9525
		[Token(Token = "0x4002535")]
		[FieldOffset(Offset = "0xC8")]
		public bool Colorable;

		// Token: 0x04002536 RID: 9526
		[Token(Token = "0x4002536")]
		[FieldOffset(Offset = "0xCC")]
		public EClothingColor DefaultColor;

		// Token: 0x04002537 RID: 9527
		[Token(Token = "0x4002537")]
		[FieldOffset(Offset = "0xD0")]
		public List<EClothingSlot> SlotsToBlock;
	}
}
