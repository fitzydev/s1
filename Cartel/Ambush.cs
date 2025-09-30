using System;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.Economy;
using ScheduleOne.Levelling;
using ScheduleOne.Map;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Cartel
{
	// Token: 0x020007FA RID: 2042
	[Token(Token = "0x20007FA")]
	public class Ambush : CartelActivity
	{
		// Token: 0x060037FD RID: 14333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037FD")]
		[Address(RVA = "0x7D8A50", Offset = "0x7D7450", VA = "0x1807D8A50", Slot = "4")]
		public override void Activate(EMapRegion region)
		{
		}

		// Token: 0x060037FE RID: 14334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037FE")]
		[Address(RVA = "0x7D9260", Offset = "0x7D7C60", VA = "0x1807D9260", Slot = "7")]
		protected override void Deactivate()
		{
		}

		// Token: 0x060037FF RID: 14335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037FF")]
		[Address(RVA = "0x7D93D0", Offset = "0x7D7DD0", VA = "0x1807D93D0", Slot = "5")]
		protected override void MinPassed()
		{
		}

		// Token: 0x06003800 RID: 14336 RVA: 0x0000F1E0 File Offset: 0x0000D3E0
		[Token(Token = "0x6003800")]
		[Address(RVA = "0x7D8C60", Offset = "0x7D7660", VA = "0x1807D8C60")]
		private bool CanPlayerBeAmbushed(Player player)
		{
			return default(bool);
		}

		// Token: 0x06003801 RID: 14337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003801")]
		[Address(RVA = "0x7D8D00", Offset = "0x7D7700", VA = "0x1807D8D00")]
		private void ContractReceiptRecorded(ContractReceipt receipt)
		{
		}

		// Token: 0x06003802 RID: 14338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003802")]
		[Address(RVA = "0x7D9A40", Offset = "0x7D8440", VA = "0x1807D9A40")]
		private void SpawnAmbush(Player target, Vector3[] potentialSpawnPoints)
		{
		}

		// Token: 0x06003803 RID: 14339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003803")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public Ambush()
		{
		}

		// Token: 0x04002705 RID: 9989
		[Token(Token = "0x4002705")]
		public const float MIN_DISTANCE_TO_POLICE_OFFICER = 15f;

		// Token: 0x04002706 RID: 9990
		[Token(Token = "0x4002706")]
		public const int CANCEL_AMBUSH_AFTER_MINS = 360;

		// Token: 0x04002707 RID: 9991
		[Token(Token = "0x4002707")]
		public const float AMBUSH_DEFEATED_INFLUENCE_CHANGE = -0.075f;

		// Token: 0x04002708 RID: 9992
		[Token(Token = "0x4002708")]
		[FieldOffset(Offset = "0x0")]
		public static FullRank MIN_RANK_FOR_RANGED_WEAPONS;

		// Token: 0x04002709 RID: 9993
		[Token(Token = "0x4002709")]
		[FieldOffset(Offset = "0x40")]
		private CartelRegionActivities _regionActivities;

		// Token: 0x0400270A RID: 9994
		[Token(Token = "0x400270A")]
		[FieldOffset(Offset = "0x48")]
		[Header("Settings")]
		public AvatarWeapon[] RangedWeapons;

		// Token: 0x0400270B RID: 9995
		[Token(Token = "0x400270B")]
		[FieldOffset(Offset = "0x50")]
		public AvatarWeapon[] MeleeWeapons;
	}
}
