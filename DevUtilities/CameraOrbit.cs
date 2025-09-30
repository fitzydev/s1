using System;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework.Animation;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x0200074B RID: 1867
	[Token(Token = "0x200074B")]
	public class CameraOrbit : MonoBehaviour
	{
		// Token: 0x060032A6 RID: 12966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032A6")]
		[Address(RVA = "0x776BD0", Offset = "0x7755D0", VA = "0x180776BD0")]
		private void Start()
		{
		}

		// Token: 0x060032A7 RID: 12967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032A7")]
		[Address(RVA = "0x776CB0", Offset = "0x7756B0", VA = "0x180776CB0")]
		private void Update()
		{
		}

		// Token: 0x060032A8 RID: 12968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032A8")]
		[Address(RVA = "0x776440", Offset = "0x774E40", VA = "0x180776440")]
		private void LateUpdate()
		{
		}

		// Token: 0x060032A9 RID: 12969 RVA: 0x0000DF38 File Offset: 0x0000C138
		[Token(Token = "0x60032A9")]
		[Address(RVA = "0x572D40", Offset = "0x571740", VA = "0x180572D40")]
		public static float ClampAngle(float angle, float min, float max)
		{
			return 0f;
		}

		// Token: 0x060032AA RID: 12970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032AA")]
		[Address(RVA = "0x776E60", Offset = "0x775860", VA = "0x180776E60")]
		public CameraOrbit()
		{
		}

		// Token: 0x04002313 RID: 8979
		[Token(Token = "0x4002313")]
		[FieldOffset(Offset = "0x20")]
		[Header("Required")]
		public Transform target;

		// Token: 0x04002314 RID: 8980
		[Token(Token = "0x4002314")]
		[FieldOffset(Offset = "0x28")]
		public Transform cam;

		// Token: 0x04002315 RID: 8981
		[Token(Token = "0x4002315")]
		[FieldOffset(Offset = "0x30")]
		public GraphicRaycaster raycaster;

		// Token: 0x04002316 RID: 8982
		[Token(Token = "0x4002316")]
		[FieldOffset(Offset = "0x38")]
		public AvatarLookController LookAt;

		// Token: 0x04002317 RID: 8983
		[Token(Token = "0x4002317")]
		[FieldOffset(Offset = "0x40")]
		[Header("Config")]
		public float targetdistance;

		// Token: 0x04002318 RID: 8984
		[Token(Token = "0x4002318")]
		[FieldOffset(Offset = "0x44")]
		public float xSpeed;

		// Token: 0x04002319 RID: 8985
		[Token(Token = "0x4002319")]
		[FieldOffset(Offset = "0x48")]
		public float ySpeed;

		// Token: 0x0400231A RID: 8986
		[Token(Token = "0x400231A")]
		[FieldOffset(Offset = "0x4C")]
		public float sideOffset;

		// Token: 0x0400231B RID: 8987
		[Token(Token = "0x400231B")]
		[FieldOffset(Offset = "0x50")]
		public float yMinLimit;

		// Token: 0x0400231C RID: 8988
		[Token(Token = "0x400231C")]
		[FieldOffset(Offset = "0x54")]
		public float yMaxLimit;

		// Token: 0x0400231D RID: 8989
		[Token(Token = "0x400231D")]
		[FieldOffset(Offset = "0x58")]
		public float distanceMin;

		// Token: 0x0400231E RID: 8990
		[Token(Token = "0x400231E")]
		[FieldOffset(Offset = "0x5C")]
		public float distanceMax;

		// Token: 0x0400231F RID: 8991
		[Token(Token = "0x400231F")]
		[FieldOffset(Offset = "0x60")]
		public float ScrollSensativity;

		// Token: 0x04002320 RID: 8992
		[Token(Token = "0x4002320")]
		[FieldOffset(Offset = "0x68")]
		private Rigidbody rb;

		// Token: 0x04002321 RID: 8993
		[Token(Token = "0x4002321")]
		[FieldOffset(Offset = "0x70")]
		private float x;

		// Token: 0x04002322 RID: 8994
		[Token(Token = "0x4002322")]
		[FieldOffset(Offset = "0x74")]
		private float y;

		// Token: 0x04002323 RID: 8995
		[Token(Token = "0x4002323")]
		[FieldOffset(Offset = "0x78")]
		private float targetx;

		// Token: 0x04002324 RID: 8996
		[Token(Token = "0x4002324")]
		[FieldOffset(Offset = "0x7C")]
		private float targety;

		// Token: 0x04002325 RID: 8997
		[Token(Token = "0x4002325")]
		[FieldOffset(Offset = "0x80")]
		private float distance;

		// Token: 0x04002326 RID: 8998
		[Token(Token = "0x4002326")]
		[FieldOffset(Offset = "0x84")]
		private bool hoveringUI;
	}
}
