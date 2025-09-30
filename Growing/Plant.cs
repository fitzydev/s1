using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Object;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Trash;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Growing
{
	// Token: 0x0200092A RID: 2346
	[Token(Token = "0x200092A")]
	public class Plant : MonoBehaviour
	{
		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06004032 RID: 16434 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004033 RID: 16435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008FD")]
		public Pot Pot
		{
			[Token(Token = "0x6004032")]
			[Address(RVA = "0x42FFC0", Offset = "0x42E9C0", VA = "0x18042FFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004033")]
			[Address(RVA = "0x42FFF0", Offset = "0x42E9F0", VA = "0x18042FFF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06004034 RID: 16436 RVA: 0x00011070 File Offset: 0x0000F270
		// (set) Token: 0x06004035 RID: 16437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008FE")]
		public float NormalizedGrowthProgress
		{
			[Token(Token = "0x6004034")]
			[Address(RVA = "0x485C70", Offset = "0x484670", VA = "0x180485C70")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004035")]
			[Address(RVA = "0x485CB0", Offset = "0x4846B0", VA = "0x180485CB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06004036 RID: 16438 RVA: 0x00011088 File Offset: 0x0000F288
		[Token(Token = "0x170008FF")]
		public bool IsFullyGrown
		{
			[Token(Token = "0x6004036")]
			[Address(RVA = "0x872610", Offset = "0x871010", VA = "0x180872610")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06004037 RID: 16439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000900")]
		public PlantGrowthStage FinalGrowthStage
		{
			[Token(Token = "0x6004037")]
			[Address(RVA = "0x8725D0", Offset = "0x870FD0", VA = "0x1808725D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004038 RID: 16440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004038")]
		[Address(RVA = "0x871E20", Offset = "0x870820", VA = "0x180871E20", Slot = "4")]
		public virtual void Initialize(NetworkObject pot, float growthProgress = 0f, float yieldLevel = 0f, float qualityLevel = 0f)
		{
		}

		// Token: 0x06004039 RID: 16441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004039")]
		[Address(RVA = "0x8712E0", Offset = "0x86FCE0", VA = "0x1808712E0", Slot = "5")]
		public virtual void Destroy(bool dropScraps = false)
		{
		}

		// Token: 0x0600403A RID: 16442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600403A")]
		[Address(RVA = "0x872040", Offset = "0x870A40", VA = "0x180872040", Slot = "6")]
		public virtual void MinPass()
		{
		}

		// Token: 0x0600403B RID: 16443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600403B")]
		[Address(RVA = "0x872350", Offset = "0x870D50", VA = "0x180872350", Slot = "7")]
		public virtual void SetNormalizedGrowthProgress(float progress)
		{
		}

		// Token: 0x0600403C RID: 16444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600403C")]
		[Address(RVA = "0x872410", Offset = "0x870E10", VA = "0x180872410", Slot = "8")]
		protected virtual void UpdateVisuals()
		{
		}

		// Token: 0x0600403D RID: 16445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600403D")]
		[Address(RVA = "0x8721F0", Offset = "0x870BF0", VA = "0x1808721F0", Slot = "9")]
		public virtual void SetHarvestableActive(int index, bool active)
		{
		}

		// Token: 0x0600403E RID: 16446 RVA: 0x000110A0 File Offset: 0x0000F2A0
		[Token(Token = "0x600403E")]
		[Address(RVA = "0x871FE0", Offset = "0x8709E0", VA = "0x180871FE0")]
		public bool IsHarvestableActive(int index)
		{
			return default(bool);
		}

		// Token: 0x0600403F RID: 16447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600403F")]
		[Address(RVA = "0x871B20", Offset = "0x870520", VA = "0x180871B20")]
		private void GrowthDone()
		{
		}

		// Token: 0x06004040 RID: 16448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004040")]
		[Address(RVA = "0x871770", Offset = "0x870170", VA = "0x180871770")]
		private List<int> GenerateUniqueIntegers(int min, int max, int count)
		{
			return null;
		}

		// Token: 0x06004041 RID: 16449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004041")]
		[Address(RVA = "0x8723D0", Offset = "0x870DD0", VA = "0x1808723D0")]
		public void SetVisible(bool vis)
		{
		}

		// Token: 0x06004042 RID: 16450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004042")]
		[Address(RVA = "0x8719C0", Offset = "0x8703C0", VA = "0x1808719C0", Slot = "10")]
		public virtual ItemInstance GetHarvestedProduct(int quantity = 1)
		{
			return null;
		}

		// Token: 0x06004043 RID: 16451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004043")]
		[Address(RVA = "0x871A20", Offset = "0x870420", VA = "0x180871A20")]
		public PlantData GetPlantData()
		{
			return null;
		}

		// Token: 0x06004044 RID: 16452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004044")]
		[Address(RVA = "0x872510", Offset = "0x870F10", VA = "0x180872510")]
		public Plant()
		{
		}

		// Token: 0x04002D19 RID: 11545
		[Token(Token = "0x4002D19")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Transform VisualsContainer;

		// Token: 0x04002D1A RID: 11546
		[Token(Token = "0x4002D1A")]
		[FieldOffset(Offset = "0x38")]
		public PlantGrowthStage[] GrowthStages;

		// Token: 0x04002D1B RID: 11547
		[Token(Token = "0x4002D1B")]
		[FieldOffset(Offset = "0x40")]
		public Collider Collider;

		// Token: 0x04002D1C RID: 11548
		[Token(Token = "0x4002D1C")]
		[FieldOffset(Offset = "0x48")]
		public AudioSourceController SnipSound;

		// Token: 0x04002D1D RID: 11549
		[Token(Token = "0x4002D1D")]
		[FieldOffset(Offset = "0x50")]
		public AudioSourceController DestroySound;

		// Token: 0x04002D1E RID: 11550
		[Token(Token = "0x4002D1E")]
		[FieldOffset(Offset = "0x58")]
		public ParticleSystem FullyGrownParticles;

		// Token: 0x04002D1F RID: 11551
		[Token(Token = "0x4002D1F")]
		[FieldOffset(Offset = "0x60")]
		[Header("Settings")]
		public SeedDefinition SeedDefinition;

		// Token: 0x04002D20 RID: 11552
		[Token(Token = "0x4002D20")]
		[FieldOffset(Offset = "0x68")]
		public int GrowthTime;

		// Token: 0x04002D21 RID: 11553
		[Token(Token = "0x4002D21")]
		[FieldOffset(Offset = "0x6C")]
		public float BaseYieldLevel;

		// Token: 0x04002D22 RID: 11554
		[Token(Token = "0x4002D22")]
		[FieldOffset(Offset = "0x70")]
		public float BaseQualityLevel;

		// Token: 0x04002D23 RID: 11555
		[Token(Token = "0x4002D23")]
		[FieldOffset(Offset = "0x78")]
		public string HarvestTarget;

		// Token: 0x04002D24 RID: 11556
		[Token(Token = "0x4002D24")]
		[FieldOffset(Offset = "0x80")]
		[Header("Trash")]
		public TrashItem PlantScrapPrefab;

		// Token: 0x04002D25 RID: 11557
		[Token(Token = "0x4002D25")]
		[FieldOffset(Offset = "0x88")]
		public UnityEvent onGrowthDone;

		// Token: 0x04002D26 RID: 11558
		[Token(Token = "0x4002D26")]
		[FieldOffset(Offset = "0x90")]
		[Header("Plant data")]
		public float YieldLevel;

		// Token: 0x04002D27 RID: 11559
		[Token(Token = "0x4002D27")]
		[FieldOffset(Offset = "0x94")]
		public float QualityLevel;

		// Token: 0x04002D28 RID: 11560
		[Token(Token = "0x4002D28")]
		[FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public List<int> ActiveHarvestables;
	}
}
