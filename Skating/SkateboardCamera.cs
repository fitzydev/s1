using System;
using FishNet.Object;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Skating
{
	// Token: 0x020002DD RID: 733
	[Token(Token = "0x20002DD")]
	[RequireComponent(typeof(Skateboard))]
	public class SkateboardCamera : NetworkBehaviour
	{
		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700034C")]
		private Transform cam
		{
			[Token(Token = "0x6000FDF")]
			[Address(RVA = "0xAE7BB0", Offset = "0xAE65B0", VA = "0x180AE7BB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x00007938 File Offset: 0x00005B38
		[Token(Token = "0x1700034D")]
		private bool NeedSecondaryClick
		{
			[Token(Token = "0x6000FE0")]
			[Address(RVA = "0xAE7B30", Offset = "0xAE6530", VA = "0x180AE7B30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FE1")]
		[Address(RVA = "0xAE4AD0", Offset = "0xAE34D0", VA = "0x180AE4AD0", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FE2")]
		[Address(RVA = "0xAE6CD0", Offset = "0xAE56D0", VA = "0x180AE6CD0")]
		private void OnPlayerMountedSkateboard(Skateboard skateboard)
		{
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FE3")]
		[Address(RVA = "0xAE7080", Offset = "0xAE5A80", VA = "0x180AE7080", Slot = "11")]
		public override void OnStartClient()
		{
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FE4")]
		[Address(RVA = "0xAE6AD0", Offset = "0xAE54D0", VA = "0x180AE6AD0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FE5")]
		[Address(RVA = "0xAE7700", Offset = "0xAE6100", VA = "0x180AE7700")]
		private void Update()
		{
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FE6")]
		[Address(RVA = "0xAE4B20", Offset = "0xAE3520", VA = "0x180AE4B20")]
		private void CheckForClick()
		{
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FE7")]
		[Address(RVA = "0xAE4D10", Offset = "0xAE3710", VA = "0x180AE4D10")]
		private void CheckForMouseMovement()
		{
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FE8")]
		[Address(RVA = "0xAE6670", Offset = "0xAE5070", VA = "0x180AE6670")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FE9")]
		[Address(RVA = "0xAE70D0", Offset = "0xAE5AD0", VA = "0x180AE70D0")]
		private void UpdateCamera()
		{
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FEA")]
		[Address(RVA = "0xAE5270", Offset = "0xAE3C70", VA = "0x180AE5270")]
		private void HandleNonSecondaryClickCameraMovement()
		{
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FEB")]
		[Address(RVA = "0xAE5BE0", Offset = "0xAE45E0", VA = "0x180AE5BE0")]
		private void HandleSecondaryClickCameraMovement()
		{
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FEC")]
		[Address(RVA = "0xAE74B0", Offset = "0xAE5EB0", VA = "0x180AE74B0")]
		private void UpdateFOV()
		{
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FED")]
		[Address(RVA = "0xAE4F30", Offset = "0xAE3930", VA = "0x180AE4F30")]
		private void ForceCameraReturn()
		{
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x00007950 File Offset: 0x00005B50
		[Token(Token = "0x6000FEE")]
		[Address(RVA = "0x572D40", Offset = "0x571740", VA = "0x180572D40")]
		private static float ClampAngle(float angle, float min, float max)
		{
			return 0f;
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x00007968 File Offset: 0x00005B68
		[Token(Token = "0x6000FEF")]
		[Address(RVA = "0xAE4FF0", Offset = "0xAE39F0", VA = "0x180AE4FF0")]
		private Vector3 GetTargetCameraPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x00007980 File Offset: 0x00005B80
		[Token(Token = "0x6000FF0")]
		[Address(RVA = "0xAE6700", Offset = "0xAE5100", VA = "0x180AE6700")]
		private Vector3 LimitCameraPosition(Vector3 targetPosition)
		{
			return default(Vector3);
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FF1")]
		[Address(RVA = "0xAE7A30", Offset = "0xAE6430", VA = "0x180AE7A30")]
		public SkateboardCamera()
		{
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FF2")]
		[Address(RVA = "0xAE6AB0", Offset = "0xAE54B0", VA = "0x180AE6AB0", Slot = "20")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FF3")]
		[Address(RVA = "0xAE6A90", Offset = "0xAE5490", VA = "0x180AE6A90", Slot = "21")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FF4")]
		[Address(RVA = "0x6783D0", Offset = "0x676DD0", VA = "0x1806783D0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FF5")]
		[Address(RVA = "0xAE4760", Offset = "0xAE3160", VA = "0x180AE4760")]
		private void Awake_UserLogic_ScheduleOne.Skating.SkateboardCamera_Assembly-CSharp.dll()
		{
		}

		// Token: 0x0400101D RID: 4125
		[Token(Token = "0x400101D")]
		private const float followDelta = 7.5f;

		// Token: 0x0400101E RID: 4126
		[Token(Token = "0x400101E")]
		private const float yMinLimit = -20f;

		// Token: 0x0400101F RID: 4127
		[Token(Token = "0x400101F")]
		private const float manualOverrideTime = 0.01f;

		// Token: 0x04001020 RID: 4128
		[Token(Token = "0x4001020")]
		private const float manualOverrideReturnTime = 0.6f;

		// Token: 0x04001021 RID: 4129
		[Token(Token = "0x4001021")]
		private const float xSpeed = 60f;

		// Token: 0x04001022 RID: 4130
		[Token(Token = "0x4001022")]
		private const float ySpeed = 40f;

		// Token: 0x04001023 RID: 4131
		[Token(Token = "0x4001023")]
		private const float yMaxLimit = 89f;

		// Token: 0x04001024 RID: 4132
		[Token(Token = "0x4001024")]
		[FieldOffset(Offset = "0x118")]
		[Header("References")]
		public Transform cameraOrigin;

		// Token: 0x04001025 RID: 4133
		[Token(Token = "0x4001025")]
		[FieldOffset(Offset = "0x120")]
		[Header("Settings")]
		public float CameraFollowSpeed;

		// Token: 0x04001026 RID: 4134
		[Token(Token = "0x4001026")]
		[FieldOffset(Offset = "0x124")]
		public float HorizontalOffset;

		// Token: 0x04001027 RID: 4135
		[Token(Token = "0x4001027")]
		[FieldOffset(Offset = "0x128")]
		public float VerticalOffset;

		// Token: 0x04001028 RID: 4136
		[Token(Token = "0x4001028")]
		[FieldOffset(Offset = "0x12C")]
		public float CameraDownAngle;

		// Token: 0x04001029 RID: 4137
		[Token(Token = "0x4001029")]
		[FieldOffset(Offset = "0x130")]
		[Header("Settings")]
		public float FOVMultiplier_MinSpeed;

		// Token: 0x0400102A RID: 4138
		[Token(Token = "0x400102A")]
		[FieldOffset(Offset = "0x134")]
		public float FOVMultiplier_MaxSpeed;

		// Token: 0x0400102B RID: 4139
		[Token(Token = "0x400102B")]
		[FieldOffset(Offset = "0x138")]
		public float FOVMultiplierChangeRate;

		// Token: 0x0400102C RID: 4140
		[Token(Token = "0x400102C")]
		[FieldOffset(Offset = "0x140")]
		private Skateboard board;

		// Token: 0x0400102D RID: 4141
		[Token(Token = "0x400102D")]
		[FieldOffset(Offset = "0x148")]
		private float currentFovMultiplier;

		// Token: 0x0400102E RID: 4142
		[Token(Token = "0x400102E")]
		[FieldOffset(Offset = "0x14C")]
		private bool cameraReversed;

		// Token: 0x0400102F RID: 4143
		[Token(Token = "0x400102F")]
		[FieldOffset(Offset = "0x14D")]
		private bool cameraAdjusted;

		// Token: 0x04001030 RID: 4144
		[Token(Token = "0x4001030")]
		[FieldOffset(Offset = "0x150")]
		private float timeSinceCameraManuallyAdjusted;

		// Token: 0x04001031 RID: 4145
		[Token(Token = "0x4001031")]
		[FieldOffset(Offset = "0x154")]
		private float orbitDistance;

		// Token: 0x04001032 RID: 4146
		[Token(Token = "0x4001032")]
		[FieldOffset(Offset = "0x158")]
		private Vector3 lastFrameCameraOffset;

		// Token: 0x04001033 RID: 4147
		[Token(Token = "0x4001033")]
		[FieldOffset(Offset = "0x164")]
		private Vector3 lastManualOffset;

		// Token: 0x04001034 RID: 4148
		[Token(Token = "0x4001034")]
		[FieldOffset(Offset = "0x170")]
		private Transform targetTransform;

		// Token: 0x04001035 RID: 4149
		[Token(Token = "0x4001035")]
		[FieldOffset(Offset = "0x178")]
		private Transform cameraDolly;

		// Token: 0x04001036 RID: 4150
		[Token(Token = "0x4001036")]
		[FieldOffset(Offset = "0x180")]
		private float x;

		// Token: 0x04001037 RID: 4151
		[Token(Token = "0x4001037")]
		[FieldOffset(Offset = "0x184")]
		private float y;

		// Token: 0x04001038 RID: 4152
		[Token(Token = "0x4001038")]
		[FieldOffset(Offset = "0x188")]
		private float mouseIdleCooldown;

		// Token: 0x04001039 RID: 4153
		[Token(Token = "0x4001039")]
		[FieldOffset(Offset = "0x18C")]
		private float mouseIdleTimer;

		// Token: 0x0400103A RID: 4154
		[Token(Token = "0x400103A")]
		[FieldOffset(Offset = "0x190")]
		private bool NetworkInitialize___EarlyScheduleOne.Skating.SkateboardCameraAssembly-CSharp.dll_Excuted;

		// Token: 0x0400103B RID: 4155
		[Token(Token = "0x400103B")]
		[FieldOffset(Offset = "0x191")]
		private bool NetworkInitialize__LateScheduleOne.Skating.SkateboardCameraAssembly-CSharp.dll_Excuted;
	}
}
