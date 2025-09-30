using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000334 RID: 820
	[Token(Token = "0x2000334")]
	[CreateAssetMenu(fileName = "Spicy", menuName = "Properties/Spicy Property")]
	public class Spicy : Property
	{
		// Token: 0x06001227 RID: 4647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001227")]
		[Address(RVA = "0x5A2C80", Offset = "0x5A1680", VA = "0x1805A2C80", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001228")]
		[Address(RVA = "0x5A2CC0", Offset = "0x5A16C0", VA = "0x1805A2CC0", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001229")]
		[Address(RVA = "0x5A2E00", Offset = "0x5A1800", VA = "0x1805A2E00", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600122A")]
		[Address(RVA = "0x5A2E40", Offset = "0x5A1840", VA = "0x1805A2E40", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600122B")]
		[Address(RVA = "0x58E520", Offset = "0x58CF20", VA = "0x18058E520")]
		public Spicy()
		{
		}

		// Token: 0x0400115A RID: 4442
		[Token(Token = "0x400115A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[ColorUsage(true, true)]
		public Color TintColor;
	}
}
