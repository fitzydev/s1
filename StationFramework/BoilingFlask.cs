using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.ObjectScripts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.StationFramework
{
	// Token: 0x02000964 RID: 2404
	[Token(Token = "0x2000964")]
	public class BoilingFlask : Fillable
	{
		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06004214 RID: 16916 RVA: 0x00011580 File Offset: 0x0000F780
		// (set) Token: 0x06004215 RID: 16917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700093E")]
		public float CurrentTemperature
		{
			[Token(Token = "0x6004214")]
			[Address(RVA = "0x4A4C50", Offset = "0x4A3650", VA = "0x1804A4C50")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004215")]
			[Address(RVA = "0x4A4D20", Offset = "0x4A3720", VA = "0x1804A4D20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06004216 RID: 16918 RVA: 0x00011598 File Offset: 0x0000F798
		// (set) Token: 0x06004217 RID: 16919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700093F")]
		public float CurrentTemperatureVelocity
		{
			[Token(Token = "0x6004216")]
			[Address(RVA = "0x4A4C60", Offset = "0x4A3660", VA = "0x1804A4C60")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004217")]
			[Address(RVA = "0x4A4D30", Offset = "0x4A3730", VA = "0x1804A4D30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06004218 RID: 16920 RVA: 0x000115B0 File Offset: 0x0000F7B0
		[Token(Token = "0x17000940")]
		public bool IsTemperatureInRange
		{
			[Token(Token = "0x6004218")]
			[Address(RVA = "0x879C20", Offset = "0x878620", VA = "0x180879C20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06004219 RID: 16921 RVA: 0x000115C8 File Offset: 0x0000F7C8
		// (set) Token: 0x0600421A RID: 16922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000941")]
		public float OverheatScale
		{
			[Token(Token = "0x6004219")]
			[Address(RVA = "0x4AAA60", Offset = "0x4A9460", VA = "0x1804AAA60")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600421A")]
			[Address(RVA = "0x7F4360", Offset = "0x7F2D60", VA = "0x1807F4360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x0600421B RID: 16923 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600421C RID: 16924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000942")]
		public StationRecipe Recipe
		{
			[Token(Token = "0x600421B")]
			[Address(RVA = "0x432BA0", Offset = "0x4315A0", VA = "0x180432BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600421C")]
			[Address(RVA = "0x4BEDD0", Offset = "0x4BD7D0", VA = "0x1804BEDD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600421D RID: 16925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600421D")]
		[Address(RVA = "0x8796C0", Offset = "0x8780C0", VA = "0x1808796C0")]
		public void Update()
		{
		}

		// Token: 0x0600421E RID: 16926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600421E")]
		[Address(RVA = "0x878ED0", Offset = "0x8778D0", VA = "0x180878ED0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600421F RID: 16927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600421F")]
		[Address(RVA = "0x8791E0", Offset = "0x877BE0", VA = "0x1808791E0")]
		private void UpdateCanvas()
		{
		}

		// Token: 0x06004220 RID: 16928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004220")]
		[Address(RVA = "0x879530", Offset = "0x877F30", VA = "0x180879530")]
		private void UpdateSmoke()
		{
		}

		// Token: 0x06004221 RID: 16929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004221")]
		[Address(RVA = "0x879070", Offset = "0x877A70", VA = "0x180879070")]
		public void SetCanvasVisible(bool visible)
		{
		}

		// Token: 0x06004222 RID: 16930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004222")]
		[Address(RVA = "0x4A4D20", Offset = "0x4A3720", VA = "0x1804A4D20")]
		public void SetTemperature(float temp)
		{
		}

		// Token: 0x06004223 RID: 16931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004223")]
		[Address(RVA = "0x8790B0", Offset = "0x877AB0", VA = "0x1808790B0")]
		public void SetRecipe(StationRecipe recipe)
		{
		}

		// Token: 0x06004224 RID: 16932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004224")]
		[Address(RVA = "0x879B80", Offset = "0x878580", VA = "0x180879B80")]
		public BoilingFlask()
		{
		}

		// Token: 0x04002E38 RID: 11832
		[Token(Token = "0x4002E38")]
		public const float TEMPERATURE_MAX = 500f;

		// Token: 0x04002E39 RID: 11833
		[Token(Token = "0x4002E39")]
		[FieldOffset(Offset = "0x38")]
		public float TEMPERATURE_MAX_VELOCITY;

		// Token: 0x04002E3A RID: 11834
		[Token(Token = "0x4002E3A")]
		[FieldOffset(Offset = "0x3C")]
		public float TEMPERATURE_ACCELERATION;

		// Token: 0x04002E3B RID: 11835
		[Token(Token = "0x4002E3B")]
		public const float OVERHEAT_TIME = 1.25f;

		// Token: 0x04002E40 RID: 11840
		[Token(Token = "0x4002E40")]
		[FieldOffset(Offset = "0x58")]
		public bool LockTemperature;

		// Token: 0x04002E41 RID: 11841
		[Token(Token = "0x4002E41")]
		[FieldOffset(Offset = "0x60")]
		public AnimationCurve BoilSoundPitchCurve;

		// Token: 0x04002E42 RID: 11842
		[Token(Token = "0x4002E42")]
		[FieldOffset(Offset = "0x68")]
		public float LabelJitterScale;

		// Token: 0x04002E43 RID: 11843
		[Token(Token = "0x4002E43")]
		[FieldOffset(Offset = "0x70")]
		[Header("References")]
		public BunsenBurner Burner;

		// Token: 0x04002E44 RID: 11844
		[Token(Token = "0x4002E44")]
		[FieldOffset(Offset = "0x78")]
		public Canvas TemperatureCanvas;

		// Token: 0x04002E45 RID: 11845
		[Token(Token = "0x4002E45")]
		[FieldOffset(Offset = "0x80")]
		public TextMeshProUGUI TemperatureLabel;

		// Token: 0x04002E46 RID: 11846
		[Token(Token = "0x4002E46")]
		[FieldOffset(Offset = "0x88")]
		public Slider TemperatureSlider;

		// Token: 0x04002E47 RID: 11847
		[Token(Token = "0x4002E47")]
		[FieldOffset(Offset = "0x90")]
		public RectTransform TemperatureRangeIndicator;

		// Token: 0x04002E48 RID: 11848
		[Token(Token = "0x4002E48")]
		[FieldOffset(Offset = "0x98")]
		public ParticleSystem SmokeParticles;

		// Token: 0x04002E49 RID: 11849
		[Token(Token = "0x4002E49")]
		[FieldOffset(Offset = "0xA0")]
		public AudioSourceController BoilSound;

		// Token: 0x04002E4A RID: 11850
		[Token(Token = "0x4002E4A")]
		[FieldOffset(Offset = "0xA8")]
		public MeshRenderer OverheatMesh;
	}
}
