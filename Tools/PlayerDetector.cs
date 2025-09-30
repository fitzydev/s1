using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x02000914 RID: 2324
	[Token(Token = "0x2000914")]
	[RequireComponent(typeof(Rigidbody))]
	public class PlayerDetector : MonoBehaviour
	{
		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06003FE6 RID: 16358 RVA: 0x00010FF8 File Offset: 0x0000F1F8
		// (set) Token: 0x06003FE7 RID: 16359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008F7")]
		public bool IgnoreNewDetections
		{
			[Token(Token = "0x6003FE6")]
			[Address(RVA = "0x4A4A60", Offset = "0x4A3460", VA = "0x1804A4A60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003FE7")]
			[Address(RVA = "0x4A4A90", Offset = "0x4A3490", VA = "0x1804A4A90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003FE8 RID: 16360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FE8")]
		[Address(RVA = "0x8726D0", Offset = "0x8710D0", VA = "0x1808726D0")]
		private void Awake()
		{
		}

		// Token: 0x06003FE9 RID: 16361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FE9")]
		[Address(RVA = "0x873410", Offset = "0x871E10", VA = "0x180873410")]
		private void Start()
		{
		}

		// Token: 0x06003FEA RID: 16362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FEA")]
		[Address(RVA = "0x872AE0", Offset = "0x8714E0", VA = "0x180872AE0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003FEB RID: 16363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FEB")]
		[Address(RVA = "0x8728D0", Offset = "0x8712D0", VA = "0x1808728D0")]
		private void MinPass()
		{
		}

		// Token: 0x06003FEC RID: 16364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FEC")]
		[Address(RVA = "0x872C50", Offset = "0x871650", VA = "0x180872C50")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06003FED RID: 16365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FED")]
		[Address(RVA = "0x8727C0", Offset = "0x8711C0", VA = "0x1808727C0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06003FEE RID: 16366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FEE")]
		[Address(RVA = "0x872FC0", Offset = "0x8719C0", VA = "0x180872FC0")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x06003FEF RID: 16367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FEF")]
		[Address(RVA = "0x873330", Offset = "0x871D30", VA = "0x180873330")]
		public void SetIgnoreNewCollisions(bool ignore)
		{
		}

		// Token: 0x06003FF0 RID: 16368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FF0")]
		[Address(RVA = "0x873560", Offset = "0x871F60", VA = "0x180873560")]
		public PlayerDetector()
		{
		}

		// Token: 0x04002CBF RID: 11455
		[Token(Token = "0x4002CBF")]
		public const float ACTIVATION_DISTANCE_SQ = 400f;

		// Token: 0x04002CC0 RID: 11456
		[Token(Token = "0x4002CC0")]
		[FieldOffset(Offset = "0x20")]
		public bool DetectPlayerInVehicle;

		// Token: 0x04002CC1 RID: 11457
		[Token(Token = "0x4002CC1")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent<Player> onPlayerEnter;

		// Token: 0x04002CC2 RID: 11458
		[Token(Token = "0x4002CC2")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent<Player> onPlayerExit;

		// Token: 0x04002CC3 RID: 11459
		[Token(Token = "0x4002CC3")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent onLocalPlayerEnter;

		// Token: 0x04002CC4 RID: 11460
		[Token(Token = "0x4002CC4")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent onLocalPlayerExit;

		// Token: 0x04002CC5 RID: 11461
		[Token(Token = "0x4002CC5")]
		[FieldOffset(Offset = "0x48")]
		public List<Player> DetectedPlayers;

		// Token: 0x04002CC7 RID: 11463
		[Token(Token = "0x4002CC7")]
		[FieldOffset(Offset = "0x51")]
		private bool ignoreExit;

		// Token: 0x04002CC8 RID: 11464
		[Token(Token = "0x4002CC8")]
		[FieldOffset(Offset = "0x52")]
		private bool collidersEnabled;

		// Token: 0x04002CC9 RID: 11465
		[Token(Token = "0x4002CC9")]
		[FieldOffset(Offset = "0x58")]
		private Collider[] detectionColliders;
	}
}
