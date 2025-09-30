using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000748 RID: 1864
	[Token(Token = "0x2000748")]
	public class BirdsEyeView : Singleton<BirdsEyeView>
	{
		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x0600328E RID: 12942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000751")]
		private Transform playerCam
		{
			[Token(Token = "0x600328E")]
			[Address(RVA = "0x7763B0", Offset = "0x774DB0", VA = "0x1807763B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x0600328F RID: 12943 RVA: 0x0000DEF0 File Offset: 0x0000C0F0
		// (set) Token: 0x06003290 RID: 12944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000752")]
		public bool isEnabled
		{
			[Token(Token = "0x600328F")]
			[Address(RVA = "0x7763A0", Offset = "0x774DA0", VA = "0x1807763A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003290")]
			[Address(RVA = "0x776430", Offset = "0x774E30", VA = "0x180776430")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003291 RID: 12945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003291")]
		[Address(RVA = "0x774C50", Offset = "0x773650", VA = "0x180774C50", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06003292 RID: 12946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003292")]
		[Address(RVA = "0x7762B0", Offset = "0x774CB0", VA = "0x1807762B0", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x06003293 RID: 12947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003293")]
		[Address(RVA = "0x775280", Offset = "0x773C80", VA = "0x180775280", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06003294 RID: 12948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003294")]
		[Address(RVA = "0x774E80", Offset = "0x773880", VA = "0x180774E80")]
		public void Enable(Vector3 startPosition, Quaternion startRotation)
		{
		}

		// Token: 0x06003295 RID: 12949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003295")]
		[Address(RVA = "0x774D80", Offset = "0x773780", VA = "0x180774D80")]
		public void Disable(bool reenableCameraLook = true)
		{
		}

		// Token: 0x06003296 RID: 12950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003296")]
		[Address(RVA = "0x7756D0", Offset = "0x7740D0", VA = "0x1807756D0")]
		protected void UpdateLateralMovement()
		{
		}

		// Token: 0x06003297 RID: 12951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003297")]
		[Address(RVA = "0x7760C0", Offset = "0x774AC0", VA = "0x1807760C0")]
		protected void UpdateScrollMovement()
		{
		}

		// Token: 0x06003298 RID: 12952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003298")]
		[Address(RVA = "0x775B80", Offset = "0x774580", VA = "0x180775B80")]
		protected void UpdateRotation()
		{
		}

		// Token: 0x06003299 RID: 12953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003299")]
		[Address(RVA = "0x775090", Offset = "0x773A90", VA = "0x180775090")]
		private void FinalizeCameraMovement()
		{
		}

		// Token: 0x0600329A RID: 12954 RVA: 0x0000DF08 File Offset: 0x0000C108
		[Token(Token = "0x600329A")]
		[Address(RVA = "0x572D40", Offset = "0x571740", VA = "0x180572D40")]
		private static float ClampAngle(float angle, float min, float max)
		{
			return 0f;
		}

		// Token: 0x0600329B RID: 12955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600329B")]
		[Address(RVA = "0x774D30", Offset = "0x773730", VA = "0x180774D30")]
		private void CancelOriginSlide()
		{
		}

		// Token: 0x0600329C RID: 12956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600329C")]
		[Address(RVA = "0x7752A0", Offset = "0x773CA0", VA = "0x1807752A0")]
		public void SlideCameraOrigin(Vector3 position, float offsetDistance, float time = 0f)
		{
		}

		// Token: 0x0600329D RID: 12957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600329D")]
		[Address(RVA = "0x7762F0", Offset = "0x774CF0", VA = "0x1807762F0")]
		public BirdsEyeView()
		{
		}

		// Token: 0x040022FA RID: 8954
		[Token(Token = "0x40022FA")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		public Vector3 bounds_Min;

		// Token: 0x040022FB RID: 8955
		[Token(Token = "0x40022FB")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 bounds_Max;

		// Token: 0x040022FC RID: 8956
		[Token(Token = "0x40022FC")]
		[FieldOffset(Offset = "0x40")]
		[Header("Camera settings")]
		public float lateralMovementSpeed;

		// Token: 0x040022FD RID: 8957
		[Token(Token = "0x40022FD")]
		[FieldOffset(Offset = "0x44")]
		public float scrollMovementSpeed;

		// Token: 0x040022FE RID: 8958
		[Token(Token = "0x40022FE")]
		[FieldOffset(Offset = "0x48")]
		public float targetFollowSpeed;

		// Token: 0x040022FF RID: 8959
		[Token(Token = "0x40022FF")]
		[FieldOffset(Offset = "0x4C")]
		[Header("Camera orbit settings")]
		public float xSpeed;

		// Token: 0x04002300 RID: 8960
		[Token(Token = "0x4002300")]
		[FieldOffset(Offset = "0x50")]
		public float ySpeed;

		// Token: 0x04002301 RID: 8961
		[Token(Token = "0x4002301")]
		[FieldOffset(Offset = "0x54")]
		public float yMinLimit;

		// Token: 0x04002302 RID: 8962
		[Token(Token = "0x4002302")]
		[FieldOffset(Offset = "0x58")]
		public float yMaxLimit;

		// Token: 0x04002303 RID: 8963
		[Token(Token = "0x4002303")]
		[FieldOffset(Offset = "0x5C")]
		private Vector3 rotationOriginPoint;

		// Token: 0x04002304 RID: 8964
		[Token(Token = "0x4002304")]
		[FieldOffset(Offset = "0x68")]
		private float distance;

		// Token: 0x04002305 RID: 8965
		[Token(Token = "0x4002305")]
		[FieldOffset(Offset = "0x6C")]
		private float prevDistance;

		// Token: 0x04002306 RID: 8966
		[Token(Token = "0x4002306")]
		[FieldOffset(Offset = "0x70")]
		private float x;

		// Token: 0x04002307 RID: 8967
		[Token(Token = "0x4002307")]
		[FieldOffset(Offset = "0x74")]
		private float y;

		// Token: 0x04002308 RID: 8968
		[Token(Token = "0x4002308")]
		[FieldOffset(Offset = "0x78")]
		private Transform targetTransform;

		// Token: 0x0400230A RID: 8970
		[Token(Token = "0x400230A")]
		[FieldOffset(Offset = "0x88")]
		private Coroutine originSlideRoutine;
	}
}
