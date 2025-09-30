using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ScheduleOne
{
	// Token: 0x02000288 RID: 648
	[Token(Token = "0x2000288")]
	public class GameInput : PersistentSingleton<GameInput>
	{
		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x00006F00 File Offset: 0x00005100
		// (set) Token: 0x06000D80 RID: 3456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002FC")]
		public static GameInput.InputDeviceType CurrentInputDevice
		{
			[Token(Token = "0x6000D7F")]
			[Address(RVA = "0xAA85F0", Offset = "0xAA6FF0", VA = "0x180AA85F0")]
			[CompilerGenerated]
			get
			{
				return GameInput.InputDeviceType.KeyboardMouse;
			}
			[Token(Token = "0x6000D80")]
			[Address(RVA = "0xAA8770", Offset = "0xAA7170", VA = "0x180AA8770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000D81 RID: 3457 RVA: 0x00006F18 File Offset: 0x00005118
		[Token(Token = "0x170002FD")]
		public static Vector2 MouseDelta
		{
			[Token(Token = "0x6000D81")]
			[Address(RVA = "0xAA8640", Offset = "0xAA7040", VA = "0x180AA8640")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000D82 RID: 3458 RVA: 0x00006F30 File Offset: 0x00005130
		[Token(Token = "0x170002FE")]
		public static Vector3 MousePosition
		{
			[Token(Token = "0x6000D82")]
			[Address(RVA = "0xAA86A0", Offset = "0xAA70A0", VA = "0x180AA86A0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000D83 RID: 3459 RVA: 0x00006F48 File Offset: 0x00005148
		[Token(Token = "0x170002FF")]
		public static float MouseScrollDelta
		{
			[Token(Token = "0x6000D83")]
			[Address(RVA = "0xAA86D0", Offset = "0xAA70D0", VA = "0x180AA86D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000D84 RID: 3460 RVA: 0x00006F60 File Offset: 0x00005160
		// (set) Token: 0x06000D85 RID: 3461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000300")]
		public static float VehicleDriveAxis
		{
			[Token(Token = "0x6000D84")]
			[Address(RVA = "0xAA8720", Offset = "0xAA7120", VA = "0x180AA8720")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000D85")]
			[Address(RVA = "0xAA87D0", Offset = "0xAA71D0", VA = "0x180AA87D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D86")]
		[Address(RVA = "0xAA3740", Offset = "0xAA2140", VA = "0x180AA3740", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D87")]
		[Address(RVA = "0xAA47F0", Offset = "0xAA31F0", VA = "0x180AA47F0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D88")]
		[Address(RVA = "0xAA8030", Offset = "0xAA6A30", VA = "0x180AA8030", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D89")]
		[Address(RVA = "0xAA3E60", Offset = "0xAA2860", VA = "0x180AA3E60")]
		private void OnApplicationFocus(bool focus)
		{
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x00006F78 File Offset: 0x00005178
		[Token(Token = "0x6000D8A")]
		[Address(RVA = "0xAA3D60", Offset = "0xAA2760", VA = "0x180AA3D60")]
		public static bool GetButton(GameInput.ButtonCode buttonCode)
		{
			return default(bool);
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00006F90 File Offset: 0x00005190
		[Token(Token = "0x6000D8B")]
		[Address(RVA = "0xAA3C20", Offset = "0xAA2620", VA = "0x180AA3C20")]
		public static bool GetButtonDown(GameInput.ButtonCode buttonCode)
		{
			return default(bool);
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x00006FA8 File Offset: 0x000051A8
		[Token(Token = "0x6000D8C")]
		[Address(RVA = "0xAA3CC0", Offset = "0xAA26C0", VA = "0x180AA3CC0")]
		public static bool GetButtonUp(GameInput.ButtonCode buttonCode)
		{
			return default(bool);
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D8D")]
		[Address(RVA = "0xAA82E0", Offset = "0xAA6CE0", VA = "0x180AA82E0", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D8E")]
		[Address(RVA = "0xAA3A60", Offset = "0xAA2460", VA = "0x180AA3A60")]
		private void Exit(ExitType type)
		{
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D8F")]
		[Address(RVA = "0xAA3E00", Offset = "0xAA2800", VA = "0x180AA3E00")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D90")]
		[Address(RVA = "0xAA38C0", Offset = "0xAA22C0", VA = "0x180AA38C0")]
		public void ExitAll()
		{
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D91")]
		[Address(RVA = "0xAA43C0", Offset = "0xAA2DC0", VA = "0x180AA43C0")]
		private void OnControlsChanged(PlayerInput input)
		{
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D92")]
		[Address(RVA = "0xAA5480", Offset = "0xAA3E80", VA = "0x180AA5480")]
		private void OnMotion(InputValue value)
		{
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D93")]
		[Address(RVA = "0xAA60F0", Offset = "0xAA4AF0", VA = "0x180AA60F0")]
		private void OnPrimaryClick()
		{
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D94")]
		[Address(RVA = "0xAA69C0", Offset = "0xAA53C0", VA = "0x180AA69C0")]
		private void OnSecondaryClick()
		{
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D95")]
		[Address(RVA = "0xAA71E0", Offset = "0xAA5BE0", VA = "0x180AA71E0")]
		private void OnTertiaryClick()
		{
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D96")]
		[Address(RVA = "0xAA5100", Offset = "0xAA3B00", VA = "0x180AA5100")]
		private void OnJump()
		{
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D97")]
		[Address(RVA = "0xAA4610", Offset = "0xAA3010", VA = "0x180AA4610")]
		private void OnCrouch()
		{
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D98")]
		[Address(RVA = "0xAA6EA0", Offset = "0xAA58A0", VA = "0x180AA6EA0")]
		private void OnSprint()
		{
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D99")]
		[Address(RVA = "0xAA48A0", Offset = "0xAA32A0", VA = "0x180AA48A0")]
		private void OnEscape()
		{
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D9A")]
		[Address(RVA = "0xAA4000", Offset = "0xAA2A00", VA = "0x180AA4000")]
		private void OnBack()
		{
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D9B")]
		[Address(RVA = "0xAA4BE0", Offset = "0xAA35E0", VA = "0x180AA4BE0")]
		private void OnInteract()
		{
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D9C")]
		[Address(RVA = "0xAA7040", Offset = "0xAA5A40", VA = "0x180AA7040")]
		private void OnSubmit()
		{
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D9D")]
		[Address(RVA = "0xAA7520", Offset = "0xAA5F20", VA = "0x180AA7520")]
		private void OnTogglePhone()
		{
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D9E")]
		[Address(RVA = "0xAA7AC0", Offset = "0xAA64C0", VA = "0x180AA7AC0")]
		private void OnVehicleToggleLights()
		{
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D9F")]
		[Address(RVA = "0xAA7780", Offset = "0xAA6180", VA = "0x180AA7780")]
		private void OnVehicleHandbrake()
		{
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DA0")]
		[Address(RVA = "0xAA65F0", Offset = "0xAA4FF0", VA = "0x180AA65F0")]
		private void OnRotateLeft()
		{
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DA1")]
		[Address(RVA = "0xAA6790", Offset = "0xAA5190", VA = "0x180AA6790")]
		private void OnRotateRight()
		{
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DA2")]
		[Address(RVA = "0xAA52E0", Offset = "0xAA3CE0", VA = "0x180AA52E0")]
		private void OnManagementMode()
		{
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DA3")]
		[Address(RVA = "0xAA5DB0", Offset = "0xAA47B0", VA = "0x180AA5DB0")]
		private void OnOpenMap()
		{
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DA4")]
		[Address(RVA = "0xAA5C10", Offset = "0xAA4610", VA = "0x180AA5C10")]
		private void OnOpenJournal()
		{
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DA5")]
		[Address(RVA = "0xAA5F50", Offset = "0xAA4950", VA = "0x180AA5F50")]
		private void OnOpenTexts()
		{
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DA6")]
		[Address(RVA = "0xAA6270", Offset = "0xAA4C70", VA = "0x180AA6270")]
		private void OnQuickMove()
		{
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DA7")]
		[Address(RVA = "0xAA7380", Offset = "0xAA5D80", VA = "0x180AA7380")]
		private void OnToggleFlashlight()
		{
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DA8")]
		[Address(RVA = "0xAA7C60", Offset = "0xAA6660", VA = "0x180AA7C60")]
		private void OnViewAvatar()
		{
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DA9")]
		[Address(RVA = "0xAA6410", Offset = "0xAA4E10", VA = "0x180AA6410")]
		private void OnReload()
		{
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DAA")]
		[Address(RVA = "0xAA41E0", Offset = "0xAA2BE0", VA = "0x180AA41E0")]
		private void OnCamera(InputValue value)
		{
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DAB")]
		[Address(RVA = "0xAA6930", Offset = "0xAA5330", VA = "0x180AA6930")]
		private void OnScrollWheel(InputValue value)
		{
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DAC")]
		[Address(RVA = "0xAA4DC0", Offset = "0xAA37C0", VA = "0x180AA4DC0")]
		private void OnInventoryLeft()
		{
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DAD")]
		[Address(RVA = "0xAA4F60", Offset = "0xAA3960", VA = "0x180AA4F60")]
		private void OnInventoryRight()
		{
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DAE")]
		[Address(RVA = "0xAA4A40", Offset = "0xAA3440", VA = "0x180AA4A40")]
		private void OnHolster()
		{
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DAF")]
		[Address(RVA = "0xAA4310", Offset = "0xAA2D10", VA = "0x180AA4310")]
		private void OnControllerCombo(InputValue value)
		{
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DB0")]
		[Address(RVA = "0xAA7920", Offset = "0xAA6320", VA = "0x180AA7920")]
		private void OnVehicleResetCamera()
		{
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DB1")]
		[Address(RVA = "0xAA76C0", Offset = "0xAA60C0", VA = "0x180AA76C0")]
		private void OnVehicleDrive(InputValue value)
		{
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DB2")]
		[Address(RVA = "0xAA6B60", Offset = "0xAA5560", VA = "0x180AA6B60")]
		private void OnSkateboardDismount()
		{
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DB3")]
		[Address(RVA = "0xAA6D00", Offset = "0xAA5700", VA = "0x180AA6D00")]
		private void OnSkateboardMount()
		{
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DB4")]
		[Address(RVA = "0xAA7E00", Offset = "0xAA6800", VA = "0x180AA7E00")]
		public static void RegisterExitListener(GameInput.ExitDelegate listener, int priority = 0)
		{
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DB5")]
		[Address(RVA = "0xAA3780", Offset = "0xAA2180", VA = "0x180AA3780")]
		public static void DeregisterExitListener(GameInput.ExitDelegate listener)
		{
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB6")]
		[Address(RVA = "0xAA3B90", Offset = "0xAA2590", VA = "0x180AA3B90")]
		public InputAction GetAction(GameInput.ButtonCode code)
		{
			return null;
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DB7")]
		[Address(RVA = "0xAA8500", Offset = "0xAA6F00", VA = "0x180AA8500")]
		public GameInput()
		{
		}

		// Token: 0x04000DA1 RID: 3489
		[Token(Token = "0x4000DA1")]
		[FieldOffset(Offset = "0x8")]
		public static Action<GameInput.InputDeviceType> OnInputDeviceChanged;

		// Token: 0x04000DA2 RID: 3490
		[Token(Token = "0x4000DA2")]
		[FieldOffset(Offset = "0x10")]
		public static List<GameInput.ExitListener> exitListeners;

		// Token: 0x04000DA3 RID: 3491
		[Token(Token = "0x4000DA3")]
		[FieldOffset(Offset = "0x28")]
		public PlayerInput PlayerInput;

		// Token: 0x04000DA4 RID: 3492
		[Token(Token = "0x4000DA4")]
		[FieldOffset(Offset = "0x18")]
		public static bool IsTyping;

		// Token: 0x04000DA5 RID: 3493
		[Token(Token = "0x4000DA5")]
		[FieldOffset(Offset = "0x1C")]
		public static Vector2 MotionAxis;

		// Token: 0x04000DA6 RID: 3494
		[Token(Token = "0x4000DA6")]
		[FieldOffset(Offset = "0x24")]
		public static Vector2 CameraAxis;

		// Token: 0x04000DA7 RID: 3495
		[Token(Token = "0x4000DA7")]
		[FieldOffset(Offset = "0x2C")]
		public static float MouseWheelAxis;

		// Token: 0x04000DA8 RID: 3496
		[Token(Token = "0x4000DA8")]
		[FieldOffset(Offset = "0x30")]
		public static bool ControllerComboActive;

		// Token: 0x04000DAA RID: 3498
		[Token(Token = "0x4000DAA")]
		[FieldOffset(Offset = "0x30")]
		private List<GameInput.ButtonCode> buttonsDownThisFrame;

		// Token: 0x04000DAB RID: 3499
		[Token(Token = "0x4000DAB")]
		[FieldOffset(Offset = "0x38")]
		private List<GameInput.ButtonCode> buttonsDown;

		// Token: 0x04000DAC RID: 3500
		[Token(Token = "0x4000DAC")]
		[FieldOffset(Offset = "0x40")]
		private List<GameInput.ButtonCode> buttonsUpThisFrame;

		// Token: 0x02000289 RID: 649
		[Token(Token = "0x2000289")]
		public enum ButtonCode
		{
			// Token: 0x04000DAE RID: 3502
			[Token(Token = "0x4000DAE")]
			PrimaryClick,
			// Token: 0x04000DAF RID: 3503
			[Token(Token = "0x4000DAF")]
			SecondaryClick,
			// Token: 0x04000DB0 RID: 3504
			[Token(Token = "0x4000DB0")]
			TertiaryClick,
			// Token: 0x04000DB1 RID: 3505
			[Token(Token = "0x4000DB1")]
			Forward,
			// Token: 0x04000DB2 RID: 3506
			[Token(Token = "0x4000DB2")]
			Backward,
			// Token: 0x04000DB3 RID: 3507
			[Token(Token = "0x4000DB3")]
			Left,
			// Token: 0x04000DB4 RID: 3508
			[Token(Token = "0x4000DB4")]
			Right,
			// Token: 0x04000DB5 RID: 3509
			[Token(Token = "0x4000DB5")]
			Jump,
			// Token: 0x04000DB6 RID: 3510
			[Token(Token = "0x4000DB6")]
			Crouch,
			// Token: 0x04000DB7 RID: 3511
			[Token(Token = "0x4000DB7")]
			Sprint,
			// Token: 0x04000DB8 RID: 3512
			[Token(Token = "0x4000DB8")]
			Escape,
			// Token: 0x04000DB9 RID: 3513
			[Token(Token = "0x4000DB9")]
			Back,
			// Token: 0x04000DBA RID: 3514
			[Token(Token = "0x4000DBA")]
			Interact,
			// Token: 0x04000DBB RID: 3515
			[Token(Token = "0x4000DBB")]
			Submit,
			// Token: 0x04000DBC RID: 3516
			[Token(Token = "0x4000DBC")]
			TogglePhone,
			// Token: 0x04000DBD RID: 3517
			[Token(Token = "0x4000DBD")]
			VehicleToggleLights,
			// Token: 0x04000DBE RID: 3518
			[Token(Token = "0x4000DBE")]
			VehicleHandbrake,
			// Token: 0x04000DBF RID: 3519
			[Token(Token = "0x4000DBF")]
			RotateLeft,
			// Token: 0x04000DC0 RID: 3520
			[Token(Token = "0x4000DC0")]
			RotateRight,
			// Token: 0x04000DC1 RID: 3521
			[Token(Token = "0x4000DC1")]
			ManagementMode,
			// Token: 0x04000DC2 RID: 3522
			[Token(Token = "0x4000DC2")]
			OpenMap,
			// Token: 0x04000DC3 RID: 3523
			[Token(Token = "0x4000DC3")]
			OpenJournal,
			// Token: 0x04000DC4 RID: 3524
			[Token(Token = "0x4000DC4")]
			OpenTexts,
			// Token: 0x04000DC5 RID: 3525
			[Token(Token = "0x4000DC5")]
			QuickMove,
			// Token: 0x04000DC6 RID: 3526
			[Token(Token = "0x4000DC6")]
			ToggleFlashlight,
			// Token: 0x04000DC7 RID: 3527
			[Token(Token = "0x4000DC7")]
			ViewAvatar,
			// Token: 0x04000DC8 RID: 3528
			[Token(Token = "0x4000DC8")]
			Reload,
			// Token: 0x04000DC9 RID: 3529
			[Token(Token = "0x4000DC9")]
			InventoryLeft,
			// Token: 0x04000DCA RID: 3530
			[Token(Token = "0x4000DCA")]
			InventoryRight,
			// Token: 0x04000DCB RID: 3531
			[Token(Token = "0x4000DCB")]
			Holster,
			// Token: 0x04000DCC RID: 3532
			[Token(Token = "0x4000DCC")]
			VehicleResetCamera,
			// Token: 0x04000DCD RID: 3533
			[Token(Token = "0x4000DCD")]
			SkateboardDismount,
			// Token: 0x04000DCE RID: 3534
			[Token(Token = "0x4000DCE")]
			SkateboardMount
		}

		// Token: 0x0200028A RID: 650
		[Token(Token = "0x200028A")]
		public enum InputDeviceType
		{
			// Token: 0x04000DD0 RID: 3536
			[Token(Token = "0x4000DD0")]
			KeyboardMouse,
			// Token: 0x04000DD1 RID: 3537
			[Token(Token = "0x4000DD1")]
			Gamepad
		}

		// Token: 0x0200028B RID: 651
		[Token(Token = "0x200028B")]
		public class ExitListener
		{
			// Token: 0x06000DB9 RID: 3513 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000DB9")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public ExitListener()
			{
			}

			// Token: 0x04000DD2 RID: 3538
			[Token(Token = "0x4000DD2")]
			[FieldOffset(Offset = "0x10")]
			public GameInput.ExitDelegate listenerFunction;

			// Token: 0x04000DD3 RID: 3539
			[Token(Token = "0x4000DD3")]
			[FieldOffset(Offset = "0x18")]
			public int priority;
		}

		// Token: 0x0200028C RID: 652
		// (Invoke) Token: 0x06000DBB RID: 3515
		[Token(Token = "0x200028C")]
		public delegate void ExitDelegate(ExitAction exitAction);
	}
}
