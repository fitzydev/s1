using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x0200090F RID: 2319
	[Token(Token = "0x200090F")]
	public class ParticleCollisionDetector : MonoBehaviour
	{
		// Token: 0x06003FD0 RID: 16336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FD0")]
		[Address(RVA = "0x8702F0", Offset = "0x86ECF0", VA = "0x1808702F0")]
		private void Awake()
		{
		}

		// Token: 0x06003FD1 RID: 16337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FD1")]
		[Address(RVA = "0x870340", Offset = "0x86ED40", VA = "0x180870340")]
		public void OnParticleCollision(GameObject other)
		{
		}

		// Token: 0x06003FD2 RID: 16338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FD2")]
		[Address(RVA = "0x8703A0", Offset = "0x86EDA0", VA = "0x1808703A0")]
		private void OnParticleTrigger()
		{
		}

		// Token: 0x06003FD3 RID: 16339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FD3")]
		[Address(RVA = "0x870460", Offset = "0x86EE60", VA = "0x180870460")]
		public ParticleCollisionDetector()
		{
		}

		// Token: 0x04002CB6 RID: 11446
		[Token(Token = "0x4002CB6")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent<GameObject> onCollision;

		// Token: 0x04002CB7 RID: 11447
		[Token(Token = "0x4002CB7")]
		[FieldOffset(Offset = "0x28")]
		private ParticleSystem ps;
	}
}
