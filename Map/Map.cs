using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Levelling;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000CF6 RID: 3318
	[Token(Token = "0x2000CF6")]
	public class Map : Singleton<Map>
	{
		// Token: 0x06005DEE RID: 24046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DEE")]
		[Address(RVA = "0xA5E8B0", Offset = "0xA5D2B0", VA = "0x180A5E8B0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005DEF RID: 24047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DEF")]
		[Address(RVA = "0xA5F180", Offset = "0xA5DB80", VA = "0x180A5F180", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06005DF0 RID: 24048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DF0")]
		[Address(RVA = "0xA5F000", Offset = "0xA5DA00", VA = "0x180A5F000")]
		private void OnRankUp(FullRank old, FullRank newRank)
		{
		}

		// Token: 0x06005DF1 RID: 24049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DF1")]
		[Address(RVA = "0xA5ED00", Offset = "0xA5D700", VA = "0x180A5ED00")]
		public MapRegionData GetRegionData(EMapRegion region)
		{
			return null;
		}

		// Token: 0x06005DF2 RID: 24050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DF2")]
		[Address(RVA = "0xA5EF20", Offset = "0xA5D920", VA = "0x180A5EF20")]
		public List<EMapRegion> GetUnlockedRegions()
		{
			return null;
		}

		// Token: 0x06005DF3 RID: 24051 RVA: 0x00016908 File Offset: 0x00014B08
		[Token(Token = "0x6005DF3")]
		[Address(RVA = "0xA5EDD0", Offset = "0xA5D7D0", VA = "0x180A5EDD0")]
		public EMapRegion GetRegionFromPosition(Vector3 position)
		{
			return EMapRegion.Northtown;
		}

		// Token: 0x06005DF4 RID: 24052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DF4")]
		[Address(RVA = "0xA5F380", Offset = "0xA5DD80", VA = "0x180A5F380")]
		public Map()
		{
		}

		// Token: 0x04004448 RID: 17480
		[Token(Token = "0x4004448")]
		public const EMapRegion FINAL_REGION = EMapRegion.Uptown;

		// Token: 0x04004449 RID: 17481
		[Token(Token = "0x4004449")]
		[FieldOffset(Offset = "0x28")]
		public bool UNLOCK_ALL_REGIONS;

		// Token: 0x0400444A RID: 17482
		[Token(Token = "0x400444A")]
		[FieldOffset(Offset = "0x30")]
		public MapRegionData[] Regions;

		// Token: 0x0400444B RID: 17483
		[Token(Token = "0x400444B")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public PoliceStation PoliceStation;

		// Token: 0x0400444C RID: 17484
		[Token(Token = "0x400444C")]
		[FieldOffset(Offset = "0x40")]
		public MedicalCentre MedicalCentre;

		// Token: 0x0400444D RID: 17485
		[Token(Token = "0x400444D")]
		[FieldOffset(Offset = "0x48")]
		public Transform TreeBounds;
	}
}
