using System;
using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.UI.Construction.Features;
using UnityEngine;

namespace ScheduleOne.Construction.Features
{
	// Token: 0x0200079E RID: 1950
	[Token(Token = "0x200079E")]
	public abstract class OptionListFeature : Feature
	{
		// Token: 0x06003496 RID: 13462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003496")]
		[Address(RVA = "0x78FF60", Offset = "0x78E960", VA = "0x18078FF60", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x06003497 RID: 13463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003497")]
		[Address(RVA = "0x7A4E10", Offset = "0x7A3810", VA = "0x1807A4E10", Slot = "20")]
		public override FI_Base CreateInterface(Transform parent)
		{
			return null;
		}

		// Token: 0x06003498 RID: 13464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003498")]
		[Address(RVA = "0x7A4FA0", Offset = "0x7A39A0", VA = "0x1807A4FA0", Slot = "21")]
		public override void Default()
		{
		}

		// Token: 0x06003499 RID: 13465
		[Token(Token = "0x6003499")]
		protected abstract List<FI_OptionList.Option> GetOptions();

		// Token: 0x0600349A RID: 13466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600349A")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "26")]
		public virtual void SelectOption(int optionIndex)
		{
		}

		// Token: 0x0600349B RID: 13467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600349B")]
		[Address(RVA = "0x7A55C0", Offset = "0x7A3FC0", VA = "0x1807A55C0", Slot = "27")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		protected virtual void SetData(int colorIndex)
		{
		}

		// Token: 0x0600349C RID: 13468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600349C")]
		[Address(RVA = "0x7A5320", Offset = "0x7A3D20", VA = "0x1807A5320")]
		private void ReceiveData()
		{
		}

		// Token: 0x0600349D RID: 13469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600349D")]
		[Address(RVA = "0x7A51D0", Offset = "0x7A3BD0", VA = "0x1807A51D0", Slot = "28")]
		public virtual void PurchaseOption(int optionIndex)
		{
		}

		// Token: 0x0600349E RID: 13470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600349E")]
		[Address(RVA = "0x7A2CE0", Offset = "0x7A16E0", VA = "0x1807A2CE0")]
		protected OptionListFeature()
		{
		}

		// Token: 0x0600349F RID: 13471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600349F")]
		[Address(RVA = "0x7A5020", Offset = "0x7A3A20", VA = "0x1807A5020", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060034A0 RID: 13472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034A0")]
		[Address(RVA = "0x7A4FC0", Offset = "0x7A39C0", VA = "0x1807A4FC0", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060034A1 RID: 13473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034A1")]
		[Address(RVA = "0x5B3020", Offset = "0x5B1A20", VA = "0x1805B3020", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060034A2 RID: 13474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034A2")]
		[Address(RVA = "0x7A5480", Offset = "0x7A3E80", VA = "0x1807A5480")]
		private void RpcWriter___Server_SetData_3316948804(int colorIndex)
		{
		}

		// Token: 0x060034A3 RID: 13475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034A3")]
		[Address(RVA = "0x7A5340", Offset = "0x7A3D40", VA = "0x1807A5340", Slot = "29")]
		protected virtual void RpcLogic___SetData_3316948804(int colorIndex)
		{
		}

		// Token: 0x060034A4 RID: 13476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034A4")]
		[Address(RVA = "0x7A5400", Offset = "0x7A3E00", VA = "0x1807A5400")]
		private void RpcReader___Server_SetData_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x060034A5 RID: 13477 RVA: 0x0000E640 File Offset: 0x0000C840
		// (set) Token: 0x060034A6 RID: 13478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007A6")]
		public int SyncAccessor_ownedOptionIndex
		{
			[Token(Token = "0x60034A5")]
			[Address(RVA = "0x5385F0", Offset = "0x536FF0", VA = "0x1805385F0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60034A6")]
			[Address(RVA = "0x7A5700", Offset = "0x7A4100", VA = "0x1807A5700")]
			set
			{
			}
		}

		// Token: 0x060034A7 RID: 13479 RVA: 0x0000E658 File Offset: 0x0000C858
		[Token(Token = "0x60034A7")]
		[Address(RVA = "0x7A51F0", Offset = "0x7A3BF0", VA = "0x1807A51F0", Slot = "30")]
		public virtual bool ReadSyncVar___ScheduleOne.Construction.Features.OptionListFeature(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x060034A8 RID: 13480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034A8")]
		[Address(RVA = "0x5B3020", Offset = "0x5B1A20", VA = "0x1805B3020", Slot = "31")]
		protected virtual void Awake_UserLogic_ScheduleOne.Construction.Features.OptionListFeature_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002497 RID: 9367
		[Token(Token = "0x4002497")]
		[FieldOffset(Offset = "0x140")]
		[Header("Option list feature settings")]
		public int defaultOptionIndex;

		// Token: 0x04002498 RID: 9368
		[Token(Token = "0x4002498")]
		[FieldOffset(Offset = "0x144")]
		[SyncVar]
		public int ownedOptionIndex;

		// Token: 0x04002499 RID: 9369
		[Token(Token = "0x4002499")]
		[FieldOffset(Offset = "0x148")]
		public SyncVar<int> syncVar___ownedOptionIndex;

		// Token: 0x0400249A RID: 9370
		[Token(Token = "0x400249A")]
		[FieldOffset(Offset = "0x150")]
		private bool NetworkInitialize___EarlyScheduleOne.Construction.Features.OptionListFeatureAssembly-CSharp.dll_Excuted;

		// Token: 0x0400249B RID: 9371
		[Token(Token = "0x400249B")]
		[FieldOffset(Offset = "0x151")]
		private bool NetworkInitialize__LateScheduleOne.Construction.Features.OptionListFeatureAssembly-CSharp.dll_Excuted;
	}
}
