using System;
using System.Collections;
using System.Runtime.CompilerServices;
using EasyButtons;
using Il2CppDummyDll;
using ScheduleOne.NPCs.CharacterClasses;
using ScheduleOne.Property;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Quests
{
	// Token: 0x0200030A RID: 778
	[Token(Token = "0x200030A")]
	public class Quest_WelcomeToHylandPoint : Quest
	{
		// Token: 0x06001166 RID: 4454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001166")]
		[Address(RVA = "0x5A0D00", Offset = "0x59F700", VA = "0x1805A0D00", Slot = "43")]
		protected override void MinPass()
		{
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001167")]
		[Address(RVA = "0x5A0F60", Offset = "0x59F960", VA = "0x1805A0F60")]
		private void Update()
		{
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001168")]
		[Address(RVA = "0x5A0C30", Offset = "0x59F630", VA = "0x1805A0C30")]
		[Button]
		public void Explode()
		{
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001169")]
		[Address(RVA = "0x5A0D70", Offset = "0x59F770", VA = "0x1805A0D70", Slot = "40")]
		public override void SetQuestState(EQuestState state, bool network = true)
		{
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600116A")]
		[Address(RVA = "0x5A11C0", Offset = "0x59FBC0", VA = "0x1805A11C0")]
		public Quest_WelcomeToHylandPoint()
		{
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600116B")]
		[Address(RVA = "0x5A0F10", Offset = "0x59F910", VA = "0x1805A0F10")]
		[CompilerGenerated]
		internal static IEnumerator <Explode>g__Shake|11_0()
		{
			return null;
		}

		// Token: 0x0400111D RID: 4381
		[Token(Token = "0x400111D")]
		[FieldOffset(Offset = "0x138")]
		public QuestEntry ReturnToRVQuest;

		// Token: 0x0400111E RID: 4382
		[Token(Token = "0x400111E")]
		[FieldOffset(Offset = "0x140")]
		public QuestEntry ReadMessagesQuest;

		// Token: 0x0400111F RID: 4383
		[Token(Token = "0x400111F")]
		[FieldOffset(Offset = "0x148")]
		public RV RV;

		// Token: 0x04001120 RID: 4384
		[Token(Token = "0x4001120")]
		[FieldOffset(Offset = "0x150")]
		public UncleNelson Nelson;

		// Token: 0x04001121 RID: 4385
		[Token(Token = "0x4001121")]
		[FieldOffset(Offset = "0x158")]
		[Header("Settings")]
		public float ExplosionMaxDist;

		// Token: 0x04001122 RID: 4386
		[Token(Token = "0x4001122")]
		[FieldOffset(Offset = "0x15C")]
		public float ExplosionMinDist;

		// Token: 0x04001123 RID: 4387
		[Token(Token = "0x4001123")]
		[FieldOffset(Offset = "0x160")]
		public UnityEvent onExplode;

		// Token: 0x04001124 RID: 4388
		[Token(Token = "0x4001124")]
		[FieldOffset(Offset = "0x168")]
		private bool exploded;

		// Token: 0x04001125 RID: 4389
		[Token(Token = "0x4001125")]
		[FieldOffset(Offset = "0x16C")]
		private float cameraLookTime;
	}
}
