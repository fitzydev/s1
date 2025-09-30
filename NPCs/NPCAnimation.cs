using System;
using FishNet.Object;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.NPCs
{
	// Token: 0x02000660 RID: 1632
	[Token(Token = "0x2000660")]
	public class NPCAnimation : NetworkBehaviour
	{
		// Token: 0x060028BB RID: 10427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028BB")]
		[Address(RVA = "0x701160", Offset = "0x6FFB60", VA = "0x180701160", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x060028BC RID: 10428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028BC")]
		[Address(RVA = "0x7011E0", Offset = "0x6FFBE0", VA = "0x1807011E0", Slot = "20")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028BD")]
		[Address(RVA = "0x701420", Offset = "0x6FFE20", VA = "0x180701420", Slot = "21")]
		protected virtual void UpdateMovementAnimation()
		{
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028BE")]
		[Address(RVA = "0x7012C0", Offset = "0x6FFCC0", VA = "0x1807012C0", Slot = "22")]
		public virtual void SetRagdollActive(bool active)
		{
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028BF")]
		[Address(RVA = "0x701370", Offset = "0x6FFD70", VA = "0x180701370")]
		public void StandupStart()
		{
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C0")]
		[Address(RVA = "0x701300", Offset = "0x6FFD00", VA = "0x180701300")]
		public void StandupDone()
		{
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C1")]
		[Address(RVA = "0x606820", Offset = "0x605220", VA = "0x180606820")]
		public NPCAnimation()
		{
		}

		// Token: 0x060028C2 RID: 10434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C2")]
		[Address(RVA = "0x7012A0", Offset = "0x6FFCA0", VA = "0x1807012A0", Slot = "23")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C3")]
		[Address(RVA = "0x701280", Offset = "0x6FFC80", VA = "0x180701280", Slot = "24")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x060028C4 RID: 10436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C4")]
		[Address(RVA = "0x6806A0", Offset = "0x67F0A0", VA = "0x1806806A0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060028C5 RID: 10437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C5")]
		[Address(RVA = "0x701110", Offset = "0x6FFB10", VA = "0x180701110")]
		private void Awake_UserLogic_ScheduleOne.NPCs.NPCAnimation_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001EAE RID: 7854
		[Token(Token = "0x4001EAE")]
		[FieldOffset(Offset = "0x118")]
		public bool DEBUG;

		// Token: 0x04001EAF RID: 7855
		[Token(Token = "0x4001EAF")]
		[FieldOffset(Offset = "0x120")]
		protected NPC npc;

		// Token: 0x04001EB0 RID: 7856
		[Token(Token = "0x4001EB0")]
		[FieldOffset(Offset = "0x128")]
		[Header("Settings")]
		public AnimationCurve WalkMapCurve;

		// Token: 0x04001EB1 RID: 7857
		[Token(Token = "0x4001EB1")]
		[FieldOffset(Offset = "0x130")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.NPCAnimationAssembly-CSharp.dll_Excuted;

		// Token: 0x04001EB2 RID: 7858
		[Token(Token = "0x4001EB2")]
		[FieldOffset(Offset = "0x131")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.NPCAnimationAssembly-CSharp.dll_Excuted;
	}
}
