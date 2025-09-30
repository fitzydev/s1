using System;
using System.Runtime.CompilerServices;
using EasyButtons;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Interaction;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Casino
{
	// Token: 0x020007E5 RID: 2021
	[Token(Token = "0x20007E5")]
	public class SlotMachine : NetworkBehaviour
	{
		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x060036F6 RID: 14070 RVA: 0x0000EF10 File Offset: 0x0000D110
		// (set) Token: 0x060036F7 RID: 14071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007E6")]
		public bool IsSpinning
		{
			[Token(Token = "0x60036F6")]
			[Address(RVA = "0x542F10", Offset = "0x541910", VA = "0x180542F10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60036F7")]
			[Address(RVA = "0x6775B0", Offset = "0x675FB0", VA = "0x1806775B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x060036F8 RID: 14072 RVA: 0x0000EF28 File Offset: 0x0000D128
		[Token(Token = "0x170007E7")]
		private int currentBetAmount
		{
			[Token(Token = "0x60036F8")]
			[Address(RVA = "0x7D4FC0", Offset = "0x7D39C0", VA = "0x1807D4FC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060036F9 RID: 14073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F9")]
		[Address(RVA = "0x7D2980", Offset = "0x7D1380", VA = "0x1807D2980", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x060036FA RID: 14074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036FA")]
		[Address(RVA = "0x7D3570", Offset = "0x7D1F70", VA = "0x1807D3570", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060036FB RID: 14075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036FB")]
		[Address(RVA = "0x7D2BF0", Offset = "0x7D15F0", VA = "0x1807D2BF0")]
		private void DownHovered()
		{
		}

		// Token: 0x060036FC RID: 14076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036FC")]
		[Address(RVA = "0x7D2C70", Offset = "0x7D1670", VA = "0x1807D2C70")]
		private void DownInteracted()
		{
		}

		// Token: 0x060036FD RID: 14077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036FD")]
		[Address(RVA = "0x7D4E50", Offset = "0x7D3850", VA = "0x1807D4E50")]
		private void UpHovered()
		{
		}

		// Token: 0x060036FE RID: 14078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036FE")]
		[Address(RVA = "0x7D4ED0", Offset = "0x7D38D0", VA = "0x1807D4ED0")]
		private void UpInteracted()
		{
		}

		// Token: 0x060036FF RID: 14079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036FF")]
		[Address(RVA = "0x7D2EC0", Offset = "0x7D18C0", VA = "0x1807D2EC0")]
		private void HandleHovered()
		{
		}

		// Token: 0x06003700 RID: 14080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003700")]
		[Address(RVA = "0x7D3000", Offset = "0x7D1A00", VA = "0x1807D3000")]
		[Button]
		public void HandleInteracted()
		{
		}

		// Token: 0x06003701 RID: 14081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003701")]
		[Address(RVA = "0x7D43D0", Offset = "0x7D2DD0", VA = "0x1807D43D0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendBetIndex(int index)
		{
		}

		// Token: 0x06003702 RID: 14082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003702")]
		[Address(RVA = "0x7D4670", Offset = "0x7D3070", VA = "0x1807D4670")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetBetIndex(NetworkConnection conn, int index)
		{
		}

		// Token: 0x06003703 RID: 14083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003703")]
		[Address(RVA = "0x7D4510", Offset = "0x7D2F10", VA = "0x1807D4510")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendStartSpin(NetworkConnection spinner, int betAmount)
		{
		}

		// Token: 0x06003704 RID: 14084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003704")]
		[Address(RVA = "0x7D4CB0", Offset = "0x7D36B0", VA = "0x1807D4CB0")]
		[ObserversRpc(RunLocally = true)]
		public void StartSpin(NetworkConnection spinner, SlotMachine.ESymbol[] symbols, int betAmount)
		{
		}

		// Token: 0x06003705 RID: 14085 RVA: 0x0000EF40 File Offset: 0x0000D140
		[Token(Token = "0x6003705")]
		[Address(RVA = "0x7D2CB0", Offset = "0x7D16B0", VA = "0x1807D2CB0")]
		private SlotMachine.EOutcome EvaluateOutcome(SlotMachine.ESymbol[] outcome)
		{
			return SlotMachine.EOutcome.Jackpot;
		}

		// Token: 0x06003706 RID: 14086 RVA: 0x0000EF58 File Offset: 0x0000D158
		[Token(Token = "0x6003706")]
		[Address(RVA = "0x7D2E90", Offset = "0x7D1890", VA = "0x1807D2E90")]
		private int GetWinAmount(SlotMachine.EOutcome outcome, int betAmount)
		{
			return 0;
		}

		// Token: 0x06003707 RID: 14087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003707")]
		[Address(RVA = "0x7D29D0", Offset = "0x7D13D0", VA = "0x1807D29D0")]
		private void DisplayOutcome(SlotMachine.EOutcome outcome, int winAmount)
		{
		}

		// Token: 0x06003708 RID: 14088 RVA: 0x0000EF70 File Offset: 0x0000D170
		[Token(Token = "0x6003708")]
		[Address(RVA = "0x7D2DA0", Offset = "0x7D17A0", VA = "0x1807D2DA0")]
		public static SlotMachine.ESymbol GetRandomSymbol()
		{
			return SlotMachine.ESymbol.Cherry;
		}

		// Token: 0x06003709 RID: 14089 RVA: 0x0000EF88 File Offset: 0x0000D188
		[Token(Token = "0x6003709")]
		[Address(RVA = "0x7D3330", Offset = "0x7D1D30", VA = "0x1807D3330")]
		private bool IsFruit(SlotMachine.ESymbol symbol)
		{
			return default(bool);
		}

		// Token: 0x0600370A RID: 14090 RVA: 0x0000EFA0 File Offset: 0x0000D1A0
		[Token(Token = "0x600370A")]
		[Address(RVA = "0x7D32D0", Offset = "0x7D1CD0", VA = "0x1807D32D0")]
		private bool IsAllFruit(SlotMachine.ESymbol[] symbols)
		{
			return default(bool);
		}

		// Token: 0x0600370B RID: 14091 RVA: 0x0000EFB8 File Offset: 0x0000D1B8
		[Token(Token = "0x600370B")]
		[Address(RVA = "0x7D3340", Offset = "0x7D1D40", VA = "0x1807D3340")]
		private bool IsUniform(SlotMachine.ESymbol[] symbols)
		{
			return default(bool);
		}

		// Token: 0x0600370C RID: 14092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600370C")]
		[Address(RVA = "0x7D48F0", Offset = "0x7D32F0", VA = "0x1807D48F0")]
		[Button]
		public void SimulateMany()
		{
		}

		// Token: 0x0600370D RID: 14093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600370D")]
		[Address(RVA = "0x7D4FA0", Offset = "0x7D39A0", VA = "0x1807D4FA0")]
		public SlotMachine()
		{
		}

		// Token: 0x0600370F RID: 14095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600370F")]
		[Address(RVA = "0x7D33C0", Offset = "0x7D1DC0", VA = "0x1807D33C0", Slot = "20")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003710 RID: 14096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003710")]
		[Address(RVA = "0x7D33A0", Offset = "0x7D1DA0", VA = "0x1807D33A0", Slot = "21")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003711 RID: 14097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003711")]
		[Address(RVA = "0x6783D0", Offset = "0x676DD0", VA = "0x1806783D0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003712 RID: 14098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003712")]
		[Address(RVA = "0x7D3FB0", Offset = "0x7D29B0", VA = "0x1807D3FB0")]
		private void RpcWriter___Server_SendBetIndex_3316948804(int index)
		{
		}

		// Token: 0x06003713 RID: 14099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003713")]
		[Address(RVA = "0x7D35C0", Offset = "0x7D1FC0", VA = "0x1807D35C0")]
		private void RpcLogic___SendBetIndex_3316948804(int index)
		{
		}

		// Token: 0x06003714 RID: 14100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003714")]
		[Address(RVA = "0x7D3B50", Offset = "0x7D2550", VA = "0x1807D3B50")]
		private void RpcReader___Server_SendBetIndex_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003715 RID: 14101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003715")]
		[Address(RVA = "0x7D3CE0", Offset = "0x7D26E0", VA = "0x1807D3CE0")]
		private void RpcWriter___Observers_SetBetIndex_2681120339(NetworkConnection conn, int index)
		{
		}

		// Token: 0x06003716 RID: 14102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003716")]
		[Address(RVA = "0x7D3820", Offset = "0x7D2220", VA = "0x1807D3820")]
		public void RpcLogic___SetBetIndex_2681120339(NetworkConnection conn, int index)
		{
		}

		// Token: 0x06003717 RID: 14103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003717")]
		[Address(RVA = "0x7D3A30", Offset = "0x7D2430", VA = "0x1807D3A30")]
		private void RpcReader___Observers_SetBetIndex_2681120339(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003718 RID: 14104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003718")]
		[Address(RVA = "0x7D4260", Offset = "0x7D2C60", VA = "0x1807D4260")]
		private void RpcWriter___Target_SetBetIndex_2681120339(NetworkConnection conn, int index)
		{
		}

		// Token: 0x06003719 RID: 14105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003719")]
		[Address(RVA = "0x7D3C70", Offset = "0x7D2670", VA = "0x1807D3C70")]
		private void RpcReader___Target_SetBetIndex_2681120339(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600371A RID: 14106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600371A")]
		[Address(RVA = "0x7D40F0", Offset = "0x7D2AF0", VA = "0x1807D40F0")]
		private void RpcWriter___Server_SendStartSpin_2681120339(NetworkConnection spinner, int betAmount)
		{
		}

		// Token: 0x0600371B RID: 14107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600371B")]
		[Address(RVA = "0x7D35D0", Offset = "0x7D1FD0", VA = "0x1807D35D0")]
		public void RpcLogic___SendStartSpin_2681120339(NetworkConnection spinner, int betAmount)
		{
		}

		// Token: 0x0600371C RID: 14108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600371C")]
		[Address(RVA = "0x7D3BD0", Offset = "0x7D25D0", VA = "0x1807D3BD0")]
		private void RpcReader___Server_SendStartSpin_2681120339(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600371D RID: 14109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600371D")]
		[Address(RVA = "0x7D3E30", Offset = "0x7D2830", VA = "0x1807D3E30")]
		private void RpcWriter___Observers_StartSpin_2659526290(NetworkConnection spinner, SlotMachine.ESymbol[] symbols, int betAmount)
		{
		}

		// Token: 0x0600371E RID: 14110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600371E")]
		[Address(RVA = "0x7D38F0", Offset = "0x7D22F0", VA = "0x1807D38F0")]
		public void RpcLogic___StartSpin_2659526290(NetworkConnection spinner, SlotMachine.ESymbol[] symbols, int betAmount)
		{
		}

		// Token: 0x0600371F RID: 14111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600371F")]
		[Address(RVA = "0x7D3AA0", Offset = "0x7D24A0", VA = "0x1807D3AA0")]
		private void RpcReader___Observers_StartSpin_2659526290(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003720 RID: 14112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003720")]
		[Address(RVA = "0x7D2710", Offset = "0x7D1110", VA = "0x1807D2710")]
		private void Awake_UserLogic_ScheduleOne.Casino.SlotMachine_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002638 RID: 9784
		[Token(Token = "0x4002638")]
		[FieldOffset(Offset = "0x0")]
		public static int[] BetAmounts;

		// Token: 0x0400263A RID: 9786
		[Token(Token = "0x400263A")]
		[FieldOffset(Offset = "0x120")]
		[Header("References")]
		public InteractableObject DownButton;

		// Token: 0x0400263B RID: 9787
		[Token(Token = "0x400263B")]
		[FieldOffset(Offset = "0x128")]
		public InteractableObject UpButton;

		// Token: 0x0400263C RID: 9788
		[Token(Token = "0x400263C")]
		[FieldOffset(Offset = "0x130")]
		public InteractableObject HandleIntObj;

		// Token: 0x0400263D RID: 9789
		[Token(Token = "0x400263D")]
		[FieldOffset(Offset = "0x138")]
		public TextMeshPro BetAmountLabel;

		// Token: 0x0400263E RID: 9790
		[Token(Token = "0x400263E")]
		[FieldOffset(Offset = "0x140")]
		public SlotReel[] Reels;

		// Token: 0x0400263F RID: 9791
		[Token(Token = "0x400263F")]
		[FieldOffset(Offset = "0x148")]
		public AudioSourceController SpinLoop;

		// Token: 0x04002640 RID: 9792
		[Token(Token = "0x4002640")]
		[FieldOffset(Offset = "0x150")]
		public Animation ScreenAnimation;

		// Token: 0x04002641 RID: 9793
		[Token(Token = "0x4002641")]
		[FieldOffset(Offset = "0x158")]
		public ParticleSystem[] JackpotParticles;

		// Token: 0x04002642 RID: 9794
		[Token(Token = "0x4002642")]
		[FieldOffset(Offset = "0x160")]
		[Header("Win Animations")]
		public TextMeshProUGUI[] WinAmountLabels;

		// Token: 0x04002643 RID: 9795
		[Token(Token = "0x4002643")]
		[FieldOffset(Offset = "0x168")]
		public AnimationClip MiniWinAnimation;

		// Token: 0x04002644 RID: 9796
		[Token(Token = "0x4002644")]
		[FieldOffset(Offset = "0x170")]
		public AnimationClip SmallWinAnimation;

		// Token: 0x04002645 RID: 9797
		[Token(Token = "0x4002645")]
		[FieldOffset(Offset = "0x178")]
		public AnimationClip BigWinAnimation;

		// Token: 0x04002646 RID: 9798
		[Token(Token = "0x4002646")]
		[FieldOffset(Offset = "0x180")]
		public AnimationClip JackpotAnimation;

		// Token: 0x04002647 RID: 9799
		[Token(Token = "0x4002647")]
		[FieldOffset(Offset = "0x188")]
		public AudioSourceController MiniWinSound;

		// Token: 0x04002648 RID: 9800
		[Token(Token = "0x4002648")]
		[FieldOffset(Offset = "0x190")]
		public AudioSourceController SmallWinSound;

		// Token: 0x04002649 RID: 9801
		[Token(Token = "0x4002649")]
		[FieldOffset(Offset = "0x198")]
		public AudioSourceController BigWinSound;

		// Token: 0x0400264A RID: 9802
		[Token(Token = "0x400264A")]
		[FieldOffset(Offset = "0x1A0")]
		public AudioSourceController JackpotSound;

		// Token: 0x0400264B RID: 9803
		[Token(Token = "0x400264B")]
		[FieldOffset(Offset = "0x1A8")]
		public UnityEvent onDownPressed;

		// Token: 0x0400264C RID: 9804
		[Token(Token = "0x400264C")]
		[FieldOffset(Offset = "0x1B0")]
		public UnityEvent onUpPressed;

		// Token: 0x0400264D RID: 9805
		[Token(Token = "0x400264D")]
		[FieldOffset(Offset = "0x1B8")]
		public UnityEvent onHandlePulled;

		// Token: 0x0400264E RID: 9806
		[Token(Token = "0x400264E")]
		[FieldOffset(Offset = "0x1C0")]
		private int currentBetIndex;

		// Token: 0x0400264F RID: 9807
		[Token(Token = "0x400264F")]
		[FieldOffset(Offset = "0x1C4")]
		private bool NetworkInitialize___EarlyScheduleOne.Casino.SlotMachineAssembly-CSharp.dll_Excuted;

		// Token: 0x04002650 RID: 9808
		[Token(Token = "0x4002650")]
		[FieldOffset(Offset = "0x1C5")]
		private bool NetworkInitialize__LateScheduleOne.Casino.SlotMachineAssembly-CSharp.dll_Excuted;

		// Token: 0x020007E6 RID: 2022
		[Token(Token = "0x20007E6")]
		public enum ESymbol
		{
			// Token: 0x04002652 RID: 9810
			[Token(Token = "0x4002652")]
			Cherry,
			// Token: 0x04002653 RID: 9811
			[Token(Token = "0x4002653")]
			Lemon,
			// Token: 0x04002654 RID: 9812
			[Token(Token = "0x4002654")]
			Grape,
			// Token: 0x04002655 RID: 9813
			[Token(Token = "0x4002655")]
			Watermelon,
			// Token: 0x04002656 RID: 9814
			[Token(Token = "0x4002656")]
			Bell,
			// Token: 0x04002657 RID: 9815
			[Token(Token = "0x4002657")]
			Seven
		}

		// Token: 0x020007E7 RID: 2023
		[Token(Token = "0x20007E7")]
		public enum EOutcome
		{
			// Token: 0x04002659 RID: 9817
			[Token(Token = "0x4002659")]
			Jackpot,
			// Token: 0x0400265A RID: 9818
			[Token(Token = "0x400265A")]
			BigWin,
			// Token: 0x0400265B RID: 9819
			[Token(Token = "0x400265B")]
			SmallWin,
			// Token: 0x0400265C RID: 9820
			[Token(Token = "0x400265C")]
			MiniWin,
			// Token: 0x0400265D RID: 9821
			[Token(Token = "0x400265D")]
			NoWin
		}
	}
}
