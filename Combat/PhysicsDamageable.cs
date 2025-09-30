using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Combat
{
	// Token: 0x020007AF RID: 1967
	[Token(Token = "0x20007AF")]
	public class PhysicsDamageable : MonoBehaviour, IDamageable
	{
		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x060034FB RID: 13563 RVA: 0x0000E718 File Offset: 0x0000C918
		// (set) Token: 0x060034FC RID: 13564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007B2")]
		public Vector3 averageVelocity
		{
			[Token(Token = "0x60034FB")]
			[Address(RVA = "0x7A5B20", Offset = "0x7A4520", VA = "0x1807A5B20")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60034FC")]
			[Address(RVA = "0x7A5B40", Offset = "0x7A4540", VA = "0x1807A5B40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060034FD RID: 13565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034FD")]
		[Address(RVA = "0x7A57B0", Offset = "0x7A41B0", VA = "0x1807A57B0")]
		public void OnValidate()
		{
		}

		// Token: 0x060034FE RID: 13566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034FE")]
		[Address(RVA = "0x7A5A00", Offset = "0x7A4400", VA = "0x1807A5A00", Slot = "7")]
		public virtual void SendImpact(Impact impact)
		{
		}

		// Token: 0x060034FF RID: 13567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034FF")]
		[Address(RVA = "0x7A5840", Offset = "0x7A4240", VA = "0x1807A5840", Slot = "8")]
		public virtual void ReceiveImpact(Impact impact)
		{
		}

		// Token: 0x06003500 RID: 13568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003500")]
		[Address(RVA = "0x7A5A20", Offset = "0x7A4420", VA = "0x1807A5A20")]
		public PhysicsDamageable()
		{
		}

		// Token: 0x06003501 RID: 13569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003501")]
		[Address(RVA = "0x62C680", Offset = "0x62B080", VA = "0x18062C680", Slot = "4")]
		private GameObject ScheduleOne.Combat.IDamageable.get_gameObject()
		{
			return null;
		}

		// Token: 0x040024D8 RID: 9432
		[Token(Token = "0x40024D8")]
		public const int VELOCITY_HISTORY_LENGTH = 4;

		// Token: 0x040024D9 RID: 9433
		[Token(Token = "0x40024D9")]
		[FieldOffset(Offset = "0x20")]
		public Rigidbody Rb;

		// Token: 0x040024DA RID: 9434
		[Token(Token = "0x40024DA")]
		[FieldOffset(Offset = "0x28")]
		public float ForceMultiplier;

		// Token: 0x040024DB RID: 9435
		[Token(Token = "0x40024DB")]
		[FieldOffset(Offset = "0x30")]
		private List<int> impactHistory;

		// Token: 0x040024DC RID: 9436
		[Token(Token = "0x40024DC")]
		[FieldOffset(Offset = "0x38")]
		public Action<Impact> onImpacted;

		// Token: 0x040024DE RID: 9438
		[Token(Token = "0x40024DE")]
		[FieldOffset(Offset = "0x50")]
		private List<Vector3> velocityHistory;
	}
}
