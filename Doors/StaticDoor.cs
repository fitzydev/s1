using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Interaction;
using ScheduleOne.Map;
using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.Doors
{
	// Token: 0x0200060B RID: 1547
	[Token(Token = "0x200060B")]
	public class StaticDoor : MonoBehaviour
	{
		// Token: 0x06002644 RID: 9796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002644")]
		[Address(RVA = "0x6FDD50", Offset = "0x6FC750", VA = "0x1806FDD50", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06002645 RID: 9797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002645")]
		[Address(RVA = "0x6FE370", Offset = "0x6FCD70", VA = "0x1806FE370", Slot = "5")]
		protected virtual void OnValidate()
		{
		}

		// Token: 0x06002646 RID: 9798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002646")]
		[Address(RVA = "0x6FE560", Offset = "0x6FCF60", VA = "0x1806FE560", Slot = "6")]
		protected virtual void Update()
		{
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002647")]
		[Address(RVA = "0x6FE070", Offset = "0x6FCA70", VA = "0x1806FE070", Slot = "7")]
		protected virtual void Hovered()
		{
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x0000BCE8 File Offset: 0x00009EE8
		[Token(Token = "0x6002648")]
		[Address(RVA = "0x6FE000", Offset = "0x6FCA00", VA = "0x1806FE000", Slot = "8")]
		protected virtual bool CanKnockNow()
		{
			return default(bool);
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x0000BD00 File Offset: 0x00009F00
		[Token(Token = "0x6002649")]
		[Address(RVA = "0x6FE180", Offset = "0x6FCB80", VA = "0x1806FE180", Slot = "9")]
		protected virtual bool IsKnockValid(out string message)
		{
			return default(bool);
		}

		// Token: 0x0600264A RID: 9802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600264A")]
		[Address(RVA = "0x6FE160", Offset = "0x6FCB60", VA = "0x1806FE160", Slot = "10")]
		protected virtual void Interacted()
		{
		}

		// Token: 0x0600264B RID: 9803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600264B")]
		[Address(RVA = "0x6FE1D0", Offset = "0x6FCBD0", VA = "0x1806FE1D0", Slot = "11")]
		protected virtual void Knock()
		{
		}

		// Token: 0x0600264C RID: 9804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600264C")]
		[Address(RVA = "0x6FE2B0", Offset = "0x6FCCB0", VA = "0x1806FE2B0", Slot = "12")]
		protected virtual void NPCSelected(NPC npc)
		{
		}

		// Token: 0x0600264D RID: 9805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600264D")]
		[Address(RVA = "0x6E8900", Offset = "0x6E7300", VA = "0x1806E8900")]
		public StaticDoor()
		{
		}

		// Token: 0x0600264E RID: 9806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600264E")]
		[Address(RVA = "0x6FE4F0", Offset = "0x6FCEF0", VA = "0x1806FE4F0")]
		[CompilerGenerated]
		private IEnumerator <Knock>g__knockRoutine|17_0()
		{
			return null;
		}

		// Token: 0x04001D83 RID: 7555
		[Token(Token = "0x4001D83")]
		public const float KNOCK_COOLDOWN = 2f;

		// Token: 0x04001D84 RID: 7556
		[Token(Token = "0x4001D84")]
		public const float SUMMON_DURATION = 8f;

		// Token: 0x04001D85 RID: 7557
		[Token(Token = "0x4001D85")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public Transform AccessPoint;

		// Token: 0x04001D86 RID: 7558
		[Token(Token = "0x4001D86")]
		[FieldOffset(Offset = "0x28")]
		public InteractableObject IntObj;

		// Token: 0x04001D87 RID: 7559
		[Token(Token = "0x4001D87")]
		[FieldOffset(Offset = "0x30")]
		public AudioSourceController KnockSound;

		// Token: 0x04001D88 RID: 7560
		[Token(Token = "0x4001D88")]
		[FieldOffset(Offset = "0x38")]
		public NPCEnterableBuilding Building;

		// Token: 0x04001D89 RID: 7561
		[Token(Token = "0x4001D89")]
		[FieldOffset(Offset = "0x40")]
		[Header("Settings")]
		public bool Usable;

		// Token: 0x04001D8A RID: 7562
		[Token(Token = "0x4001D8A")]
		[FieldOffset(Offset = "0x41")]
		public bool CanKnock;

		// Token: 0x04001D8B RID: 7563
		[Token(Token = "0x4001D8B")]
		[FieldOffset(Offset = "0x44")]
		private float timeSinceLastKnock;

		// Token: 0x04001D8C RID: 7564
		[Token(Token = "0x4001D8C")]
		[FieldOffset(Offset = "0x48")]
		private int doorIndex;
	}
}
