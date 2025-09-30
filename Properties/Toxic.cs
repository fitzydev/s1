using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000336 RID: 822
	[Token(Token = "0x2000336")]
	[CreateAssetMenu(fileName = "Toxic", menuName = "Properties/Toxic Property")]
	public class Toxic : Property
	{
		// Token: 0x06001231 RID: 4657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001231")]
		[Address(RVA = "0x5A5F80", Offset = "0x5A4980", VA = "0x1805A5F80", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001232")]
		[Address(RVA = "0x5A6040", Offset = "0x5A4A40", VA = "0x1805A6040", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001233")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001234")]
		[Address(RVA = "0x5A61D0", Offset = "0x5A4BD0", VA = "0x1805A61D0", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001235")]
		[Address(RVA = "0x58E520", Offset = "0x58CF20", VA = "0x18058E520")]
		public Toxic()
		{
		}

		// Token: 0x0400115B RID: 4443
		[Token(Token = "0x400115B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[ColorUsage(true, true)]
		public Color TintColor;
	}
}
