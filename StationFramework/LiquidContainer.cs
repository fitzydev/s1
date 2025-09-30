using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using LiquidVolumeFX;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	// Token: 0x02000972 RID: 2418
	[Token(Token = "0x2000972")]
	public class LiquidContainer : MonoBehaviour
	{
		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06004254 RID: 16980 RVA: 0x000116D0 File Offset: 0x0000F8D0
		// (set) Token: 0x06004255 RID: 16981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000949")]
		public float CurrentLiquidLevel
		{
			[Token(Token = "0x6004254")]
			[Address(RVA = "0x486190", Offset = "0x484B90", VA = "0x180486190")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004255")]
			[Address(RVA = "0x4A4AF0", Offset = "0x4A34F0", VA = "0x1804A4AF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06004256 RID: 16982 RVA: 0x000116E8 File Offset: 0x0000F8E8
		// (set) Token: 0x06004257 RID: 16983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700094A")]
		public Color LiquidColor
		{
			[Token(Token = "0x6004256")]
			[Address(RVA = "0x85EFF0", Offset = "0x85D9F0", VA = "0x18085EFF0")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6004257")]
			[Address(RVA = "0x87D370", Offset = "0x87BD70", VA = "0x18087D370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004258 RID: 16984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004258")]
		[Address(RVA = "0x87CA40", Offset = "0x87B440", VA = "0x18087CA40")]
		private void Awake()
		{
		}

		// Token: 0x06004259 RID: 16985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004259")]
		[Address(RVA = "0x87D070", Offset = "0x87BA70", VA = "0x18087D070")]
		private void Start()
		{
		}

		// Token: 0x0600425A RID: 16986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600425A")]
		[Address(RVA = "0x87CB00", Offset = "0x87B500", VA = "0x18087CB00")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600425B RID: 16987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600425B")]
		[Address(RVA = "0x87CAF0", Offset = "0x87B4F0", VA = "0x18087CAF0")]
		private void MinPass()
		{
		}

		// Token: 0x0600425C RID: 16988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600425C")]
		[Address(RVA = "0x87D1E0", Offset = "0x87BBE0", VA = "0x18087D1E0")]
		private void UpdateLighting()
		{
		}

		// Token: 0x0600425D RID: 16989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600425D")]
		[Address(RVA = "0x87CCB0", Offset = "0x87B6B0", VA = "0x18087CCB0")]
		public void SetLiquidLevel(float level, bool debug = false)
		{
		}

		// Token: 0x0600425E RID: 16990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600425E")]
		[Address(RVA = "0x87CC20", Offset = "0x87B620", VA = "0x18087CC20")]
		public void SetLiquidColor(Color color, bool setColorVariable = true, bool updateLigting = true)
		{
		}

		// Token: 0x0600425F RID: 16991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600425F")]
		[Address(RVA = "0x87D340", Offset = "0x87BD40", VA = "0x18087D340")]
		public LiquidContainer()
		{
		}

		// Token: 0x04002E76 RID: 11894
		[Token(Token = "0x4002E76")]
		[FieldOffset(Offset = "0x34")]
		[Header("Settings")]
		[Range(0f, 1f)]
		public float Viscosity;

		// Token: 0x04002E77 RID: 11895
		[Token(Token = "0x4002E77")]
		[FieldOffset(Offset = "0x38")]
		public bool AdjustMurkiness;

		// Token: 0x04002E78 RID: 11896
		[Token(Token = "0x4002E78")]
		[FieldOffset(Offset = "0x40")]
		[Header("References")]
		public LiquidVolume LiquidVolume;

		// Token: 0x04002E79 RID: 11897
		[Token(Token = "0x4002E79")]
		[FieldOffset(Offset = "0x48")]
		public LiquidVolumeCollider Collider;

		// Token: 0x04002E7A RID: 11898
		[Token(Token = "0x4002E7A")]
		[FieldOffset(Offset = "0x50")]
		public Transform ColliderTransform_Min;

		// Token: 0x04002E7B RID: 11899
		[Token(Token = "0x4002E7B")]
		[FieldOffset(Offset = "0x58")]
		public Transform ColliderTransform_Max;

		// Token: 0x04002E7C RID: 11900
		[Token(Token = "0x4002E7C")]
		[FieldOffset(Offset = "0x60")]
		[Header("Visuals Settings")]
		public float MaxLevel;

		// Token: 0x04002E7D RID: 11901
		[Token(Token = "0x4002E7D")]
		[FieldOffset(Offset = "0x68")]
		private MeshRenderer liquidMesh;
	}
}
