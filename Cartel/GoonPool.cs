using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework;
using ScheduleOne.Map;
using ScheduleOne.VoiceOver;
using UnityEngine;

namespace ScheduleOne.Cartel
{
	// Token: 0x02000816 RID: 2070
	[Token(Token = "0x2000816")]
	public class GoonPool : MonoBehaviour
	{
		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06003911 RID: 14609 RVA: 0x0000F528 File Offset: 0x0000D728
		[Token(Token = "0x17000816")]
		public int UnspawnedGoonCount
		{
			[Token(Token = "0x6003911")]
			[Address(RVA = "0x809C50", Offset = "0x808650", VA = "0x180809C50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06003912 RID: 14610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003912")]
		[Address(RVA = "0x809090", Offset = "0x807A90", VA = "0x180809090", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06003913 RID: 14611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003913")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80")]
		private void Update()
		{
		}

		// Token: 0x06003914 RID: 14612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003914")]
		[Address(RVA = "0x809890", Offset = "0x808290", VA = "0x180809890")]
		public List<CartelGoon> SpawnMultipleGoons(Vector3 spawnPoint, int requestedAmount, bool setAsGoonMates = true)
		{
			return null;
		}

		// Token: 0x06003915 RID: 14613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003915")]
		[Address(RVA = "0x8093E0", Offset = "0x807DE0", VA = "0x1808093E0")]
		public CartelGoonAppearance GetRandomAppearance()
		{
			return null;
		}

		// Token: 0x06003916 RID: 14614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003916")]
		[Address(RVA = "0x809740", Offset = "0x808140", VA = "0x180809740")]
		public CartelGoon SpawnGoon(Vector3 spawnPoint)
		{
			return null;
		}

		// Token: 0x06003917 RID: 14615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003917")]
		[Address(RVA = "0x8095E0", Offset = "0x807FE0", VA = "0x1808095E0")]
		public void ReturnToPool(CartelGoon goon)
		{
		}

		// Token: 0x06003918 RID: 14616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003918")]
		[Address(RVA = "0x809200", Offset = "0x807C00", VA = "0x180809200")]
		public NPCEnterableBuilding GetNearestExitBuilding(Vector3 position)
		{
			return null;
		}

		// Token: 0x06003919 RID: 14617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003919")]
		[Address(RVA = "0x809BA0", Offset = "0x8085A0", VA = "0x180809BA0")]
		public GoonPool()
		{
		}

		// Token: 0x0400278F RID: 10127
		[Token(Token = "0x400278F")]
		public const float MALE_CHANCE = 0.7f;

		// Token: 0x04002790 RID: 10128
		[Token(Token = "0x4002790")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("References")]
		private CartelGoon[] goons;

		// Token: 0x04002791 RID: 10129
		[Token(Token = "0x4002791")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private NPCEnterableBuilding[] exitBuildings;

		// Token: 0x04002792 RID: 10130
		[Token(Token = "0x4002792")]
		[FieldOffset(Offset = "0x30")]
		[Header("Appearance Settings")]
		public AvatarSettings[] MaleBaseAppearances;

		// Token: 0x04002793 RID: 10131
		[Token(Token = "0x4002793")]
		[FieldOffset(Offset = "0x38")]
		public AvatarSettings[] FemaleBaseAppearances;

		// Token: 0x04002794 RID: 10132
		[Token(Token = "0x4002794")]
		[FieldOffset(Offset = "0x40")]
		public AvatarSettings[] MaleClothing;

		// Token: 0x04002795 RID: 10133
		[Token(Token = "0x4002795")]
		[FieldOffset(Offset = "0x48")]
		public AvatarSettings[] FemaleClothing;

		// Token: 0x04002796 RID: 10134
		[Token(Token = "0x4002796")]
		[FieldOffset(Offset = "0x50")]
		public VODatabase[] MaleVoices;

		// Token: 0x04002797 RID: 10135
		[Token(Token = "0x4002797")]
		[FieldOffset(Offset = "0x58")]
		public VODatabase[] FemaleVoices;

		// Token: 0x04002798 RID: 10136
		[Token(Token = "0x4002798")]
		[FieldOffset(Offset = "0x60")]
		public Color[] SkinTones;

		// Token: 0x04002799 RID: 10137
		[Token(Token = "0x4002799")]
		[FieldOffset(Offset = "0x68")]
		public Color[] HairColors;

		// Token: 0x0400279A RID: 10138
		[Token(Token = "0x400279A")]
		[FieldOffset(Offset = "0x70")]
		private List<CartelGoon> spawnedGoons;

		// Token: 0x0400279B RID: 10139
		[Token(Token = "0x400279B")]
		[FieldOffset(Offset = "0x78")]
		private List<CartelGoon> unspawnedGoons;
	}
}
