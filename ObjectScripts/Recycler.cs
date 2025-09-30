using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Interaction;
using ScheduleOne.Misc;
using ScheduleOne.Trash;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000C65 RID: 3173
	[Token(Token = "0x2000C65")]
	public class Recycler : NetworkBehaviour
	{
		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x06005540 RID: 21824 RVA: 0x00015378 File Offset: 0x00013578
		// (set) Token: 0x06005541 RID: 21825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BB8")]
		public Recycler.EState State
		{
			[Token(Token = "0x6005540")]
			[Address(RVA = "0x548840", Offset = "0x547240", VA = "0x180548840")]
			[CompilerGenerated]
			get
			{
				return Recycler.EState.HatchClosed;
			}
			[Token(Token = "0x6005541")]
			[Address(RVA = "0x7EF5A0", Offset = "0x7EDFA0", VA = "0x1807EF5A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06005542 RID: 21826 RVA: 0x00015390 File Offset: 0x00013590
		// (set) Token: 0x06005543 RID: 21827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BB9")]
		public bool IsHatchOpen
		{
			[Token(Token = "0x6005542")]
			[Address(RVA = "0x548850", Offset = "0x547250", VA = "0x180548850")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005543")]
			[Address(RVA = "0x703510", Offset = "0x701F10", VA = "0x180703510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005544 RID: 21828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005544")]
		[Address(RVA = "0x9DA450", Offset = "0x9D8E50", VA = "0x1809DA450")]
		public void Start()
		{
		}

		// Token: 0x06005545 RID: 21829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005545")]
		[Address(RVA = "0x9D8D30", Offset = "0x9D7730", VA = "0x1809D8D30", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06005546 RID: 21830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005546")]
		[Address(RVA = "0x9D8A50", Offset = "0x9D7450", VA = "0x1809D8A50")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005547 RID: 21831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005547")]
		[Address(RVA = "0x9D86A0", Offset = "0x9D70A0", VA = "0x1809D86A0")]
		private void MinPass()
		{
		}

		// Token: 0x06005548 RID: 21832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005548")]
		[Address(RVA = "0x9D8690", Offset = "0x9D7090", VA = "0x1809D8690")]
		public void HandleInteracted()
		{
		}

		// Token: 0x06005549 RID: 21833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005549")]
		[Address(RVA = "0x9D7C50", Offset = "0x9D6650", VA = "0x1809D7C50")]
		public void ButtonInteracted()
		{
		}

		// Token: 0x0600554A RID: 21834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600554A")]
		[Address(RVA = "0x9D7EA0", Offset = "0x9D68A0", VA = "0x1809D7EA0")]
		public void CashInteracted()
		{
		}

		// Token: 0x0600554B RID: 21835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600554B")]
		[Address(RVA = "0x9D9AB0", Offset = "0x9D84B0", VA = "0x1809D9AB0")]
		[ServerRpc(RequireOwnership = false)]
		private void SendCashCollected()
		{
		}

		// Token: 0x0600554C RID: 21836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600554C")]
		[Address(RVA = "0x9D7D40", Offset = "0x9D6740", VA = "0x1809D7D40")]
		[ObserversRpc(RunLocally = true)]
		private void CashCollected()
		{
		}

		// Token: 0x0600554D RID: 21837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600554D")]
		[Address(RVA = "0x9D81C0", Offset = "0x9D6BC0", VA = "0x1809D81C0")]
		[ObserversRpc(RunLocally = true)]
		private void EnableCash()
		{
		}

		// Token: 0x0600554E RID: 21838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600554E")]
		[Address(RVA = "0x9D9F90", Offset = "0x9D8990", VA = "0x1809D9F90")]
		[ObserversRpc(RunLocally = true)]
		private void SetCashValue(float amount)
		{
		}

		// Token: 0x0600554F RID: 21839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600554F")]
		[Address(RVA = "0x9D8D80", Offset = "0x9D7780", VA = "0x1809D8D80")]
		private IEnumerator Process(bool startedByLocalPlayer)
		{
			return null;
		}

		// Token: 0x06005550 RID: 21840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005550")]
		[Address(RVA = "0x9D9E50", Offset = "0x9D8850", VA = "0x1809D9E50")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendState(Recycler.EState state)
		{
		}

		// Token: 0x06005551 RID: 21841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005551")]
		[Address(RVA = "0x9DA1B0", Offset = "0x9D8BB0", VA = "0x1809DA1B0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetState(NetworkConnection conn, Recycler.EState state, bool force = false)
		{
		}

		// Token: 0x06005552 RID: 21842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005552")]
		[Address(RVA = "0x9DA0D0", Offset = "0x9D8AD0", VA = "0x1809DA0D0")]
		private void SetHatchOpen(bool open)
		{
		}

		// Token: 0x06005553 RID: 21843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005553")]
		[Address(RVA = "0x9D82F0", Offset = "0x9D6CF0", VA = "0x1809D82F0")]
		private TrashItem[] GetTrash()
		{
			return null;
		}

		// Token: 0x06005554 RID: 21844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005554")]
		[Address(RVA = "0x9D8B70", Offset = "0x9D7570", VA = "0x1809D8B70")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06005555 RID: 21845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005555")]
		[Address(RVA = "0x606820", Offset = "0x605220", VA = "0x180606820")]
		public Recycler()
		{
		}

		// Token: 0x06005556 RID: 21846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005556")]
		[Address(RVA = "0x9D8820", Offset = "0x9D7220", VA = "0x1809D8820", Slot = "19")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005557 RID: 21847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005557")]
		[Address(RVA = "0x9D8800", Offset = "0x9D7200", VA = "0x1809D8800", Slot = "20")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005558 RID: 21848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005558")]
		[Address(RVA = "0x601B00", Offset = "0x600500", VA = "0x180601B00", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005559 RID: 21849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005559")]
		[Address(RVA = "0x9D9AB0", Offset = "0x9D84B0", VA = "0x1809D9AB0")]
		private void RpcWriter___Server_SendCashCollected_2166136261()
		{
		}

		// Token: 0x0600555A RID: 21850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600555A")]
		[Address(RVA = "0x9D7D40", Offset = "0x9D6740", VA = "0x1809D7D40")]
		private void RpcLogic___SendCashCollected_2166136261()
		{
		}

		// Token: 0x0600555B RID: 21851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600555B")]
		[Address(RVA = "0x9D9320", Offset = "0x9D7D20", VA = "0x1809D9320")]
		private void RpcReader___Server_SendCashCollected_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600555C RID: 21852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600555C")]
		[Address(RVA = "0x9D95B0", Offset = "0x9D7FB0", VA = "0x1809D95B0")]
		private void RpcWriter___Observers_CashCollected_2166136261()
		{
		}

		// Token: 0x0600555D RID: 21853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600555D")]
		[Address(RVA = "0x9D8E00", Offset = "0x9D7800", VA = "0x1809D8E00")]
		private void RpcLogic___CashCollected_2166136261()
		{
		}

		// Token: 0x0600555E RID: 21854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600555E")]
		[Address(RVA = "0x9D9160", Offset = "0x9D7B60", VA = "0x1809D9160")]
		private void RpcReader___Observers_CashCollected_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600555F RID: 21855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600555F")]
		[Address(RVA = "0x9D96D0", Offset = "0x9D80D0", VA = "0x1809D96D0")]
		private void RpcWriter___Observers_EnableCash_2166136261()
		{
		}

		// Token: 0x06005560 RID: 21856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005560")]
		[Address(RVA = "0x9D8E50", Offset = "0x9D7850", VA = "0x1809D8E50")]
		private void RpcLogic___EnableCash_2166136261()
		{
		}

		// Token: 0x06005561 RID: 21857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005561")]
		[Address(RVA = "0x9D91D0", Offset = "0x9D7BD0", VA = "0x1809D91D0")]
		private void RpcReader___Observers_EnableCash_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005562 RID: 21858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005562")]
		[Address(RVA = "0x9D97F0", Offset = "0x9D81F0", VA = "0x1809D97F0")]
		private void RpcWriter___Observers_SetCashValue_431000436(float amount)
		{
		}

		// Token: 0x06005563 RID: 21859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005563")]
		[Address(RVA = "0x9D8EA0", Offset = "0x9D78A0", VA = "0x1809D8EA0")]
		private void RpcLogic___SetCashValue_431000436(float amount)
		{
		}

		// Token: 0x06005564 RID: 21860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005564")]
		[Address(RVA = "0x9D9220", Offset = "0x9D7C20", VA = "0x1809D9220")]
		private void RpcReader___Observers_SetCashValue_431000436(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005565 RID: 21861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005565")]
		[Address(RVA = "0x9D9BC0", Offset = "0x9D85C0", VA = "0x1809D9BC0")]
		private void RpcWriter___Server_SendState_3569965459(Recycler.EState state)
		{
		}

		// Token: 0x06005566 RID: 21862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005566")]
		[Address(RVA = "0x9D8E80", Offset = "0x9D7880", VA = "0x1809D8E80")]
		public void RpcLogic___SendState_3569965459(Recycler.EState state)
		{
		}

		// Token: 0x06005567 RID: 21863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005567")]
		[Address(RVA = "0x9D9490", Offset = "0x9D7E90", VA = "0x1809D9490")]
		private void RpcReader___Server_SendState_3569965459(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005568 RID: 21864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005568")]
		[Address(RVA = "0x9D9940", Offset = "0x9D8340", VA = "0x1809D9940")]
		private void RpcWriter___Observers_SetState_3790170803(NetworkConnection conn, Recycler.EState state, bool force = false)
		{
		}

		// Token: 0x06005569 RID: 21865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005569")]
		[Address(RVA = "0x9D8EB0", Offset = "0x9D78B0", VA = "0x1809D8EB0")]
		private void RpcLogic___SetState_3790170803(NetworkConnection conn, Recycler.EState state, bool force = false)
		{
		}

		// Token: 0x0600556A RID: 21866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600556A")]
		[Address(RVA = "0x9D9280", Offset = "0x9D7C80", VA = "0x1809D9280")]
		private void RpcReader___Observers_SetState_3790170803(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600556B RID: 21867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600556B")]
		[Address(RVA = "0x9D9CF0", Offset = "0x9D86F0", VA = "0x1809D9CF0")]
		private void RpcWriter___Target_SetState_3790170803(NetworkConnection conn, Recycler.EState state, bool force = false)
		{
		}

		// Token: 0x0600556C RID: 21868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600556C")]
		[Address(RVA = "0x9D9510", Offset = "0x9D7F10", VA = "0x1809D9510")]
		private void RpcReader___Target_SetState_3790170803(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600556D RID: 21869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600556D")]
		[Address(RVA = "0x601B00", Offset = "0x600500", VA = "0x180601B00", Slot = "21")]
		public virtual void Awake()
		{
		}

		// Token: 0x04003F41 RID: 16193
		[Token(Token = "0x4003F41")]
		[FieldOffset(Offset = "0x120")]
		public LayerMask DetectionMask;

		// Token: 0x04003F42 RID: 16194
		[Token(Token = "0x4003F42")]
		[FieldOffset(Offset = "0x128")]
		[Header("References")]
		public InteractableObject HandleIntObj;

		// Token: 0x04003F43 RID: 16195
		[Token(Token = "0x4003F43")]
		[FieldOffset(Offset = "0x130")]
		public InteractableObject ButtonIntObj;

		// Token: 0x04003F44 RID: 16196
		[Token(Token = "0x4003F44")]
		[FieldOffset(Offset = "0x138")]
		public InteractableObject CashIntObj;

		// Token: 0x04003F45 RID: 16197
		[Token(Token = "0x4003F45")]
		[FieldOffset(Offset = "0x140")]
		public ToggleableLight ButtonLight;

		// Token: 0x04003F46 RID: 16198
		[Token(Token = "0x4003F46")]
		[FieldOffset(Offset = "0x148")]
		public Animation ButtonAnim;

		// Token: 0x04003F47 RID: 16199
		[Token(Token = "0x4003F47")]
		[FieldOffset(Offset = "0x150")]
		public Animation HatchAnim;

		// Token: 0x04003F48 RID: 16200
		[Token(Token = "0x4003F48")]
		[FieldOffset(Offset = "0x158")]
		public Animation CashAnim;

		// Token: 0x04003F49 RID: 16201
		[Token(Token = "0x4003F49")]
		[FieldOffset(Offset = "0x160")]
		public RectTransform OpenHatchInstruction;

		// Token: 0x04003F4A RID: 16202
		[Token(Token = "0x4003F4A")]
		[FieldOffset(Offset = "0x168")]
		public RectTransform InsertTrashInstruction;

		// Token: 0x04003F4B RID: 16203
		[Token(Token = "0x4003F4B")]
		[FieldOffset(Offset = "0x170")]
		public RectTransform PressBeginInstruction;

		// Token: 0x04003F4C RID: 16204
		[Token(Token = "0x4003F4C")]
		[FieldOffset(Offset = "0x178")]
		public RectTransform ProcessingScreen;

		// Token: 0x04003F4D RID: 16205
		[Token(Token = "0x4003F4D")]
		[FieldOffset(Offset = "0x180")]
		public TextMeshProUGUI ProcessingLabel;

		// Token: 0x04003F4E RID: 16206
		[Token(Token = "0x4003F4E")]
		[FieldOffset(Offset = "0x188")]
		public TextMeshProUGUI ValueLabel;

		// Token: 0x04003F4F RID: 16207
		[Token(Token = "0x4003F4F")]
		[FieldOffset(Offset = "0x190")]
		public BoxCollider CheckCollider;

		// Token: 0x04003F50 RID: 16208
		[Token(Token = "0x4003F50")]
		[FieldOffset(Offset = "0x198")]
		public Transform Cash;

		// Token: 0x04003F51 RID: 16209
		[Token(Token = "0x4003F51")]
		[FieldOffset(Offset = "0x1A0")]
		public GameObject BankNote;

		// Token: 0x04003F52 RID: 16210
		[Token(Token = "0x4003F52")]
		[FieldOffset(Offset = "0x1A8")]
		[Header("Sound")]
		public AudioSourceController OpenSound;

		// Token: 0x04003F53 RID: 16211
		[Token(Token = "0x4003F53")]
		[FieldOffset(Offset = "0x1B0")]
		public AudioSourceController CloseSound;

		// Token: 0x04003F54 RID: 16212
		[Token(Token = "0x4003F54")]
		[FieldOffset(Offset = "0x1B8")]
		public AudioSourceController PressSound;

		// Token: 0x04003F55 RID: 16213
		[Token(Token = "0x4003F55")]
		[FieldOffset(Offset = "0x1C0")]
		public AudioSourceController DoneSound;

		// Token: 0x04003F56 RID: 16214
		[Token(Token = "0x4003F56")]
		[FieldOffset(Offset = "0x1C8")]
		public AudioSourceController CashEjectSound;

		// Token: 0x04003F57 RID: 16215
		[Token(Token = "0x4003F57")]
		[FieldOffset(Offset = "0x1D0")]
		private float cashValue;

		// Token: 0x04003F58 RID: 16216
		[Token(Token = "0x4003F58")]
		[FieldOffset(Offset = "0x1D8")]
		public UnityEvent onStart;

		// Token: 0x04003F59 RID: 16217
		[Token(Token = "0x4003F59")]
		[FieldOffset(Offset = "0x1E0")]
		public UnityEvent onStop;

		// Token: 0x04003F5A RID: 16218
		[Token(Token = "0x4003F5A")]
		[FieldOffset(Offset = "0x1E8")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.RecyclerAssembly-CSharp.dll_Excuted;

		// Token: 0x04003F5B RID: 16219
		[Token(Token = "0x4003F5B")]
		[FieldOffset(Offset = "0x1E9")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.RecyclerAssembly-CSharp.dll_Excuted;

		// Token: 0x02000C66 RID: 3174
		[Token(Token = "0x2000C66")]
		public enum EState
		{
			// Token: 0x04003F5D RID: 16221
			[Token(Token = "0x4003F5D")]
			HatchClosed,
			// Token: 0x04003F5E RID: 16222
			[Token(Token = "0x4003F5E")]
			HatchOpen,
			// Token: 0x04003F5F RID: 16223
			[Token(Token = "0x4003F5F")]
			Processing
		}
	}
}
