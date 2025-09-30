using System;
using Il2CppDummyDll;
using ScheduleOne.Dialogue;
using ScheduleOne.UI.Shop;
using UnityEngine;

namespace ScheduleOne.NPCs
{
	// Token: 0x0200065A RID: 1626
	[Token(Token = "0x200065A")]
	public class Stan : NPC
	{
		// Token: 0x060027A6 RID: 10150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A6")]
		[Address(RVA = "0x7175B0", Offset = "0x715FB0", VA = "0x1807175B0", Slot = "70")]
		protected override void Start()
		{
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A7")]
		[Address(RVA = "0x7170D0", Offset = "0x715AD0", VA = "0x1807170D0")]
		private void Loaded()
		{
		}

		// Token: 0x060027A8 RID: 10152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A8")]
		[Address(RVA = "0x716FF0", Offset = "0x7159F0", VA = "0x180716FF0")]
		private void EnableGreeting()
		{
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A9")]
		[Address(RVA = "0x717420", Offset = "0x715E20", VA = "0x180717420")]
		private void SetGreeted()
		{
		}

		// Token: 0x060027AA RID: 10154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AA")]
		[Address(RVA = "0x717370", Offset = "0x715D70", VA = "0x180717370")]
		private void OrderCompleted()
		{
		}

		// Token: 0x060027AB RID: 10155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AB")]
		[Address(RVA = "0x717700", Offset = "0x716100", VA = "0x180717700")]
		public Stan()
		{
		}

		// Token: 0x060027AC RID: 10156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AC")]
		[Address(RVA = "0x717350", Offset = "0x715D50", VA = "0x180717350", Slot = "99")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060027AD RID: 10157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AD")]
		[Address(RVA = "0x7172F0", Offset = "0x715CF0", VA = "0x1807172F0", Slot = "100")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060027AE RID: 10158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AE")]
		[Address(RVA = "0x687D80", Offset = "0x686780", VA = "0x180687D80", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AF")]
		[Address(RVA = "0x701020", Offset = "0x6FFA20", VA = "0x180701020", Slot = "64")]
		public override void Awake()
		{
		}

		// Token: 0x04001E5B RID: 7771
		[Token(Token = "0x4001E5B")]
		[FieldOffset(Offset = "0x2F0")]
		public ShopInterface ShopInterface;

		// Token: 0x04001E5C RID: 7772
		[Token(Token = "0x4001E5C")]
		[FieldOffset(Offset = "0x2F8")]
		public DialogueContainer GreetingDialogue;

		// Token: 0x04001E5D RID: 7773
		[Token(Token = "0x4001E5D")]
		[FieldOffset(Offset = "0x300")]
		public string GreetedVariable;

		// Token: 0x04001E5E RID: 7774
		[Token(Token = "0x4001E5E")]
		[FieldOffset(Offset = "0x308")]
		[Header("Settings")]
		public string[] OrderCompletedLines;

		// Token: 0x04001E5F RID: 7775
		[Token(Token = "0x4001E5F")]
		[FieldOffset(Offset = "0x310")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.StanAssembly-CSharp.dll_Excuted;

		// Token: 0x04001E60 RID: 7776
		[Token(Token = "0x4001E60")]
		[FieldOffset(Offset = "0x311")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.StanAssembly-CSharp.dll_Excuted;
	}
}
