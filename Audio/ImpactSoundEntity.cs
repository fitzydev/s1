using System;
using Il2CppDummyDll;
using ScheduleOne.Combat;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x0200084E RID: 2126
	[Token(Token = "0x200084E")]
	[RequireComponent(typeof(Rigidbody))]
	public class ImpactSoundEntity : MonoBehaviour
	{
		// Token: 0x06003A34 RID: 14900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A34")]
		[Address(RVA = "0x80FBF0", Offset = "0x80E5F0", VA = "0x18080FBF0")]
		public void Awake()
		{
		}

		// Token: 0x06003A35 RID: 14901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A35")]
		[Address(RVA = "0x810020", Offset = "0x80EA20", VA = "0x180810020")]
		private void OnImpacted(Impact impact)
		{
		}

		// Token: 0x06003A36 RID: 14902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A36")]
		[Address(RVA = "0x80FD70", Offset = "0x80E770", VA = "0x18080FD70")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x06003A37 RID: 14903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A37")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public ImpactSoundEntity()
		{
		}

		// Token: 0x0400288D RID: 10381
		[Token(Token = "0x400288D")]
		public const float MIN_IMPACT_MOMENTUM = 4f;

		// Token: 0x0400288E RID: 10382
		[Token(Token = "0x400288E")]
		public const float COOLDOWN = 0.25f;

		// Token: 0x0400288F RID: 10383
		[Token(Token = "0x400288F")]
		[FieldOffset(Offset = "0x20")]
		public ImpactSoundEntity.EMaterial Material;

		// Token: 0x04002890 RID: 10384
		[Token(Token = "0x4002890")]
		[FieldOffset(Offset = "0x24")]
		private float lastImpactTime;

		// Token: 0x04002891 RID: 10385
		[Token(Token = "0x4002891")]
		[FieldOffset(Offset = "0x28")]
		private Rigidbody rb;

		// Token: 0x0200084F RID: 2127
		[Token(Token = "0x200084F")]
		public enum EMaterial
		{
			// Token: 0x04002893 RID: 10387
			[Token(Token = "0x4002893")]
			Wood,
			// Token: 0x04002894 RID: 10388
			[Token(Token = "0x4002894")]
			HollowMetal,
			// Token: 0x04002895 RID: 10389
			[Token(Token = "0x4002895")]
			Cardboard,
			// Token: 0x04002896 RID: 10390
			[Token(Token = "0x4002896")]
			Glass,
			// Token: 0x04002897 RID: 10391
			[Token(Token = "0x4002897")]
			Plastic,
			// Token: 0x04002898 RID: 10392
			[Token(Token = "0x4002898")]
			Basketball,
			// Token: 0x04002899 RID: 10393
			[Token(Token = "0x4002899")]
			SmallHollowMetal,
			// Token: 0x0400289A RID: 10394
			[Token(Token = "0x400289A")]
			PlasticBag,
			// Token: 0x0400289B RID: 10395
			[Token(Token = "0x400289B")]
			Punch,
			// Token: 0x0400289C RID: 10396
			[Token(Token = "0x400289C")]
			BaseballBat
		}
	}
}
