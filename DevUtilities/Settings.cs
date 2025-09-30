using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000784 RID: 1924
	[Token(Token = "0x2000784")]
	public class Settings : PersistentSingleton<Settings>
	{
		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x060033BD RID: 13245 RVA: 0x0000E3E8 File Offset: 0x0000C5E8
		// (set) Token: 0x060033BE RID: 13246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000786")]
		public Settings.UnitType unitType
		{
			[Token(Token = "0x60033BD")]
			[Address(RVA = "0x47D760", Offset = "0x47C160", VA = "0x18047D760")]
			[CompilerGenerated]
			get
			{
				return Settings.UnitType.Metric;
			}
			[Token(Token = "0x60033BE")]
			[Address(RVA = "0x47D820", Offset = "0x47C220", VA = "0x18047D820")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x060033BF RID: 13247 RVA: 0x0000E400 File Offset: 0x0000C600
		[Token(Token = "0x17000787")]
		public bool PausingFreezesTime
		{
			[Token(Token = "0x60033BF")]
			[Address(RVA = "0x78BD70", Offset = "0x78A770", VA = "0x18078BD70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060033C0 RID: 13248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C0")]
		[Address(RVA = "0x78A670", Offset = "0x789070", VA = "0x18078A670", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x060033C1 RID: 13249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C1")]
		[Address(RVA = "0x78B5D0", Offset = "0x789FD0", VA = "0x18078B5D0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x060033C2 RID: 13250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C2")]
		[Address(RVA = "0x78AD40", Offset = "0x789740", VA = "0x18078AD40")]
		private void CheckCountryCode()
		{
		}

		// Token: 0x060033C3 RID: 13251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C3")]
		[Address(RVA = "0x78A140", Offset = "0x788B40", VA = "0x18078A140")]
		public void ApplyDisplaySettings(DisplaySettings settings)
		{
		}

		// Token: 0x060033C4 RID: 13252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C4")]
		[Address(RVA = "0x78AF00", Offset = "0x789900", VA = "0x18078AF00")]
		private void MoveMainWindowTo(DisplayInfo displayInfo)
		{
		}

		// Token: 0x060033C5 RID: 13253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C5")]
		[Address(RVA = "0x78B530", Offset = "0x789F30", VA = "0x18078B530")]
		public void ReloadGraphicsSettings()
		{
		}

		// Token: 0x060033C6 RID: 13254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C6")]
		[Address(RVA = "0x78A530", Offset = "0x788F30", VA = "0x18078A530")]
		public void ApplyGraphicsSettings(GraphicsSettings settings)
		{
		}

		// Token: 0x060033C7 RID: 13255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C7")]
		[Address(RVA = "0x78B520", Offset = "0x789F20", VA = "0x18078B520")]
		public void ReloadAudioSettings()
		{
		}

		// Token: 0x060033C8 RID: 13256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C8")]
		[Address(RVA = "0x789E90", Offset = "0x788890", VA = "0x180789E90")]
		public void ApplyAudioSettings(AudioSettings settings)
		{
		}

		// Token: 0x060033C9 RID: 13257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C9")]
		[Address(RVA = "0x78B5A0", Offset = "0x789FA0", VA = "0x18078B5A0")]
		public void ReloadInputSettings()
		{
		}

		// Token: 0x060033CA RID: 13258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033CA")]
		[Address(RVA = "0x78A5A0", Offset = "0x788FA0", VA = "0x18078A5A0")]
		public void ApplyInputSettings(InputSettings settings)
		{
		}

		// Token: 0x060033CB RID: 13259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033CB")]
		[Address(RVA = "0x78B5B0", Offset = "0x789FB0", VA = "0x18078B5B0")]
		public void ReloadOtherSettings()
		{
		}

		// Token: 0x060033CC RID: 13260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033CC")]
		[Address(RVA = "0x639E30", Offset = "0x638830", VA = "0x180639E30")]
		public void ApplyOtherSettings(OtherSettings settings)
		{
		}

		// Token: 0x060033CD RID: 13261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033CD")]
		[Address(RVA = "0x78B840", Offset = "0x78A240", VA = "0x18078B840")]
		public void WriteDisplaySettings(DisplaySettings settings)
		{
		}

		// Token: 0x060033CE RID: 13262 RVA: 0x0000E418 File Offset: 0x0000C618
		[Token(Token = "0x60033CE")]
		[Address(RVA = "0x78B110", Offset = "0x789B10", VA = "0x18078B110")]
		public DisplaySettings ReadDisplaySettings()
		{
			return default(DisplaySettings);
		}

		// Token: 0x060033CF RID: 13263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033CF")]
		[Address(RVA = "0x78B980", Offset = "0x78A380", VA = "0x18078B980")]
		public void WriteGraphicsSettings(GraphicsSettings settings)
		{
		}

		// Token: 0x060033D0 RID: 13264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D0")]
		[Address(RVA = "0x78B260", Offset = "0x789C60", VA = "0x18078B260")]
		public GraphicsSettings ReadGraphicsSettings()
		{
			return null;
		}

		// Token: 0x060033D1 RID: 13265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033D1")]
		[Address(RVA = "0x78B710", Offset = "0x78A110", VA = "0x18078B710")]
		public void WriteAudioSettings(AudioSettings settings)
		{
		}

		// Token: 0x060033D2 RID: 13266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D2")]
		[Address(RVA = "0x78AFB0", Offset = "0x7899B0", VA = "0x18078AFB0")]
		public AudioSettings ReadAudioSettings()
		{
			return null;
		}

		// Token: 0x060033D3 RID: 13267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033D3")]
		[Address(RVA = "0x78BA70", Offset = "0x78A470", VA = "0x18078BA70")]
		public void WriteInputSettings(InputSettings settings)
		{
		}

		// Token: 0x060033D4 RID: 13268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D4")]
		[Address(RVA = "0x78B370", Offset = "0x789D70", VA = "0x18078B370")]
		public InputSettings ReadInputSettings()
		{
			return null;
		}

		// Token: 0x060033D5 RID: 13269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033D5")]
		[Address(RVA = "0x78BB60", Offset = "0x78A560", VA = "0x18078BB60")]
		public void WriteOtherSettings(OtherSettings settings)
		{
		}

		// Token: 0x060033D6 RID: 13270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D6")]
		[Address(RVA = "0x78B4A0", Offset = "0x789EA0", VA = "0x18078B4A0")]
		public OtherSettings ReadOtherSettings()
		{
			return null;
		}

		// Token: 0x060033D7 RID: 13271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D7")]
		[Address(RVA = "0x78ADD0", Offset = "0x7897D0", VA = "0x18078ADD0")]
		public string GetActionControlPath(string actionName)
		{
			return null;
		}

		// Token: 0x060033D8 RID: 13272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033D8")]
		[Address(RVA = "0x78BBD0", Offset = "0x78A5D0", VA = "0x18078BBD0")]
		public Settings()
		{
		}

		// Token: 0x04002405 RID: 9221
		[Token(Token = "0x4002405")]
		public const float MinYPos = -20f;

		// Token: 0x04002406 RID: 9222
		[Token(Token = "0x4002406")]
		public const string BETA_ARG = "-beta";

		// Token: 0x04002407 RID: 9223
		[Token(Token = "0x4002407")]
		public const string DISABLE_COUNTRY_CHECK_ARG = "-disablecountrycheck";

		// Token: 0x04002408 RID: 9224
		[Token(Token = "0x4002408")]
		public const bool COUNTRY_CHECK = false;

		// Token: 0x0400240A RID: 9226
		[Token(Token = "0x400240A")]
		[FieldOffset(Offset = "0x30")]
		public List<string> LaunchArgs;

		// Token: 0x0400240B RID: 9227
		[Token(Token = "0x400240B")]
		[FieldOffset(Offset = "0x38")]
		public DisplaySettings DisplaySettings;

		// Token: 0x0400240C RID: 9228
		[Token(Token = "0x400240C")]
		[FieldOffset(Offset = "0x54")]
		public DisplaySettings UnappliedDisplaySettings;

		// Token: 0x0400240D RID: 9229
		[Token(Token = "0x400240D")]
		[FieldOffset(Offset = "0x70")]
		public GraphicsSettings GraphicsSettings;

		// Token: 0x0400240E RID: 9230
		[Token(Token = "0x400240E")]
		[FieldOffset(Offset = "0x78")]
		public AudioSettings AudioSettings;

		// Token: 0x0400240F RID: 9231
		[Token(Token = "0x400240F")]
		[FieldOffset(Offset = "0x80")]
		public InputSettings InputSettings;

		// Token: 0x04002410 RID: 9232
		[Token(Token = "0x4002410")]
		[FieldOffset(Offset = "0x88")]
		public OtherSettings OtherSettings;

		// Token: 0x04002411 RID: 9233
		[Token(Token = "0x4002411")]
		[FieldOffset(Offset = "0x90")]
		public InputActionAsset InputActions;

		// Token: 0x04002412 RID: 9234
		[Token(Token = "0x4002412")]
		[FieldOffset(Offset = "0x98")]
		public GameInput GameInput;

		// Token: 0x04002413 RID: 9235
		[Token(Token = "0x4002413")]
		[FieldOffset(Offset = "0xA0")]
		public ScriptableRendererFeature SSAO;

		// Token: 0x04002414 RID: 9236
		[Token(Token = "0x4002414")]
		[FieldOffset(Offset = "0xA8")]
		public ScriptableRendererFeature GodRays;

		// Token: 0x04002415 RID: 9237
		[Token(Token = "0x4002415")]
		[FieldOffset(Offset = "0xB0")]
		[Header("Camera")]
		public float LookSensitivity;

		// Token: 0x04002416 RID: 9238
		[Token(Token = "0x4002416")]
		[FieldOffset(Offset = "0xB4")]
		public bool InvertMouse;

		// Token: 0x04002417 RID: 9239
		[Token(Token = "0x4002417")]
		[FieldOffset(Offset = "0xB8")]
		public float CameraFOV;

		// Token: 0x04002418 RID: 9240
		[Token(Token = "0x4002418")]
		[FieldOffset(Offset = "0xBC")]
		public InputSettings.EActionMode SprintMode;

		// Token: 0x04002419 RID: 9241
		[Token(Token = "0x4002419")]
		[FieldOffset(Offset = "0xC0")]
		[Range(0f, 1f)]
		public float CameraBobIntensity;

		// Token: 0x0400241A RID: 9242
		[Token(Token = "0x400241A")]
		[FieldOffset(Offset = "0xC8")]
		private InputActionMap playerControls;

		// Token: 0x0400241B RID: 9243
		[Token(Token = "0x400241B")]
		[FieldOffset(Offset = "0xD0")]
		public Action onDisplayChanged;

		// Token: 0x0400241C RID: 9244
		[Token(Token = "0x400241C")]
		[FieldOffset(Offset = "0xD8")]
		public Action onInputsApplied;

		// Token: 0x02000785 RID: 1925
		[Token(Token = "0x2000785")]
		public enum UnitType
		{
			// Token: 0x0400241E RID: 9246
			[Token(Token = "0x400241E")]
			Metric,
			// Token: 0x0400241F RID: 9247
			[Token(Token = "0x400241F")]
			Imperial
		}
	}
}
