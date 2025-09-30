using System;
using System.Runtime.InteropServices;
using FishNet.Serializing.Helping;
using Il2CppDummyDll;
using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;
using ScheduleOne.NPCs;
using ScheduleOne.Packaging;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Product.Packaging;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x0200099B RID: 2459
	[Token(Token = "0x200099B")]
	[Serializable]
	public class ProductItemInstance : QualityItemInstance
	{
		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06004302 RID: 17154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000960")]
		[CodegenExclude]
		public PackagingDefinition AppliedPackaging
		{
			[Token(Token = "0x6004302")]
			[Address(RVA = "0x884E10", Offset = "0x883810", VA = "0x180884E10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06004303 RID: 17155 RVA: 0x00011A00 File Offset: 0x0000FC00
		[Token(Token = "0x17000961")]
		[CodegenExclude]
		public int Amount
		{
			[Token(Token = "0x6004303")]
			[Address(RVA = "0x884D70", Offset = "0x883770", VA = "0x180884D70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06004304 RID: 17156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000962")]
		public override string Name
		{
			[Token(Token = "0x6004304")]
			[Address(RVA = "0x885100", Offset = "0x883B00", VA = "0x180885100", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06004305 RID: 17157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000963")]
		[CodegenExclude]
		public override Equippable Equippable
		{
			[Token(Token = "0x6004305")]
			[Address(RVA = "0x884200", Offset = "0x882C00", VA = "0x180884200", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06004306 RID: 17158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000964")]
		[CodegenExclude]
		public override StoredItem StoredItem
		{
			[Token(Token = "0x6004306")]
			[Address(RVA = "0x8851B0", Offset = "0x883BB0", VA = "0x1808851B0", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06004307 RID: 17159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000965")]
		[CodegenExclude]
		public override Sprite Icon
		{
			[Token(Token = "0x6004307")]
			[Address(RVA = "0x884FE0", Offset = "0x8839E0", VA = "0x180884FE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004308 RID: 17160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004308")]
		[Address(RVA = "0x87B650", Offset = "0x87A050", VA = "0x18087B650")]
		public ProductItemInstance()
		{
		}

		// Token: 0x06004309 RID: 17161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004309")]
		[Address(RVA = "0x884C60", Offset = "0x883660", VA = "0x180884C60")]
		public ProductItemInstance(ItemDefinition definition, int quantity, EQuality quality, [Optional] PackagingDefinition _packaging)
		{
		}

		// Token: 0x0600430A RID: 17162 RVA: 0x00011A18 File Offset: 0x0000FC18
		[Token(Token = "0x600430A")]
		[Address(RVA = "0x8838F0", Offset = "0x8822F0", VA = "0x1808838F0", Slot = "11")]
		public override bool CanStackWith(ItemInstance other, bool checkQuantities = true)
		{
			return default(bool);
		}

		// Token: 0x0600430B RID: 17163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600430B")]
		[Address(RVA = "0x884150", Offset = "0x882B50", VA = "0x180884150", Slot = "12")]
		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		// Token: 0x0600430C RID: 17164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600430C")]
		[Address(RVA = "0x884B70", Offset = "0x883570", VA = "0x180884B70", Slot = "17")]
		public virtual void SetPackaging(PackagingDefinition def)
		{
		}

		// Token: 0x0600430D RID: 17165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600430D")]
		[Address(RVA = "0x884200", Offset = "0x882C00", VA = "0x180884200")]
		private Equippable GetEquippable()
		{
			return null;
		}

		// Token: 0x0600430E RID: 17166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600430E")]
		[Address(RVA = "0x884940", Offset = "0x883340", VA = "0x180884940")]
		private StoredItem GetStoredItem()
		{
			return null;
		}

		// Token: 0x0600430F RID: 17167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600430F")]
		[Address(RVA = "0x884C40", Offset = "0x883640", VA = "0x180884C40", Slot = "18")]
		public virtual void SetupPackagingVisuals(FilledPackagingVisuals visuals)
		{
		}

		// Token: 0x06004310 RID: 17168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004310")]
		[Address(RVA = "0x8842A0", Offset = "0x882CA0", VA = "0x1808842A0")]
		private Sprite GetIcon()
		{
			return null;
		}

		// Token: 0x06004311 RID: 17169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004311")]
		[Address(RVA = "0x8843B0", Offset = "0x882DB0", VA = "0x1808843B0", Slot = "14")]
		public override ItemData GetItemData()
		{
			return null;
		}

		// Token: 0x06004312 RID: 17170 RVA: 0x00011A30 File Offset: 0x0000FC30
		[Token(Token = "0x6004312")]
		[Address(RVA = "0x884000", Offset = "0x882A00", VA = "0x180884000", Slot = "19")]
		public virtual float GetAddictiveness()
		{
			return 0f;
		}

		// Token: 0x06004313 RID: 17171 RVA: 0x00011A48 File Offset: 0x0000FC48
		[Token(Token = "0x6004313")]
		[Address(RVA = "0x884640", Offset = "0x883040", VA = "0x180884640")]
		public float GetSimilarity(ProductDefinition other, EQuality quality)
		{
			return 0f;
		}

		// Token: 0x06004314 RID: 17172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004314")]
		[Address(RVA = "0x8833F0", Offset = "0x881DF0", VA = "0x1808833F0", Slot = "20")]
		public virtual void ApplyEffectsToNPC(NPC npc)
		{
		}

		// Token: 0x06004315 RID: 17173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004315")]
		[Address(RVA = "0x883B00", Offset = "0x882500", VA = "0x180883B00", Slot = "21")]
		public virtual void ClearEffectsFromNPC(NPC npc)
		{
		}

		// Token: 0x06004316 RID: 17174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004316")]
		[Address(RVA = "0x883670", Offset = "0x882070", VA = "0x180883670", Slot = "22")]
		public virtual void ApplyEffectsToPlayer(Player player)
		{
		}

		// Token: 0x06004317 RID: 17175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004317")]
		[Address(RVA = "0x883D80", Offset = "0x882780", VA = "0x180883D80", Slot = "23")]
		public virtual void ClearEffectsFromPlayer(Player Player)
		{
		}

		// Token: 0x06004318 RID: 17176 RVA: 0x00011A60 File Offset: 0x0000FC60
		[Token(Token = "0x6004318")]
		[Address(RVA = "0x884480", Offset = "0x882E80", VA = "0x180884480", Slot = "15")]
		public override float GetMonetaryValue()
		{
			return 0f;
		}

		// Token: 0x04002F18 RID: 12056
		[Token(Token = "0x4002F18")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string PackagingID;

		// Token: 0x04002F19 RID: 12057
		[Token(Token = "0x4002F19")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[CodegenExclude]
		private PackagingDefinition packaging;
	}
}
