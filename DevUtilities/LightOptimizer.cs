using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000755 RID: 1877
	[Token(Token = "0x2000755")]
	public class LightOptimizer : MonoBehaviour
	{
		// Token: 0x060032DB RID: 13019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032DB")]
		[Address(RVA = "0x779100", Offset = "0x777B00", VA = "0x180779100")]
		public void Awake()
		{
		}

		// Token: 0x060032DC RID: 13020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032DC")]
		[Address(RVA = "0x779150", Offset = "0x777B50", VA = "0x180779150")]
		public void FixedUpdate()
		{
		}

		// Token: 0x060032DD RID: 13021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032DD")]
		[Address(RVA = "0x7790B0", Offset = "0x777AB0", VA = "0x1807790B0")]
		public void ApplyLights()
		{
		}

		// Token: 0x060032DE RID: 13022 RVA: 0x0000DFF8 File Offset: 0x0000C1F8
		[Token(Token = "0x60032DE")]
		[Address(RVA = "0x7795D0", Offset = "0x777FD0", VA = "0x1807795D0")]
		public bool PointInCameraView(Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x060032DF RID: 13023 RVA: 0x0000E010 File Offset: 0x0000C210
		[Token(Token = "0x60032DF")]
		[Address(RVA = "0x643F50", Offset = "0x642950", VA = "0x180643F50")]
		public bool Is01(float a)
		{
			return default(bool);
		}

		// Token: 0x060032E0 RID: 13024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032E0")]
		[Address(RVA = "0x7795C0", Offset = "0x777FC0", VA = "0x1807795C0")]
		public void LightsEnabled_True()
		{
		}

		// Token: 0x060032E1 RID: 13025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032E1")]
		[Address(RVA = "0x7795B0", Offset = "0x777FB0", VA = "0x1807795B0")]
		public void LightsEnabled_False()
		{
		}

		// Token: 0x060032E2 RID: 13026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032E2")]
		[Address(RVA = "0x7799B0", Offset = "0x7783B0", VA = "0x1807799B0")]
		public LightOptimizer()
		{
		}

		// Token: 0x04002346 RID: 9030
		[Token(Token = "0x4002346")]
		[FieldOffset(Offset = "0x20")]
		public bool LightsEnabled;

		// Token: 0x04002347 RID: 9031
		[Token(Token = "0x4002347")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Header("References")]
		protected BoxCollider[] activationZones;

		// Token: 0x04002348 RID: 9032
		[Token(Token = "0x4002348")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Transform[] viewPoints;

		// Token: 0x04002349 RID: 9033
		[Token(Token = "0x4002349")]
		[FieldOffset(Offset = "0x38")]
		[Header("Settings")]
		public float checkRange;

		// Token: 0x0400234A RID: 9034
		[Token(Token = "0x400234A")]
		[FieldOffset(Offset = "0x40")]
		protected OptimizedLight[] lights;
	}
}
