using System;
using Il2CppDummyDll;
using ScheduleOne.Cartel;
using ScheduleOne.Combat;
using ScheduleOne.Noise;
using ScheduleOne.NPCs.Responses;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.Police
{
	// Token: 0x020007F1 RID: 2033
	[Token(Token = "0x20007F1")]
	public class NPCResponses_CartelGoon : NPCResponses
	{
		// Token: 0x0600376E RID: 14190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600376E")]
		[Address(RVA = "0x7E4960", Offset = "0x7E3360", VA = "0x1807E4960", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x0600376F RID: 14191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600376F")]
		[Address(RVA = "0x7E4970", Offset = "0x7E3370", VA = "0x1807E4970", Slot = "7")]
		public override void ExplosionHeard(NoiseEvent explosionSound)
		{
		}

		// Token: 0x06003770 RID: 14192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003770")]
		[Address(RVA = "0x7E4970", Offset = "0x7E3370", VA = "0x1807E4970", Slot = "6")]
		public override void GunshotHeard(NoiseEvent gunshotSound)
		{
		}

		// Token: 0x06003771 RID: 14193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003771")]
		[Address(RVA = "0x7E4BB0", Offset = "0x7E35B0", VA = "0x1807E4BB0", Slot = "12")]
		public override void NoticePlayerDischargingWeapon(Player player)
		{
		}

		// Token: 0x06003772 RID: 14194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003772")]
		[Address(RVA = "0x7E4C40", Offset = "0x7E3640", VA = "0x1807E4C40", Slot = "13")]
		public override void PlayerFailedPickpocket(Player player)
		{
		}

		// Token: 0x06003773 RID: 14195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003773")]
		[Address(RVA = "0x7E4A10", Offset = "0x7E3410", VA = "0x1807E4A10", Slot = "18")]
		public override void HitByCar(LandVehicle vehicle)
		{
		}

		// Token: 0x06003774 RID: 14196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003774")]
		[Address(RVA = "0x7E4A50", Offset = "0x7E3450", VA = "0x1807E4A50", Slot = "19")]
		public override void ImpactReceived(Impact impact)
		{
		}

		// Token: 0x06003775 RID: 14197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003775")]
		[Address(RVA = "0x7E4C80", Offset = "0x7E3680", VA = "0x1807E4C80", Slot = "24")]
		public override void RespondToAimedAt(Player player)
		{
		}

		// Token: 0x06003776 RID: 14198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003776")]
		[Address(RVA = "0x7E4CC0", Offset = "0x7E36C0", VA = "0x1807E4CC0", Slot = "23")]
		protected override void RespondToAnnoyingImpact(Player perpetrator, Impact impact)
		{
		}

		// Token: 0x06003777 RID: 14199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003777")]
		[Address(RVA = "0x6CDDE0", Offset = "0x6CC7E0", VA = "0x1806CDDE0")]
		public NPCResponses_CartelGoon()
		{
		}

		// Token: 0x040026B0 RID: 9904
		[Token(Token = "0x40026B0")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public CartelGoon Goon;
	}
}
