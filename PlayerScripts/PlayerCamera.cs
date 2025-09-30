using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Tools;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x02000552 RID: 1362
	[Token(Token = "0x2000552")]
	public class PlayerCamera : PlayerSingleton<PlayerCamera>
	{
		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06001D7B RID: 7547 RVA: 0x00009C48 File Offset: 0x00007E48
		// (set) Token: 0x06001D7C RID: 7548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700051A")]
		public static ScheduleOne.DevUtilities.GraphicsSettings.EAntiAliasingMode AntiAliasingMode
		{
			[Token(Token = "0x6001D7B")]
			[Address(RVA = "0x64A0E0", Offset = "0x648AE0", VA = "0x18064A0E0")]
			[CompilerGenerated]
			get
			{
				return ScheduleOne.DevUtilities.GraphicsSettings.EAntiAliasingMode.Off;
			}
			[Token(Token = "0x6001D7C")]
			[Address(RVA = "0x64A190", Offset = "0x648B90", VA = "0x18064A190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06001D7D RID: 7549 RVA: 0x00009C60 File Offset: 0x00007E60
		// (set) Token: 0x06001D7E RID: 7550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700051B")]
		public bool canLook
		{
			[Token(Token = "0x6001D7D")]
			[Address(RVA = "0x50D770", Offset = "0x50C170", VA = "0x18050D770")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001D7E")]
			[Address(RVA = "0x50DA00", Offset = "0x50C400", VA = "0x18050DA00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06001D7F RID: 7551 RVA: 0x00009C78 File Offset: 0x00007E78
		[Token(Token = "0x1700051C")]
		public int activeUIElementCount
		{
			[Token(Token = "0x6001D7F")]
			[Address(RVA = "0x64A150", Offset = "0x648B50", VA = "0x18064A150")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001D80 RID: 7552 RVA: 0x00009C90 File Offset: 0x00007E90
		// (set) Token: 0x06001D81 RID: 7553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700051D")]
		public bool transformOverriden
		{
			[Token(Token = "0x6001D80")]
			[Address(RVA = "0x50D8D0", Offset = "0x50C2D0", VA = "0x18050D8D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001D81")]
			[Address(RVA = "0x50DA90", Offset = "0x50C490", VA = "0x18050DA90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06001D82 RID: 7554 RVA: 0x00009CA8 File Offset: 0x00007EA8
		// (set) Token: 0x06001D83 RID: 7555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700051E")]
		public bool fovOverriden
		{
			[Token(Token = "0x6001D82")]
			[Address(RVA = "0x50D8E0", Offset = "0x50C2E0", VA = "0x18050D8E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001D83")]
			[Address(RVA = "0x50DAA0", Offset = "0x50C4A0", VA = "0x18050DAA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06001D84 RID: 7556 RVA: 0x00009CC0 File Offset: 0x00007EC0
		// (set) Token: 0x06001D85 RID: 7557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700051F")]
		public bool FreeCamEnabled
		{
			[Token(Token = "0x6001D84")]
			[Address(RVA = "0x64A130", Offset = "0x648B30", VA = "0x18064A130")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001D85")]
			[Address(RVA = "0x64A1F0", Offset = "0x648BF0", VA = "0x18064A1F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001D86 RID: 7558 RVA: 0x00009CD8 File Offset: 0x00007ED8
		// (set) Token: 0x06001D87 RID: 7559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000520")]
		public bool ViewingAvatar
		{
			[Token(Token = "0x6001D86")]
			[Address(RVA = "0x64A140", Offset = "0x648B40", VA = "0x18064A140")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001D87")]
			[Address(RVA = "0x64A210", Offset = "0x648C10", VA = "0x18064A210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06001D88 RID: 7560 RVA: 0x00009CF0 File Offset: 0x00007EF0
		// (set) Token: 0x06001D89 RID: 7561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000521")]
		public PlayerCamera.ECameraMode CameraMode
		{
			[Token(Token = "0x6001D88")]
			[Address(RVA = "0x5178E0", Offset = "0x5162E0", VA = "0x1805178E0")]
			[CompilerGenerated]
			get
			{
				return PlayerCamera.ECameraMode.Default;
			}
			[Token(Token = "0x6001D89")]
			[Address(RVA = "0x517A90", Offset = "0x516490", VA = "0x180517A90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001D8A RID: 7562 RVA: 0x00009D08 File Offset: 0x00007F08
		// (set) Token: 0x06001D8B RID: 7563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000522")]
		public bool MethVisuals
		{
			[Token(Token = "0x6001D8A")]
			[Address(RVA = "0x54C570", Offset = "0x54AF70", VA = "0x18054C570")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001D8B")]
			[Address(RVA = "0x64A200", Offset = "0x648C00", VA = "0x18064A200")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001D8C RID: 7564 RVA: 0x00009D20 File Offset: 0x00007F20
		// (set) Token: 0x06001D8D RID: 7565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000523")]
		public bool CocaineVisuals
		{
			[Token(Token = "0x6001D8C")]
			[Address(RVA = "0x64A120", Offset = "0x648B20", VA = "0x18064A120")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001D8D")]
			[Address(RVA = "0x64A1D0", Offset = "0x648BD0", VA = "0x18064A1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001D8E RID: 7566 RVA: 0x00009D38 File Offset: 0x00007F38
		// (set) Token: 0x06001D8F RID: 7567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000524")]
		public float FovJitter
		{
			[Token(Token = "0x6001D8E")]
			[Address(RVA = "0x535DD0", Offset = "0x5347D0", VA = "0x180535DD0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001D8F")]
			[Address(RVA = "0x64A1E0", Offset = "0x648BE0", VA = "0x18064A1E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06001D90 RID: 7568 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D91 RID: 7569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000525")]
		public List<string> activeUIElements
		{
			[Token(Token = "0x6001D90")]
			[Address(RVA = "0x50D8C0", Offset = "0x50C2C0", VA = "0x18050D8C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D91")]
			[Address(RVA = "0x50DA70", Offset = "0x50C470", VA = "0x18050DA70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D92")]
		[Address(RVA = "0x643680", Offset = "0x642080", VA = "0x180643680", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D93")]
		[Address(RVA = "0x645390", Offset = "0x643D90", VA = "0x180645390", Slot = "6")]
		public override void OnStartClient(bool IsOwner)
		{
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D94")]
		[Address(RVA = "0x647AA0", Offset = "0x6464A0", VA = "0x180647AA0", Slot = "5")]
		protected override void Start()
		{
		}

		// Token: 0x06001D95 RID: 7573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D95")]
		[Address(RVA = "0x6457C0", Offset = "0x6441C0", VA = "0x1806457C0")]
		private void PlayerSpawned()
		{
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D96")]
		[Address(RVA = "0x647400", Offset = "0x645E00", VA = "0x180647400")]
		public static void SetAntialiasingMode(ScheduleOne.DevUtilities.GraphicsSettings.EAntiAliasingMode mode)
		{
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D97")]
		[Address(RVA = "0x6435D0", Offset = "0x641FD0", VA = "0x1806435D0")]
		public void ApplyAASettings()
		{
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D98")]
		[Address(RVA = "0x648F30", Offset = "0x647930", VA = "0x180648F30", Slot = "8")]
		protected virtual void Update()
		{
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D99")]
		[Address(RVA = "0x6473A0", Offset = "0x645DA0", VA = "0x1806473A0")]
		private void Screenshot()
		{
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D9A")]
		[Address(RVA = "0x643FF0", Offset = "0x6429F0", VA = "0x180643FF0", Slot = "9")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D9B")]
		[Address(RVA = "0x643B20", Offset = "0x642520", VA = "0x180643B20")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x00009D50 File Offset: 0x00007F50
		[Token(Token = "0x6001D9C")]
		[Address(RVA = "0x643D20", Offset = "0x642720", VA = "0x180643D20")]
		public float GetTargetLocalY()
		{
			return 0f;
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D9D")]
		[Address(RVA = "0x517A90", Offset = "0x516490", VA = "0x180517A90")]
		public void SetCameraMode(PlayerCamera.ECameraMode mode)
		{
		}

		// Token: 0x06001D9E RID: 7582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D9E")]
		[Address(RVA = "0x646560", Offset = "0x644F60", VA = "0x180646560")]
		private void RotateCamera()
		{
		}

		// Token: 0x06001D9F RID: 7583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D9F")]
		[Address(RVA = "0x644550", Offset = "0x642F50", VA = "0x180644550")]
		public void LockMouse()
		{
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DA0")]
		[Address(RVA = "0x643C70", Offset = "0x642670", VA = "0x180643C70")]
		public void FreeMouse()
		{
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x00009D68 File Offset: 0x00007F68
		[Token(Token = "0x6001DA1")]
		[Address(RVA = "0x644AE0", Offset = "0x6434E0", VA = "0x180644AE0")]
		public bool LookRaycast(float range, out RaycastHit hit, LayerMask layerMask, bool includeTriggers = true, float radius = 0f)
		{
			return default(bool);
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x00009D80 File Offset: 0x00007F80
		[Token(Token = "0x6001DA2")]
		[Address(RVA = "0x6446E0", Offset = "0x6430E0", VA = "0x1806446E0")]
		public bool LookRaycast_ExcludeBuildables(float range, out RaycastHit hit, LayerMask layerMask, bool includeTriggers = true)
		{
			return default(bool);
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DA3")]
		[Address(RVA = "0x6452A0", Offset = "0x643CA0", VA = "0x1806452A0")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x00009D98 File Offset: 0x00007F98
		[Token(Token = "0x6001DA4")]
		[Address(RVA = "0x645CD0", Offset = "0x6446D0", VA = "0x180645CD0")]
		public bool Raycast_ExcludeBuildables(Vector3 origin, Vector3 direction, float range, out RaycastHit hit, LayerMask layerMask, bool includeTriggers = false, float radius = 0f, float maxAngleDifference = 0f)
		{
			return default(bool);
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x00009DB0 File Offset: 0x00007FB0
		[Token(Token = "0x6001DA5")]
		[Address(RVA = "0x644E90", Offset = "0x643890", VA = "0x180644E90")]
		public bool MouseRaycast(float range, out RaycastHit hit, LayerMask layerMask, bool includeTriggers = true, float radius = 0f)
		{
			return default(bool);
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x00009DC8 File Offset: 0x00007FC8
		[Token(Token = "0x6001DA6")]
		[Address(RVA = "0x644D30", Offset = "0x643730", VA = "0x180644D30")]
		public bool LookSpherecast(float range, float radius, out RaycastHit hit, LayerMask layerMask)
		{
			return default(bool);
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DA7")]
		[Address(RVA = "0x645590", Offset = "0x643F90", VA = "0x180645590")]
		public void OverrideTransform(Vector3 worldPos, Quaternion rot, float lerpTime, bool keepParented = false)
		{
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DA8")]
		[Address(RVA = "0x643DE0", Offset = "0x6427E0", VA = "0x180643DE0")]
		protected IEnumerator ILerpCamera(Vector3 endPos, Quaternion endRot, float lerpTime, bool worldSpace, bool returnToRestingPosition = false, bool reenableLook = false)
		{
			return null;
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DA9")]
		[Address(RVA = "0x647FE0", Offset = "0x6469E0", VA = "0x180647FE0")]
		public void StopTransformOverride(float lerpTime, bool reenableCameraLook = true, bool returnToOriginalRotation = true)
		{
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DAA")]
		[Address(RVA = "0x644610", Offset = "0x643010", VA = "0x180644610")]
		public void LookAt(Vector3 point, float duration = 0.25f)
		{
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DAB")]
		[Address(RVA = "0x647530", Offset = "0x645F30", VA = "0x180647530")]
		private void SetCanLook_True()
		{
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DAC")]
		[Address(RVA = "0x50DA00", Offset = "0x50C400", VA = "0x18050DA00")]
		public void SetCanLook(bool c)
		{
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DAD")]
		[Address(RVA = "0x647540", Offset = "0x645F40", VA = "0x180647540")]
		public void SetDoFActive(bool active, float lerpTime)
		{
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DAE")]
		[Address(RVA = "0x6444B0", Offset = "0x642EB0", VA = "0x1806444B0")]
		private IEnumerator LerpDoF(bool active, float lerpTime)
		{
			return null;
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DAF")]
		[Address(RVA = "0x645440", Offset = "0x643E40", VA = "0x180645440")]
		public void OverrideFOV(float fov, float lerpTime)
		{
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DB0")]
		[Address(RVA = "0x643EB0", Offset = "0x6428B0", VA = "0x180643EB0")]
		protected IEnumerator ILerpFOV(float endFov, float lerpTime)
		{
			return null;
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DB1")]
		[Address(RVA = "0x647E50", Offset = "0x646850", VA = "0x180647E50")]
		public void StopFOVOverride(float lerpTime)
		{
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DB2")]
		[Address(RVA = "0x643540", Offset = "0x641F40", VA = "0x180643540")]
		public void AddActiveUIElement(string name)
		{
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DB3")]
		[Address(RVA = "0x646460", Offset = "0x644E60", VA = "0x180646460")]
		public void RemoveActiveUIElement(string name)
		{
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DB4")]
		[Address(RVA = "0x646280", Offset = "0x644C80", VA = "0x180646280")]
		public void RegisterMovementEvent(int threshold, Action action)
		{
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DB5")]
		[Address(RVA = "0x643930", Offset = "0x642330", VA = "0x180643930")]
		public void DeregisterMovementEvent(Action action)
		{
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DB6")]
		[Address(RVA = "0x648C30", Offset = "0x647630", VA = "0x180648C30")]
		private void UpdateMovementEvents()
		{
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DB7")]
		[Address(RVA = "0x649860", Offset = "0x648260", VA = "0x180649860")]
		private void ViewAvatar()
		{
		}

		// Token: 0x06001DB8 RID: 7608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DB8")]
		[Address(RVA = "0x648480", Offset = "0x646E80", VA = "0x180648480")]
		private void StopViewingAvatar()
		{
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DB9")]
		[Address(RVA = "0x643F70", Offset = "0x642970", VA = "0x180643F70")]
		public void JoltCamera()
		{
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x00009DE0 File Offset: 0x00007FE0
		[Token(Token = "0x6001DBA")]
		[Address(RVA = "0x6458F0", Offset = "0x6442F0", VA = "0x1806458F0")]
		public bool PointInCameraView(Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x00009DF8 File Offset: 0x00007FF8
		[Token(Token = "0x6001DBB")]
		[Address(RVA = "0x643F50", Offset = "0x642950", VA = "0x180643F50")]
		public bool Is01(float a)
		{
			return default(bool);
		}

		// Token: 0x06001DBC RID: 7612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DBC")]
		[Address(RVA = "0x6464F0", Offset = "0x644EF0", VA = "0x1806464F0")]
		public void ResetRotation()
		{
		}

		// Token: 0x06001DBD RID: 7613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DBD")]
		[Address(RVA = "0x643BA0", Offset = "0x6425A0", VA = "0x180643BA0")]
		public void FocusCameraOnTarget(Transform target)
		{
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DBE")]
		[Address(RVA = "0x647FA0", Offset = "0x6469A0", VA = "0x180647FA0")]
		public void StopFocus()
		{
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DBF")]
		[Address(RVA = "0x647940", Offset = "0x646340", VA = "0x180647940")]
		public void StartCameraShake(float intensity, float duration = -1f, bool decreaseOverTime = true)
		{
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC0")]
		[Address(RVA = "0x647DB0", Offset = "0x6467B0", VA = "0x180647DB0")]
		public void StopCameraShake()
		{
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC1")]
		[Address(RVA = "0x648790", Offset = "0x647190", VA = "0x180648790")]
		public void UpdateCameraBob()
		{
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC2")]
		[Address(RVA = "0x647610", Offset = "0x646010", VA = "0x180647610")]
		public void SetFreeCam(bool enable, bool reenableLook = true)
		{
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC3")]
		[Address(RVA = "0x646E40", Offset = "0x645840", VA = "0x180646E40")]
		private void RotateFreeCam()
		{
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC4")]
		[Address(RVA = "0x648960", Offset = "0x647360", VA = "0x180648960")]
		private void UpdateFreeCamInput()
		{
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC5")]
		[Address(RVA = "0x6450A0", Offset = "0x643AA0", VA = "0x1806450A0")]
		private void MoveFreeCam()
		{
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC6")]
		[Address(RVA = "0x649E20", Offset = "0x648820", VA = "0x180649E20")]
		public PlayerCamera()
		{
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DC8")]
		[Address(RVA = "0x648740", Offset = "0x647140", VA = "0x180648740")]
		[CompilerGenerated]
		internal static IEnumerator <Screenshot>g__Routine|96_0()
		{
			return null;
		}

		// Token: 0x04001828 RID: 6184
		[Token(Token = "0x4001828")]
		public const float CAMERA_SHAKE_MULTIPLIER = 0.1f;

		// Token: 0x0400182A RID: 6186
		[Token(Token = "0x400182A")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		public float cameraOffsetFromTop;

		// Token: 0x0400182B RID: 6187
		[Token(Token = "0x400182B")]
		[FieldOffset(Offset = "0x24")]
		public float SprintFoVBoost;

		// Token: 0x0400182C RID: 6188
		[Token(Token = "0x400182C")]
		[FieldOffset(Offset = "0x28")]
		public float FoVChangeRate;

		// Token: 0x0400182D RID: 6189
		[Token(Token = "0x400182D")]
		[FieldOffset(Offset = "0x2C")]
		public float HorizontalCameraBob;

		// Token: 0x0400182E RID: 6190
		[Token(Token = "0x400182E")]
		[FieldOffset(Offset = "0x30")]
		public float VerticalCameraBob;

		// Token: 0x0400182F RID: 6191
		[Token(Token = "0x400182F")]
		[FieldOffset(Offset = "0x34")]
		public float BobRate;

		// Token: 0x04001830 RID: 6192
		[Token(Token = "0x4001830")]
		[FieldOffset(Offset = "0x38")]
		public AnimationCurve HorizontalBobCurve;

		// Token: 0x04001831 RID: 6193
		[Token(Token = "0x4001831")]
		[FieldOffset(Offset = "0x40")]
		public AnimationCurve VerticalBobCurve;

		// Token: 0x04001832 RID: 6194
		[Token(Token = "0x4001832")]
		[FieldOffset(Offset = "0x48")]
		public float FreeCamSpeed;

		// Token: 0x04001833 RID: 6195
		[Token(Token = "0x4001833")]
		[FieldOffset(Offset = "0x4C")]
		public float FreeCamAcceleration;

		// Token: 0x04001834 RID: 6196
		[Token(Token = "0x4001834")]
		[FieldOffset(Offset = "0x50")]
		public bool SmoothLook;

		// Token: 0x04001835 RID: 6197
		[Token(Token = "0x4001835")]
		[FieldOffset(Offset = "0x54")]
		public float SmoothLookSpeed;

		// Token: 0x04001836 RID: 6198
		[Token(Token = "0x4001836")]
		[FieldOffset(Offset = "0x58")]
		public FloatSmoother FoVChangeSmoother;

		// Token: 0x04001837 RID: 6199
		[Token(Token = "0x4001837")]
		[FieldOffset(Offset = "0x60")]
		public FloatSmoother SmoothLookSmoother;

		// Token: 0x04001838 RID: 6200
		[Token(Token = "0x4001838")]
		[FieldOffset(Offset = "0x68")]
		[Header("References")]
		public Transform CameraContainer;

		// Token: 0x04001839 RID: 6201
		[Token(Token = "0x4001839")]
		[FieldOffset(Offset = "0x70")]
		public Camera Camera;

		// Token: 0x0400183A RID: 6202
		[Token(Token = "0x400183A")]
		[FieldOffset(Offset = "0x78")]
		public Camera OverlayCamera;

		// Token: 0x0400183B RID: 6203
		[Token(Token = "0x400183B")]
		[FieldOffset(Offset = "0x80")]
		public Animator Animator;

		// Token: 0x0400183C RID: 6204
		[Token(Token = "0x400183C")]
		[FieldOffset(Offset = "0x88")]
		public AnimationClip[] JoltClips;

		// Token: 0x0400183D RID: 6205
		[Token(Token = "0x400183D")]
		[FieldOffset(Offset = "0x90")]
		public UniversalRenderPipelineAsset[] URPAssets;

		// Token: 0x0400183E RID: 6206
		[Token(Token = "0x400183E")]
		[FieldOffset(Offset = "0x98")]
		public Transform ViewAvatarCameraPosition;

		// Token: 0x0400183F RID: 6207
		[Token(Token = "0x400183F")]
		[FieldOffset(Offset = "0xA0")]
		public HeartbeatSoundController HeartbeatSoundController;

		// Token: 0x04001840 RID: 6208
		[Token(Token = "0x4001840")]
		[FieldOffset(Offset = "0xA8")]
		public ParticleSystem Flies;

		// Token: 0x04001841 RID: 6209
		[Token(Token = "0x4001841")]
		[FieldOffset(Offset = "0xB0")]
		public AudioSourceController MethRumble;

		// Token: 0x04001842 RID: 6210
		[Token(Token = "0x4001842")]
		[FieldOffset(Offset = "0xB8")]
		public RandomizedAudioSourceController SchizoVoices;

		// Token: 0x04001846 RID: 6214
		[Token(Token = "0x4001846")]
		[FieldOffset(Offset = "0xC3")]
		[HideInInspector]
		public bool blockNextStopTransformOverride;

		// Token: 0x0400184D RID: 6221
		[Token(Token = "0x400184D")]
		[FieldOffset(Offset = "0xD8")]
		private Volume globalVolume;

		// Token: 0x0400184E RID: 6222
		[Token(Token = "0x400184E")]
		[FieldOffset(Offset = "0xE0")]
		private DepthOfField DoF;

		// Token: 0x04001850 RID: 6224
		[Token(Token = "0x4001850")]
		[FieldOffset(Offset = "0xF0")]
		private Coroutine cameraShakeCoroutine;

		// Token: 0x04001851 RID: 6225
		[Token(Token = "0x4001851")]
		[FieldOffset(Offset = "0xF8")]
		private Vector3 cameraLocalPos;

		// Token: 0x04001852 RID: 6226
		[Token(Token = "0x4001852")]
		[FieldOffset(Offset = "0x104")]
		private Vector3 freeCamMovement;

		// Token: 0x04001853 RID: 6227
		[Token(Token = "0x4001853")]
		[FieldOffset(Offset = "0x110")]
		private Coroutine focusRoutine;

		// Token: 0x04001854 RID: 6228
		[Token(Token = "0x4001854")]
		[FieldOffset(Offset = "0x118")]
		private float focusMouseX;

		// Token: 0x04001855 RID: 6229
		[Token(Token = "0x4001855")]
		[FieldOffset(Offset = "0x11C")]
		private float focusMouseY;

		// Token: 0x04001856 RID: 6230
		[Token(Token = "0x4001856")]
		[FieldOffset(Offset = "0x120")]
		private Dictionary<int, PlayerMovement.MovementEvent> movementEvents;

		// Token: 0x04001857 RID: 6231
		[Token(Token = "0x4001857")]
		[FieldOffset(Offset = "0x128")]
		private float freeCamSpeed;

		// Token: 0x04001858 RID: 6232
		[Token(Token = "0x4001858")]
		[FieldOffset(Offset = "0x12C")]
		private float mouseX;

		// Token: 0x04001859 RID: 6233
		[Token(Token = "0x4001859")]
		[FieldOffset(Offset = "0x130")]
		private float mouseY;

		// Token: 0x0400185A RID: 6234
		[Token(Token = "0x400185A")]
		[FieldOffset(Offset = "0x134")]
		private Vector2 seizureJitter;

		// Token: 0x0400185B RID: 6235
		[Token(Token = "0x400185B")]
		[FieldOffset(Offset = "0x13C")]
		private float schizoFoV;

		// Token: 0x0400185C RID: 6236
		[Token(Token = "0x400185C")]
		[FieldOffset(Offset = "0x140")]
		private float timeUntilNextSchizoVoice;

		// Token: 0x0400185D RID: 6237
		[Token(Token = "0x400185D")]
		[FieldOffset(Offset = "0x148")]
		private List<Vector3> gizmos;

		// Token: 0x0400185E RID: 6238
		[Token(Token = "0x400185E")]
		[FieldOffset(Offset = "0x150")]
		private Vector3 cameralocalPos_PriorOverride;

		// Token: 0x0400185F RID: 6239
		[Token(Token = "0x400185F")]
		[FieldOffset(Offset = "0x15C")]
		private Quaternion cameraLocalRot_PriorOverride;

		// Token: 0x04001860 RID: 6240
		[Token(Token = "0x4001860")]
		[FieldOffset(Offset = "0x170")]
		public Coroutine ILerpCamera_Coroutine;

		// Token: 0x04001861 RID: 6241
		[Token(Token = "0x4001861")]
		[FieldOffset(Offset = "0x178")]
		private Coroutine lookRoutine;

		// Token: 0x04001862 RID: 6242
		[Token(Token = "0x4001862")]
		[FieldOffset(Offset = "0x180")]
		private Coroutine DoFCoroutine;

		// Token: 0x04001863 RID: 6243
		[Token(Token = "0x4001863")]
		[FieldOffset(Offset = "0x188")]
		private Coroutine ILerpCameraFOV_Coroutine;

		// Token: 0x02000553 RID: 1363
		[Token(Token = "0x2000553")]
		public enum ECameraMode
		{
			// Token: 0x04001865 RID: 6245
			[Token(Token = "0x4001865")]
			Default,
			// Token: 0x04001866 RID: 6246
			[Token(Token = "0x4001866")]
			Vehicle,
			// Token: 0x04001867 RID: 6247
			[Token(Token = "0x4001867")]
			Skateboard
		}
	}
}
