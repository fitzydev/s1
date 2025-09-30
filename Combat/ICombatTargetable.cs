using System;
using FishNet.Object;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Vision;
using UnityEngine;

namespace ScheduleOne.Combat
{
	// Token: 0x020007AB RID: 1963
	[Token(Token = "0x20007AB")]
	public interface ICombatTargetable : IDamageable, ISightable
	{
		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x060034E9 RID: 13545
		[Token(Token = "0x170007A8")]
		NetworkObject NetworkObject
		{
			[Token(Token = "0x60034E9")]
			get;
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x060034EA RID: 13546 RVA: 0x0000E6B8 File Offset: 0x0000C8B8
		[Token(Token = "0x170007A9")]
		Vector3 CenterPoint
		{
			[Token(Token = "0x60034EA")]
			[Address(RVA = "0x7A3600", Offset = "0x7A2000", VA = "0x1807A3600", Slot = "1")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x060034EB RID: 13547
		[Token(Token = "0x170007AA")]
		Transform CenterPointTransform
		{
			[Token(Token = "0x60034EB")]
			get;
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x060034EC RID: 13548
		[Token(Token = "0x170007AB")]
		Vector3 LookAtPoint
		{
			[Token(Token = "0x60034EC")]
			get;
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x060034ED RID: 13549
		[Token(Token = "0x170007AC")]
		bool IsCurrentlyTargetable
		{
			[Token(Token = "0x60034ED")]
			get;
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x060034EE RID: 13550
		[Token(Token = "0x170007AD")]
		float RangedHitChanceMultiplier
		{
			[Token(Token = "0x60034EE")]
			get;
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x060034EF RID: 13551
		[Token(Token = "0x170007AE")]
		Vector3 Velocity
		{
			[Token(Token = "0x60034EF")]
			get;
		}

		// Token: 0x060034F0 RID: 13552
		[Token(Token = "0x60034F0")]
		void RecordLastKnownPosition(bool resetTimeSinceLastSeen);

		// Token: 0x060034F1 RID: 13553
		[Token(Token = "0x60034F1")]
		float GetSearchTime();

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x060034F2 RID: 13554 RVA: 0x0000E6D0 File Offset: 0x0000C8D0
		[Token(Token = "0x170007AF")]
		bool IsPlayer
		{
			[Token(Token = "0x60034F2")]
			[Address(RVA = "0x7A36E0", Offset = "0x7A20E0", VA = "0x1807A36E0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x060034F3 RID: 13555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007B0")]
		Player AsPlayer
		{
			[Token(Token = "0x60034F3")]
			[Address(RVA = "0x7A3590", Offset = "0x7A1F90", VA = "0x1807A3590", Slot = "10")]
			get
			{
				return null;
			}
		}
	}
}
