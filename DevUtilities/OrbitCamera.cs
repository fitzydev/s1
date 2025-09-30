using System;
using System.Runtime.CompilerServices;
using EasyButtons;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x0200075D RID: 1885
	[Token(Token = "0x200075D")]
	public class OrbitCamera : MonoBehaviour
	{
		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06003322 RID: 13090 RVA: 0x0000E148 File Offset: 0x0000C348
		// (set) Token: 0x06003323 RID: 13091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700076E")]
		public bool isEnabled
		{
			[Token(Token = "0x6003322")]
			[Address(RVA = "0x4BCA70", Offset = "0x4BB470", VA = "0x1804BCA70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003323")]
			[Address(RVA = "0x785B70", Offset = "0x784570", VA = "0x180785B70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06003324 RID: 13092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700076F")]
		protected Transform cam
		{
			[Token(Token = "0x6003324")]
			[Address(RVA = "0x785AF0", Offset = "0x7844F0", VA = "0x180785AF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003325 RID: 13093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003325")]
		[Address(RVA = "0x784F80", Offset = "0x783980", VA = "0x180784F80", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06003326 RID: 13094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003326")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x06003327 RID: 13095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003327")]
		[Address(RVA = "0x785A20", Offset = "0x784420", VA = "0x180785A20", Slot = "6")]
		protected virtual void Update()
		{
		}

		// Token: 0x06003328 RID: 13096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003328")]
		[Address(RVA = "0x7855E0", Offset = "0x783FE0", VA = "0x1807855E0", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06003329 RID: 13097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003329")]
		[Address(RVA = "0x785140", Offset = "0x783B40", VA = "0x180785140")]
		[Button]
		public void Enable()
		{
		}

		// Token: 0x0600332A RID: 13098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600332A")]
		[Address(RVA = "0x785050", Offset = "0x783A50", VA = "0x180785050")]
		public void Disable()
		{
		}

		// Token: 0x0600332B RID: 13099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600332B")]
		[Address(RVA = "0x7855F0", Offset = "0x783FF0", VA = "0x1807855F0")]
		protected void UpdateRotation()
		{
		}

		// Token: 0x0600332C RID: 13100 RVA: 0x0000E160 File Offset: 0x0000C360
		[Token(Token = "0x600332C")]
		[Address(RVA = "0x572D40", Offset = "0x571740", VA = "0x180572D40")]
		private static float ClampAngle(float angle, float min, float max)
		{
			return 0f;
		}

		// Token: 0x0600332D RID: 13101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600332D")]
		[Address(RVA = "0x7853F0", Offset = "0x783DF0", VA = "0x1807853F0")]
		private void FinalizeCameraMovement()
		{
		}

		// Token: 0x0600332E RID: 13102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600332E")]
		[Address(RVA = "0x785A80", Offset = "0x784480", VA = "0x180785A80")]
		public OrbitCamera()
		{
		}

		// Token: 0x04002373 RID: 9075
		[Token(Token = "0x4002373")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		[SerializeField]
		protected Transform cameraStartPoint;

		// Token: 0x04002374 RID: 9076
		[Token(Token = "0x4002374")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected Transform centrePoint;

		// Token: 0x04002375 RID: 9077
		[Token(Token = "0x4002375")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public float targetFollowSpeed;

		// Token: 0x04002376 RID: 9078
		[Token(Token = "0x4002376")]
		[FieldOffset(Offset = "0x34")]
		public float yMinLimit;

		// Token: 0x04002377 RID: 9079
		[Token(Token = "0x4002377")]
		[FieldOffset(Offset = "0x38")]
		public float yMaxLimit;

		// Token: 0x04002378 RID: 9080
		[Token(Token = "0x4002378")]
		[FieldOffset(Offset = "0x0")]
		public static float xSpeed;

		// Token: 0x04002379 RID: 9081
		[Token(Token = "0x4002379")]
		[FieldOffset(Offset = "0x4")]
		public static float ySpeed;

		// Token: 0x0400237B RID: 9083
		[Token(Token = "0x400237B")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 rotationOriginPoint;

		// Token: 0x0400237C RID: 9084
		[Token(Token = "0x400237C")]
		[FieldOffset(Offset = "0x4C")]
		private float distance;

		// Token: 0x0400237D RID: 9085
		[Token(Token = "0x400237D")]
		[FieldOffset(Offset = "0x50")]
		private float prevDistance;

		// Token: 0x0400237E RID: 9086
		[Token(Token = "0x400237E")]
		[FieldOffset(Offset = "0x54")]
		private float x;

		// Token: 0x0400237F RID: 9087
		[Token(Token = "0x400237F")]
		[FieldOffset(Offset = "0x58")]
		private float y;

		// Token: 0x04002380 RID: 9088
		[Token(Token = "0x4002380")]
		[FieldOffset(Offset = "0x60")]
		private Transform targetTransform;
	}
}
