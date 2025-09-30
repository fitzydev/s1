using System;
using EasyButtons;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x0200090E RID: 2318
	[Token(Token = "0x200090E")]
	public class OptimizedColliderGroup : MonoBehaviour
	{
		// Token: 0x06003FC8 RID: 16328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FC8")]
		[Address(RVA = "0x867F60", Offset = "0x866960", VA = "0x180867F60")]
		private void OnEnable()
		{
		}

		// Token: 0x06003FC9 RID: 16329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FC9")]
		[Address(RVA = "0x867E60", Offset = "0x866860", VA = "0x180867E60")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003FCA RID: 16330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FCA")]
		[Address(RVA = "0x868350", Offset = "0x866D50", VA = "0x180868350")]
		private void RegisterEvent()
		{
		}

		// Token: 0x06003FCB RID: 16331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FCB")]
		[Address(RVA = "0x867E10", Offset = "0x866810", VA = "0x180867E10")]
		[Button]
		public void GetColliders()
		{
		}

		// Token: 0x06003FCC RID: 16332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FCC")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80")]
		public void Start()
		{
		}

		// Token: 0x06003FCD RID: 16333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FCD")]
		[Address(RVA = "0x8680D0", Offset = "0x866AD0", VA = "0x1808680D0")]
		private void Refresh()
		{
		}

		// Token: 0x06003FCE RID: 16334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FCE")]
		[Address(RVA = "0x868530", Offset = "0x866F30", VA = "0x180868530")]
		private void SetCollidersEnabled(bool enabled)
		{
		}

		// Token: 0x06003FCF RID: 16335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FCF")]
		[Address(RVA = "0x868610", Offset = "0x867010", VA = "0x180868610")]
		public OptimizedColliderGroup()
		{
		}

		// Token: 0x04002CB1 RID: 11441
		[Token(Token = "0x4002CB1")]
		public const int UPDATE_DISTANCE = 5;

		// Token: 0x04002CB2 RID: 11442
		[Token(Token = "0x4002CB2")]
		[FieldOffset(Offset = "0x20")]
		public Collider[] Colliders;

		// Token: 0x04002CB3 RID: 11443
		[Token(Token = "0x4002CB3")]
		[FieldOffset(Offset = "0x28")]
		public float ColliderEnableMaxDistance;

		// Token: 0x04002CB4 RID: 11444
		[Token(Token = "0x4002CB4")]
		[FieldOffset(Offset = "0x2C")]
		private float sqrColliderEnableMaxDistance;

		// Token: 0x04002CB5 RID: 11445
		[Token(Token = "0x4002CB5")]
		[FieldOffset(Offset = "0x30")]
		private bool collidersEnabled;
	}
}
