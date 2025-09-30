using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x02000871 RID: 2161
	[Token(Token = "0x2000871")]
	public class VehicleCamera : MonoBehaviour
	{
		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06003B95 RID: 15253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000871")]
		private Transform cam
		{
			[Token(Token = "0x6003B95")]
			[Address(RVA = "0x824180", Offset = "0x822B80", VA = "0x180824180")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06003B96 RID: 15254 RVA: 0x0000FFA8 File Offset: 0x0000E1A8
		[Token(Token = "0x17000872")]
		private bool NeedSecondaryClick
		{
			[Token(Token = "0x6003B96")]
			[Address(RVA = "0x824100", Offset = "0x822B00", VA = "0x180824100")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003B97 RID: 15255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B97")]
		[Address(RVA = "0x823890", Offset = "0x822290", VA = "0x180823890", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x06003B98 RID: 15256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B98")]
		[Address(RVA = "0x823CE0", Offset = "0x8226E0", VA = "0x180823CE0")]
		private void Subscribe()
		{
		}

		// Token: 0x06003B99 RID: 15257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B99")]
		[Address(RVA = "0x823E20", Offset = "0x822820", VA = "0x180823E20", Slot = "5")]
		protected virtual void Update()
		{
		}

		// Token: 0x06003B9A RID: 15258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B9A")]
		[Address(RVA = "0x8234E0", Offset = "0x821EE0", VA = "0x1808234E0")]
		private void PlayerEnteredVehicle(LandVehicle veh)
		{
		}

		// Token: 0x06003B9B RID: 15259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B9B")]
		[Address(RVA = "0x821430", Offset = "0x81FE30", VA = "0x180821430")]
		private void CheckForClick()
		{
		}

		// Token: 0x06003B9C RID: 15260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B9C")]
		[Address(RVA = "0x8215E0", Offset = "0x81FFE0", VA = "0x1808215E0")]
		private void CheckForMouseMovement()
		{
		}

		// Token: 0x06003B9D RID: 15261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B9D")]
		[Address(RVA = "0x822D70", Offset = "0x821770", VA = "0x180822D70", Slot = "6")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06003B9E RID: 15262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B9E")]
		[Address(RVA = "0x821A40", Offset = "0x820440", VA = "0x180821A40")]
		private void HandleNonSecondaryClickCameraMovement()
		{
		}

		// Token: 0x06003B9F RID: 15263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B9F")]
		[Address(RVA = "0x822350", Offset = "0x820D50", VA = "0x180822350")]
		private void HandleSecondaryClickCameraMovement()
		{
		}

		// Token: 0x06003BA0 RID: 15264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BA0")]
		[Address(RVA = "0x8217E0", Offset = "0x8201E0", VA = "0x1808217E0")]
		private void ForceCameraReturn()
		{
		}

		// Token: 0x06003BA1 RID: 15265 RVA: 0x0000FFC0 File Offset: 0x0000E1C0
		[Token(Token = "0x6003BA1")]
		[Address(RVA = "0x572D40", Offset = "0x571740", VA = "0x180572D40")]
		private static float ClampAngle(float angle, float min, float max)
		{
			return 0f;
		}

		// Token: 0x06003BA2 RID: 15266 RVA: 0x0000FFD8 File Offset: 0x0000E1D8
		[Token(Token = "0x6003BA2")]
		[Address(RVA = "0x821880", Offset = "0x820280", VA = "0x180821880")]
		private Vector3 GetTargetCameraPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06003BA3 RID: 15267 RVA: 0x0000FFF0 File Offset: 0x0000E1F0
		[Token(Token = "0x6003BA3")]
		[Address(RVA = "0x823160", Offset = "0x821B60", VA = "0x180823160")]
		private Vector3 LimitCameraPosition(Vector3 targetPosition)
		{
			return default(Vector3);
		}

		// Token: 0x06003BA4 RID: 15268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BA4")]
		[Address(RVA = "0x80E1C0", Offset = "0x80CBC0", VA = "0x18080E1C0")]
		public VehicleCamera()
		{
		}

		// Token: 0x04002978 RID: 10616
		[Token(Token = "0x4002978")]
		private const float followDelta = 10f;

		// Token: 0x04002979 RID: 10617
		[Token(Token = "0x4002979")]
		private const float yMinLimit = -20f;

		// Token: 0x0400297A RID: 10618
		[Token(Token = "0x400297A")]
		private const float manualOverrideTime = 0.01f;

		// Token: 0x0400297B RID: 10619
		[Token(Token = "0x400297B")]
		private const float manualOverrideReturnTime = 0.6f;

		// Token: 0x0400297C RID: 10620
		[Token(Token = "0x400297C")]
		private const float xSpeed = 60f;

		// Token: 0x0400297D RID: 10621
		[Token(Token = "0x400297D")]
		private const float ySpeed = 40f;

		// Token: 0x0400297E RID: 10622
		[Token(Token = "0x400297E")]
		private const float yMaxLimit = 89f;

		// Token: 0x0400297F RID: 10623
		[Token(Token = "0x400297F")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public LandVehicle vehicle;

		// Token: 0x04002980 RID: 10624
		[Token(Token = "0x4002980")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Header("Camera Settings")]
		protected Transform cameraOrigin;

		// Token: 0x04002981 RID: 10625
		[Token(Token = "0x4002981")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected float lateralOffset;

		// Token: 0x04002982 RID: 10626
		[Token(Token = "0x4002982")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		protected float verticalOffset;

		// Token: 0x04002983 RID: 10627
		[Token(Token = "0x4002983")]
		[FieldOffset(Offset = "0x38")]
		protected bool cameraReversed;

		// Token: 0x04002984 RID: 10628
		[Token(Token = "0x4002984")]
		[FieldOffset(Offset = "0x3C")]
		protected float timeSinceCameraManuallyAdjusted;

		// Token: 0x04002985 RID: 10629
		[Token(Token = "0x4002985")]
		[FieldOffset(Offset = "0x40")]
		protected float orbitDistance;

		// Token: 0x04002986 RID: 10630
		[Token(Token = "0x4002986")]
		[FieldOffset(Offset = "0x44")]
		protected Vector3 lastFrameCameraOffset;

		// Token: 0x04002987 RID: 10631
		[Token(Token = "0x4002987")]
		[FieldOffset(Offset = "0x50")]
		protected Vector3 lastManualOffset;

		// Token: 0x04002988 RID: 10632
		[Token(Token = "0x4002988")]
		[FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		// Token: 0x04002989 RID: 10633
		[Token(Token = "0x4002989")]
		[FieldOffset(Offset = "0x68")]
		private Transform cameraDolly;

		// Token: 0x0400298A RID: 10634
		[Token(Token = "0x400298A")]
		[FieldOffset(Offset = "0x70")]
		private float x;

		// Token: 0x0400298B RID: 10635
		[Token(Token = "0x400298B")]
		[FieldOffset(Offset = "0x74")]
		private float y;

		// Token: 0x0400298C RID: 10636
		[Token(Token = "0x400298C")]
		[FieldOffset(Offset = "0x78")]
		private float mouseIdleCooldown;

		// Token: 0x0400298D RID: 10637
		[Token(Token = "0x400298D")]
		[FieldOffset(Offset = "0x7C")]
		private float mouseIdleTimer;
	}
}
