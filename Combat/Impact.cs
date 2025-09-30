using System;
using FishNet.Object;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Combat
{
	// Token: 0x020007AE RID: 1966
	[Token(Token = "0x20007AE")]
	[Serializable]
	public class Impact
	{
		// Token: 0x060034F7 RID: 13559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034F7")]
		[Address(RVA = "0x7A3870", Offset = "0x7A2270", VA = "0x1807A3870")]
		public Impact(Vector3 hitPoint, Vector3 impactForceDirection, float impactForce, float impactDamage, EImpactType impactType, NetworkObject impactSource, int impactID = 0)
		{
		}

		// Token: 0x060034F8 RID: 13560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034F8")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public Impact()
		{
		}

		// Token: 0x060034F9 RID: 13561 RVA: 0x0000E6E8 File Offset: 0x0000C8E8
		[Token(Token = "0x60034F9")]
		[Address(RVA = "0x7A3760", Offset = "0x7A2160", VA = "0x1807A3760")]
		public static bool IsLethal(EImpactType impactType)
		{
			return default(bool);
		}

		// Token: 0x060034FA RID: 13562 RVA: 0x0000E700 File Offset: 0x0000C900
		[Token(Token = "0x60034FA")]
		[Address(RVA = "0x7A3780", Offset = "0x7A2180", VA = "0x1807A3780")]
		public bool IsPlayerImpact(out Player player)
		{
			return default(bool);
		}

		// Token: 0x040024D1 RID: 9425
		[Token(Token = "0x40024D1")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 HitPoint;

		// Token: 0x040024D2 RID: 9426
		[Token(Token = "0x40024D2")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 ImpactForceDirection;

		// Token: 0x040024D3 RID: 9427
		[Token(Token = "0x40024D3")]
		[FieldOffset(Offset = "0x28")]
		public float ImpactForce;

		// Token: 0x040024D4 RID: 9428
		[Token(Token = "0x40024D4")]
		[FieldOffset(Offset = "0x2C")]
		public float ImpactDamage;

		// Token: 0x040024D5 RID: 9429
		[Token(Token = "0x40024D5")]
		[FieldOffset(Offset = "0x30")]
		public EImpactType ImpactType;

		// Token: 0x040024D6 RID: 9430
		[Token(Token = "0x40024D6")]
		[FieldOffset(Offset = "0x38")]
		public NetworkObject ImpactSource;

		// Token: 0x040024D7 RID: 9431
		[Token(Token = "0x40024D7")]
		[FieldOffset(Offset = "0x40")]
		public int ImpactID;
	}
}
