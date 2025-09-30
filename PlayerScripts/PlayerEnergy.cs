using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x02000563 RID: 1379
	[Token(Token = "0x2000563")]
	public class PlayerEnergy : MonoBehaviour
	{
		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06001E72 RID: 7794 RVA: 0x0000A068 File Offset: 0x00008268
		// (set) Token: 0x06001E73 RID: 7795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700053F")]
		public float CurrentEnergy
		{
			[Token(Token = "0x6001E72")]
			[Address(RVA = "0x486190", Offset = "0x484B90", VA = "0x180486190")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001E73")]
			[Address(RVA = "0x4A4AF0", Offset = "0x4A34F0", VA = "0x1804A4AF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06001E74 RID: 7796 RVA: 0x0000A080 File Offset: 0x00008280
		// (set) Token: 0x06001E75 RID: 7797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000540")]
		public int EnergyDrinksConsumed
		{
			[Token(Token = "0x6001E74")]
			[Address(RVA = "0x47D5D0", Offset = "0x47BFD0", VA = "0x18047D5D0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001E75")]
			[Address(RVA = "0x47D7A0", Offset = "0x47C1A0", VA = "0x18047D7A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E76")]
		[Address(RVA = "0x659DE0", Offset = "0x6587E0", VA = "0x180659DE0", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E77")]
		[Address(RVA = "0x659CC0", Offset = "0x6586C0", VA = "0x180659CC0")]
		private void MinPass()
		{
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E78")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80")]
		private void ChangeEnergy(float change)
		{
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E79")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80")]
		public void SetEnergy(float newEnergy)
		{
		}

		// Token: 0x06001E7A RID: 7802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E7A")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80")]
		public void RestoreEnergy()
		{
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E7B")]
		[Address(RVA = "0x659DD0", Offset = "0x6587D0", VA = "0x180659DD0")]
		private void SleepEnd()
		{
		}

		// Token: 0x06001E7C RID: 7804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E7C")]
		[Address(RVA = "0x659CB0", Offset = "0x6586B0", VA = "0x180659CB0")]
		public void IncrementEnergyDrinks()
		{
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E7D")]
		[Address(RVA = "0x659DD0", Offset = "0x6587D0", VA = "0x180659DD0")]
		private void ResetEnergyDrinks()
		{
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E7E")]
		[Address(RVA = "0x65A000", Offset = "0x658A00", VA = "0x18065A000")]
		public PlayerEnergy()
		{
		}

		// Token: 0x040018D4 RID: 6356
		[Token(Token = "0x40018D4")]
		public const float CRITICAL_THRESHOLD = 20f;

		// Token: 0x040018D5 RID: 6357
		[Token(Token = "0x40018D5")]
		public const float MAX_ENERGY = 100f;

		// Token: 0x040018D6 RID: 6358
		[Token(Token = "0x40018D6")]
		public const float SPRINT_DRAIN_MULTIPLIER = 1.3f;

		// Token: 0x040018D9 RID: 6361
		[Token(Token = "0x40018D9")]
		[FieldOffset(Offset = "0x28")]
		public bool DEBUG_DISABLE_ENERGY;

		// Token: 0x040018DA RID: 6362
		[Token(Token = "0x40018DA")]
		[FieldOffset(Offset = "0x2C")]
		[Header("Settings")]
		public float EnergyDuration_Hours;

		// Token: 0x040018DB RID: 6363
		[Token(Token = "0x40018DB")]
		[FieldOffset(Offset = "0x30")]
		public float EnergyRechargeTime_Hours;

		// Token: 0x040018DC RID: 6364
		[Token(Token = "0x40018DC")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent onEnergyChanged;

		// Token: 0x040018DD RID: 6365
		[Token(Token = "0x40018DD")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent onEnergyDepleted;
	}
}
