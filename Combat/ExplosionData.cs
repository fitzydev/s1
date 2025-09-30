using System;
using Il2CppDummyDll;

namespace ScheduleOne.Combat
{
	// Token: 0x020007AA RID: 1962
	[Token(Token = "0x20007AA")]
	public struct ExplosionData
	{
		// Token: 0x060034E7 RID: 13543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034E7")]
		[Address(RVA = "0x7A2140", Offset = "0x7A0B40", VA = "0x1807A2140")]
		public ExplosionData(float damageRadius, float maxDamage, float maxPushForce, bool checkLoS)
		{
		}

		// Token: 0x040024C4 RID: 9412
		[Token(Token = "0x40024C4")]
		[FieldOffset(Offset = "0x0")]
		public float DamageRadius;

		// Token: 0x040024C5 RID: 9413
		[Token(Token = "0x40024C5")]
		[FieldOffset(Offset = "0x4")]
		public float MaxDamage;

		// Token: 0x040024C6 RID: 9414
		[Token(Token = "0x40024C6")]
		[FieldOffset(Offset = "0x8")]
		public float PushForceRadius;

		// Token: 0x040024C7 RID: 9415
		[Token(Token = "0x40024C7")]
		[FieldOffset(Offset = "0xC")]
		public float MaxPushForce;

		// Token: 0x040024C8 RID: 9416
		[Token(Token = "0x40024C8")]
		[FieldOffset(Offset = "0x10")]
		public bool CheckLoS;

		// Token: 0x040024C9 RID: 9417
		[Token(Token = "0x40024C9")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ExplosionData DefaultSmall;
	}
}
