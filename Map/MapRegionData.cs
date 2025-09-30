using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Economy;
using ScheduleOne.Levelling;
using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000CF0 RID: 3312
	[Token(Token = "0x2000CF0")]
	[Serializable]
	public class MapRegionData
	{
		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x06005DC4 RID: 24004 RVA: 0x000168C0 File Offset: 0x00014AC0
		// (set) Token: 0x06005DC5 RID: 24005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D12")]
		public bool IsUnlocked
		{
			[Token(Token = "0x6005DC4")]
			[Address(RVA = "0x4FA970", Offset = "0x4F9370", VA = "0x1804FA970")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005DC5")]
			[Address(RVA = "0x4FACF0", Offset = "0x4F96F0", VA = "0x1804FACF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005DC6 RID: 24006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DC6")]
		[Address(RVA = "0xA5E580", Offset = "0xA5CF80", VA = "0x180A5E580")]
		public DeliveryLocation GetRandomUnscheduledDeliveryLocation()
		{
			return null;
		}

		// Token: 0x06005DC7 RID: 24007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DC7")]
		[Address(RVA = "0xA5E790", Offset = "0xA5D190", VA = "0x180A5E790")]
		public void SetUnlocked()
		{
		}

		// Token: 0x06005DC8 RID: 24008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DC8")]
		[Address(RVA = "0xA5E460", Offset = "0xA5CE60", VA = "0x180A5E460")]
		public List<EMapRegion> GetAdjacentRegions()
		{
			return null;
		}

		// Token: 0x06005DC9 RID: 24009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DC9")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public MapRegionData()
		{
		}

		// Token: 0x0400441D RID: 17437
		[Token(Token = "0x400441D")]
		[FieldOffset(Offset = "0x10")]
		public EMapRegion Region;

		// Token: 0x0400441E RID: 17438
		[Token(Token = "0x400441E")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		// Token: 0x0400441F RID: 17439
		[Token(Token = "0x400441F")]
		[FieldOffset(Offset = "0x20")]
		public bool UnlockedByDefault;

		// Token: 0x04004420 RID: 17440
		[Token(Token = "0x4004420")]
		[FieldOffset(Offset = "0x24")]
		public FullRank RankRequirement;

		// Token: 0x04004421 RID: 17441
		[Token(Token = "0x4004421")]
		[FieldOffset(Offset = "0x30")]
		public NPC[] StartingNPCs;

		// Token: 0x04004422 RID: 17442
		[Token(Token = "0x4004422")]
		[FieldOffset(Offset = "0x38")]
		public Sprite RegionSprite;

		// Token: 0x04004423 RID: 17443
		[Token(Token = "0x4004423")]
		[FieldOffset(Offset = "0x40")]
		public DeliveryLocation[] RegionDeliveryLocations;

		// Token: 0x04004424 RID: 17444
		[Token(Token = "0x4004424")]
		[FieldOffset(Offset = "0x48")]
		public MapRegionData.RegionContainer[] AdjacentRegions;

		// Token: 0x04004425 RID: 17445
		[Token(Token = "0x4004425")]
		[FieldOffset(Offset = "0x50")]
		public Zone RegionBounds;

		// Token: 0x02000CF1 RID: 3313
		[Token(Token = "0x2000CF1")]
		[Serializable]
		public class RegionContainer
		{
			// Token: 0x06005DCA RID: 24010 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005DCA")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public RegionContainer()
			{
			}

			// Token: 0x04004427 RID: 17447
			[Token(Token = "0x4004427")]
			[FieldOffset(Offset = "0x10")]
			public EMapRegion Region;
		}
	}
}
