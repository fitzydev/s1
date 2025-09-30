using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x0200075C RID: 1884
	[Token(Token = "0x200075C")]
	[RequireComponent(typeof(Light))]
	[ExecuteInEditMode]
	public class OptimizedLight : MonoBehaviour
	{
		// Token: 0x0600331A RID: 13082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600331A")]
		[Address(RVA = "0x7847B0", Offset = "0x7831B0", VA = "0x1807847B0", Slot = "4")]
		public virtual void Awake()
		{
		}

		// Token: 0x0600331B RID: 13083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600331B")]
		[Address(RVA = "0x784950", Offset = "0x783350", VA = "0x180784950")]
		private void Start()
		{
		}

		// Token: 0x0600331C RID: 13084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600331C")]
		[Address(RVA = "0x784850", Offset = "0x783250", VA = "0x180784850")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600331D RID: 13085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600331D")]
		[Address(RVA = "0x784F10", Offset = "0x783910", VA = "0x180784F10", Slot = "5")]
		public virtual void Update()
		{
		}

		// Token: 0x0600331E RID: 13086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600331E")]
		[Address(RVA = "0x784D90", Offset = "0x783790", VA = "0x180784D90")]
		private void UpdateCull()
		{
		}

		// Token: 0x0600331F RID: 13087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600331F")]
		[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
		public void SetEnabled(bool enabled)
		{
		}

		// Token: 0x06003320 RID: 13088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003320")]
		[Address(RVA = "0x784F60", Offset = "0x783960", VA = "0x180784F60")]
		public OptimizedLight()
		{
		}

		// Token: 0x06003321 RID: 13089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003321")]
		[Address(RVA = "0x784AC0", Offset = "0x7834C0", VA = "0x180784AC0")]
		[CompilerGenerated]
		private void <Start>g__Register|8_0()
		{
		}

		// Token: 0x0400236C RID: 9068
		[Token(Token = "0x400236C")]
		[FieldOffset(Offset = "0x20")]
		public bool Enabled;

		// Token: 0x0400236D RID: 9069
		[Token(Token = "0x400236D")]
		[FieldOffset(Offset = "0x21")]
		[HideInInspector]
		public bool DisabledForOptimization;

		// Token: 0x0400236E RID: 9070
		[Token(Token = "0x400236E")]
		[FieldOffset(Offset = "0x24")]
		[Range(10f, 500f)]
		public float MaxDistance;

		// Token: 0x0400236F RID: 9071
		[Token(Token = "0x400236F")]
		[FieldOffset(Offset = "0x28")]
		public Light _Light;

		// Token: 0x04002370 RID: 9072
		[Token(Token = "0x4002370")]
		[FieldOffset(Offset = "0x30")]
		private bool _LightExists;

		// Token: 0x04002371 RID: 9073
		[Token(Token = "0x4002371")]
		[FieldOffset(Offset = "0x31")]
		private bool culled;

		// Token: 0x04002372 RID: 9074
		[Token(Token = "0x4002372")]
		[FieldOffset(Offset = "0x34")]
		private float maxDistanceSquared;
	}
}
