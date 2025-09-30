using System;
using Il2CppDummyDll;
using ScheduleOne.Combat;
using ScheduleOne.Noise;
using ScheduleOne.NPCs.Responses;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Vehicles;

namespace ScheduleOne.Police
{
	// Token: 0x020007F3 RID: 2035
	[Token(Token = "0x20007F3")]
	public class NPCResponses_Police : NPCResponses
	{
		// Token: 0x0600377E RID: 14206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600377E")]
		[Address(RVA = "0x7E4E80", Offset = "0x7E3880", VA = "0x1807E4E80", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x0600377F RID: 14207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600377F")]
		[Address(RVA = "0x7E50C0", Offset = "0x7E3AC0", VA = "0x1807E50C0", Slot = "18")]
		public override void HitByCar(LandVehicle vehicle)
		{
		}

		// Token: 0x06003780 RID: 14208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003780")]
		[Address(RVA = "0x7E56B0", Offset = "0x7E40B0", VA = "0x1807E56B0", Slot = "14")]
		public override void NoticedDrugDeal(Player player)
		{
		}

		// Token: 0x06003781 RID: 14209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003781")]
		[Address(RVA = "0x7E5870", Offset = "0x7E4270", VA = "0x1807E5870", Slot = "8")]
		public override void NoticedPettyCrime(Player player)
		{
		}

		// Token: 0x06003782 RID: 14210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003782")]
		[Address(RVA = "0x7E5B10", Offset = "0x7E4510", VA = "0x1807E5B10", Slot = "9")]
		public override void NoticedVandalism(Player player)
		{
		}

		// Token: 0x06003783 RID: 14211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003783")]
		[Address(RVA = "0x7E6B60", Offset = "0x7E5560", VA = "0x1807E6B60", Slot = "10")]
		public override void SawPickpocketing(Player player)
		{
		}

		// Token: 0x06003784 RID: 14212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003784")]
		[Address(RVA = "0x7E62E0", Offset = "0x7E4CE0", VA = "0x1807E62E0", Slot = "13")]
		public override void PlayerFailedPickpocket(Player player)
		{
		}

		// Token: 0x06003785 RID: 14213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003785")]
		[Address(RVA = "0x7E5330", Offset = "0x7E3D30", VA = "0x1807E5330", Slot = "11")]
		public override void NoticePlayerBrandishingWeapon(Player player)
		{
		}

		// Token: 0x06003786 RID: 14214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003786")]
		[Address(RVA = "0x7E54F0", Offset = "0x7E3EF0", VA = "0x1807E54F0", Slot = "12")]
		public override void NoticePlayerDischargingWeapon(Player player)
		{
		}

		// Token: 0x06003787 RID: 14215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003787")]
		[Address(RVA = "0x7E6000", Offset = "0x7E4A00", VA = "0x1807E6000", Slot = "16")]
		public override void NoticedWantedPlayer(Player player)
		{
		}

		// Token: 0x06003788 RID: 14216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003788")]
		[Address(RVA = "0x7E59E0", Offset = "0x7E43E0", VA = "0x1807E59E0", Slot = "17")]
		public override void NoticedSuspiciousPlayer(Player player)
		{
		}

		// Token: 0x06003789 RID: 14217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003789")]
		[Address(RVA = "0x7E5CD0", Offset = "0x7E46D0", VA = "0x1807E5CD0", Slot = "15")]
		public override void NoticedViolatingCurfew(Player player)
		{
		}

		// Token: 0x0600378A RID: 14218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600378A")]
		[Address(RVA = "0x7E6730", Offset = "0x7E5130", VA = "0x1807E6730", Slot = "20")]
		protected override void RespondToFirstNonLethalAttack(Player perpetrator, Impact impact)
		{
		}

		// Token: 0x0600378B RID: 14219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600378B")]
		[Address(RVA = "0x7E6890", Offset = "0x7E5290", VA = "0x1807E6890", Slot = "22")]
		protected override void RespondToLethalAttack(Player perpetrator, Impact impact)
		{
		}

		// Token: 0x0600378C RID: 14220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600378C")]
		[Address(RVA = "0x7E69E0", Offset = "0x7E53E0", VA = "0x1807E69E0", Slot = "21")]
		protected override void RespondToRepeatedNonLethalAttack(Player perpetrator, Impact impact)
		{
		}

		// Token: 0x0600378D RID: 14221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600378D")]
		[Address(RVA = "0x7E6570", Offset = "0x7E4F70", VA = "0x1807E6570", Slot = "23")]
		protected override void RespondToAnnoyingImpact(Player perpetrator, Impact impact)
		{
		}

		// Token: 0x0600378E RID: 14222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600378E")]
		[Address(RVA = "0x7E64A0", Offset = "0x7E4EA0", VA = "0x1807E64A0", Slot = "24")]
		public override void RespondToAimedAt(Player player)
		{
		}

		// Token: 0x0600378F RID: 14223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600378F")]
		[Address(RVA = "0x7E52D0", Offset = "0x7E3CD0", VA = "0x1807E52D0", Slot = "19")]
		public override void ImpactReceived(Impact impact)
		{
		}

		// Token: 0x06003790 RID: 14224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003790")]
		[Address(RVA = "0x7E4F60", Offset = "0x7E3960", VA = "0x1807E4F60", Slot = "6")]
		public override void GunshotHeard(NoiseEvent gunshotSound)
		{
		}

		// Token: 0x06003791 RID: 14225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003791")]
		[Address(RVA = "0x6CDDE0", Offset = "0x6CC7E0", VA = "0x1806CDDE0")]
		public NPCResponses_Police()
		{
		}

		// Token: 0x040026B3 RID: 9907
		[Token(Token = "0x40026B3")]
		[FieldOffset(Offset = "0x30")]
		private PoliceOfficer officer;
	}
}
