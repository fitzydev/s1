using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Interaction;
using ScheduleOne.Variables;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x020009F9 RID: 2553
	[Token(Token = "0x20009F9")]
	[RequireComponent(typeof(InteractableObject))]
	public class ItemPickup : NetworkBehaviour
	{
		// Token: 0x060045A4 RID: 17828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045A4")]
		[Address(RVA = "0x8C0C50", Offset = "0x8BF650", VA = "0x1808C0C50", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x060045A5 RID: 17829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045A5")]
		[Address(RVA = "0x8C17E0", Offset = "0x8C01E0", VA = "0x1808C17E0")]
		private void Start()
		{
		}

		// Token: 0x060045A6 RID: 17830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045A6")]
		[Address(RVA = "0x8C10F0", Offset = "0x8BFAF0", VA = "0x1808C10F0")]
		private void Init()
		{
		}

		// Token: 0x060045A7 RID: 17831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045A7")]
		[Address(RVA = "0x8C1000", Offset = "0x8BFA00", VA = "0x1808C1000", Slot = "20")]
		protected virtual void Hovered()
		{
		}

		// Token: 0x060045A8 RID: 17832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045A8")]
		[Address(RVA = "0x8C12E0", Offset = "0x8BFCE0", VA = "0x1808C12E0")]
		private void Interacted()
		{
		}

		// Token: 0x060045A9 RID: 17833 RVA: 0x00012570 File Offset: 0x00010770
		[Token(Token = "0x60045A9")]
		[Address(RVA = "0x8C0DF0", Offset = "0x8BF7F0", VA = "0x1808C0DF0", Slot = "21")]
		protected virtual bool CanPickup()
		{
			return default(bool);
		}

		// Token: 0x060045AA RID: 17834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045AA")]
		[Address(RVA = "0x8C13C0", Offset = "0x8BFDC0", VA = "0x1808C13C0", Slot = "22")]
		protected virtual void Pickup()
		{
		}

		// Token: 0x060045AB RID: 17835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045AB")]
		[Address(RVA = "0x8C0EF0", Offset = "0x8BF8F0", VA = "0x1808C0EF0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void Destroy()
		{
		}

		// Token: 0x060045AC RID: 17836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045AC")]
		[Address(RVA = "0x8C1A00", Offset = "0x8C0400", VA = "0x1808C1A00")]
		public ItemPickup()
		{
		}

		// Token: 0x060045AD RID: 17837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045AD")]
		[Address(RVA = "0x8C1990", Offset = "0x8C0390", VA = "0x1808C1990")]
		[CompilerGenerated]
		private IEnumerator <Init>g__Wait|9_0()
		{
			return null;
		}

		// Token: 0x060045AE RID: 17838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045AE")]
		[Address(RVA = "0x8C1330", Offset = "0x8BFD30", VA = "0x1808C1330", Slot = "23")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x060045AF RID: 17839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045AF")]
		[Address(RVA = "0x7C8200", Offset = "0x7C6C00", VA = "0x1807C8200", Slot = "24")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x060045B0 RID: 17840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045B0")]
		[Address(RVA = "0x6806A0", Offset = "0x67F0A0", VA = "0x1806806A0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060045B1 RID: 17841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045B1")]
		[Address(RVA = "0x8C16D0", Offset = "0x8C00D0", VA = "0x1808C16D0")]
		private void RpcWriter___Server_Destroy_2166136261()
		{
		}

		// Token: 0x060045B2 RID: 17842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045B2")]
		[Address(RVA = "0x8C1600", Offset = "0x8C0000", VA = "0x1808C1600")]
		public void RpcLogic___Destroy_2166136261()
		{
		}

		// Token: 0x060045B3 RID: 17843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045B3")]
		[Address(RVA = "0x8C1680", Offset = "0x8C0080", VA = "0x1808C1680")]
		private void RpcReader___Server_Destroy_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060045B4 RID: 17844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045B4")]
		[Address(RVA = "0x8C0AE0", Offset = "0x8BF4E0", VA = "0x1808C0AE0", Slot = "25")]
		protected virtual void Awake_UserLogic_ScheduleOne.ItemFramework.ItemPickup_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040030D4 RID: 12500
		[Token(Token = "0x40030D4")]
		[FieldOffset(Offset = "0x118")]
		public ItemDefinition ItemToGive;

		// Token: 0x040030D5 RID: 12501
		[Token(Token = "0x40030D5")]
		[FieldOffset(Offset = "0x120")]
		public bool DestroyOnPickup;

		// Token: 0x040030D6 RID: 12502
		[Token(Token = "0x40030D6")]
		[FieldOffset(Offset = "0x121")]
		public bool ConditionallyActive;

		// Token: 0x040030D7 RID: 12503
		[Token(Token = "0x40030D7")]
		[FieldOffset(Offset = "0x128")]
		public Condition ActiveCondition;

		// Token: 0x040030D8 RID: 12504
		[Token(Token = "0x40030D8")]
		[FieldOffset(Offset = "0x130")]
		public bool Networked;

		// Token: 0x040030D9 RID: 12505
		[Token(Token = "0x40030D9")]
		[FieldOffset(Offset = "0x138")]
		[Header("References")]
		public InteractableObject IntObj;

		// Token: 0x040030DA RID: 12506
		[Token(Token = "0x40030DA")]
		[FieldOffset(Offset = "0x140")]
		public UnityEvent onPickup;

		// Token: 0x040030DB RID: 12507
		[Token(Token = "0x40030DB")]
		[FieldOffset(Offset = "0x148")]
		private bool NetworkInitialize___EarlyScheduleOne.ItemFramework.ItemPickupAssembly-CSharp.dll_Excuted;

		// Token: 0x040030DC RID: 12508
		[Token(Token = "0x40030DC")]
		[FieldOffset(Offset = "0x149")]
		private bool NetworkInitialize__LateScheduleOne.ItemFramework.ItemPickupAssembly-CSharp.dll_Excuted;
	}
}
