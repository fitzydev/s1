using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x02000A14 RID: 2580
	[Token(Token = "0x2000A14")]
	public class Eye : MonoBehaviour
	{
		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x060046D4 RID: 18132 RVA: 0x00012A50 File Offset: 0x00010C50
		// (set) Token: 0x060046D5 RID: 18133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009FD")]
		public Eye.EyeLidConfiguration CurrentConfiguration
		{
			[Token(Token = "0x60046D4")]
			[Address(RVA = "0x51ADF0", Offset = "0x5197F0", VA = "0x18051ADF0")]
			[CompilerGenerated]
			get
			{
				return default(Eye.EyeLidConfiguration);
			}
			[Token(Token = "0x60046D5")]
			[Address(RVA = "0x51AE60", Offset = "0x519860", VA = "0x18051AE60")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x060046D6 RID: 18134 RVA: 0x00012A68 File Offset: 0x00010C68
		[Token(Token = "0x170009FE")]
		public bool IsBlinking
		{
			[Token(Token = "0x60046D6")]
			[Address(RVA = "0x8F73B0", Offset = "0x8F5DB0", VA = "0x1808F73B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060046D7 RID: 18135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D7")]
		[Address(RVA = "0x8F5F00", Offset = "0x8F4900", VA = "0x1808F5F00")]
		private void Awake()
		{
		}

		// Token: 0x060046D8 RID: 18136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D8")]
		[Address(RVA = "0x8F7180", Offset = "0x8F5B80", VA = "0x1808F7180")]
		public void SetSize(float size)
		{
		}

		// Token: 0x060046D9 RID: 18137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D9")]
		[Address(RVA = "0x8F7100", Offset = "0x8F5B00", VA = "0x1808F7100")]
		public void SetLidColor(Color color)
		{
		}

		// Token: 0x060046DA RID: 18138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046DA")]
		[Address(RVA = "0x8F70E0", Offset = "0x8F5AE0", VA = "0x1808F70E0")]
		public void SetEyeballMaterial(Material mat, Color col)
		{
		}

		// Token: 0x060046DB RID: 18139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046DB")]
		[Address(RVA = "0x8F6FC0", Offset = "0x8F59C0", VA = "0x1808F6FC0")]
		public void SetEyeballColor(Color col, float emission = 0.115f, bool writeDefault = true)
		{
		}

		// Token: 0x060046DC RID: 18140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046DC")]
		[Address(RVA = "0x8F69D0", Offset = "0x8F53D0", VA = "0x1808F69D0")]
		public void ResetEyeballColor()
		{
		}

		// Token: 0x060046DD RID: 18141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046DD")]
		[Address(RVA = "0x8F6190", Offset = "0x8F4B90", VA = "0x1808F6190")]
		public void ConfigureEyeLight(Color color, float intensity)
		{
		}

		// Token: 0x060046DE RID: 18142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046DE")]
		[Address(RVA = "0x8F6AD0", Offset = "0x8F54D0", VA = "0x1808F6AD0")]
		public void SetDilation(float dil)
		{
		}

		// Token: 0x060046DF RID: 18143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046DF")]
		[Address(RVA = "0x8F6B00", Offset = "0x8F5500", VA = "0x1808F6B00")]
		public void SetEyeLidState(Eye.EyeLidConfiguration config, float time)
		{
		}

		// Token: 0x060046E0 RID: 18144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046E0")]
		[Address(RVA = "0x8F7240", Offset = "0x8F5C40", VA = "0x1808F7240")]
		private void StopExistingRoutines()
		{
		}

		// Token: 0x060046E1 RID: 18145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046E1")]
		[Address(RVA = "0x8F6CE0", Offset = "0x8F56E0", VA = "0x1808F6CE0")]
		public void SetEyeLidState(Eye.EyeLidConfiguration config, bool debug = false)
		{
		}

		// Token: 0x060046E2 RID: 18146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046E2")]
		[Address(RVA = "0x8F62B0", Offset = "0x8F4CB0", VA = "0x1808F62B0")]
		public void LookAt(Vector3 position, bool instant = false)
		{
		}

		// Token: 0x060046E3 RID: 18147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046E3")]
		[Address(RVA = "0x8F5F70", Offset = "0x8F4970", VA = "0x1808F5F70")]
		public void Blink(float blinkDuration, Eye.EyeLidConfiguration endState, bool debug = false)
		{
		}

		// Token: 0x060046E4 RID: 18148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046E4")]
		[Address(RVA = "0x8F7340", Offset = "0x8F5D40", VA = "0x1808F7340")]
		public Eye()
		{
		}

		// Token: 0x040031A6 RID: 12710
		[Token(Token = "0x40031A6")]
		public const float PupilLookSpeed = 10f;

		// Token: 0x040031A7 RID: 12711
		[Token(Token = "0x40031A7")]
		[FieldOffset(Offset = "0x0")]
		private static Vector3 defaultScale;

		// Token: 0x040031A8 RID: 12712
		[Token(Token = "0x40031A8")]
		[FieldOffset(Offset = "0xC")]
		private static Vector3 maxRotation;

		// Token: 0x040031A9 RID: 12713
		[Token(Token = "0x40031A9")]
		[FieldOffset(Offset = "0x18")]
		private static Vector3 minRotation;

		// Token: 0x040031AB RID: 12715
		[Token(Token = "0x40031AB")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public Transform Container;

		// Token: 0x040031AC RID: 12716
		[Token(Token = "0x40031AC")]
		[FieldOffset(Offset = "0x30")]
		public Transform TopLidContainer;

		// Token: 0x040031AD RID: 12717
		[Token(Token = "0x40031AD")]
		[FieldOffset(Offset = "0x38")]
		public Transform BottomLidContainer;

		// Token: 0x040031AE RID: 12718
		[Token(Token = "0x40031AE")]
		[FieldOffset(Offset = "0x40")]
		public Transform PupilContainer;

		// Token: 0x040031AF RID: 12719
		[Token(Token = "0x40031AF")]
		[FieldOffset(Offset = "0x48")]
		public MeshRenderer TopLidRend;

		// Token: 0x040031B0 RID: 12720
		[Token(Token = "0x40031B0")]
		[FieldOffset(Offset = "0x50")]
		public MeshRenderer BottomLidRend;

		// Token: 0x040031B1 RID: 12721
		[Token(Token = "0x40031B1")]
		[FieldOffset(Offset = "0x58")]
		public MeshRenderer EyeBallRend;

		// Token: 0x040031B2 RID: 12722
		[Token(Token = "0x40031B2")]
		[FieldOffset(Offset = "0x60")]
		public Transform EyeLookOrigin;

		// Token: 0x040031B3 RID: 12723
		[Token(Token = "0x40031B3")]
		[FieldOffset(Offset = "0x68")]
		public OptimizedLight EyeLight;

		// Token: 0x040031B4 RID: 12724
		[Token(Token = "0x40031B4")]
		[FieldOffset(Offset = "0x70")]
		public SkinnedMeshRenderer PupilRend;

		// Token: 0x040031B5 RID: 12725
		[Token(Token = "0x40031B5")]
		[FieldOffset(Offset = "0x78")]
		private Coroutine blinkRoutine;

		// Token: 0x040031B6 RID: 12726
		[Token(Token = "0x40031B6")]
		[FieldOffset(Offset = "0x80")]
		private Coroutine stateRoutine;

		// Token: 0x040031B7 RID: 12727
		[Token(Token = "0x40031B7")]
		[FieldOffset(Offset = "0x88")]
		private Avatar avatar;

		// Token: 0x040031B8 RID: 12728
		[Token(Token = "0x40031B8")]
		[FieldOffset(Offset = "0x90")]
		private Color defaultEyeColor;

		// Token: 0x040031B9 RID: 12729
		[Token(Token = "0x40031B9")]
		[FieldOffset(Offset = "0xA0")]
		public Vector2 AngleOffset;

		// Token: 0x02000A15 RID: 2581
		[Token(Token = "0x2000A15")]
		[Serializable]
		public struct EyeLidConfiguration
		{
			// Token: 0x060046E6 RID: 18150 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60046E6")]
			[Address(RVA = "0x8F5E80", Offset = "0x8F4880", VA = "0x1808F5E80", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x060046E7 RID: 18151 RVA: 0x00012A80 File Offset: 0x00010C80
			[Token(Token = "0x60046E7")]
			[Address(RVA = "0x8F5E10", Offset = "0x8F4810", VA = "0x1808F5E10")]
			public static Eye.EyeLidConfiguration Lerp(Eye.EyeLidConfiguration start, Eye.EyeLidConfiguration end, float lerp)
			{
				return default(Eye.EyeLidConfiguration);
			}

			// Token: 0x040031BA RID: 12730
			[Token(Token = "0x40031BA")]
			[FieldOffset(Offset = "0x0")]
			[Range(0f, 1f)]
			public float topLidOpen;

			// Token: 0x040031BB RID: 12731
			[Token(Token = "0x40031BB")]
			[FieldOffset(Offset = "0x4")]
			[Range(0f, 1f)]
			public float bottomLidOpen;
		}
	}
}
