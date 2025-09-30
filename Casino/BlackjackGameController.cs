using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Casino
{
	// Token: 0x020007C7 RID: 1991
	[Token(Token = "0x20007C7")]
	public class BlackjackGameController : CasinoGameController
	{
		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x060035A4 RID: 13732 RVA: 0x0000EAA8 File Offset: 0x0000CCA8
		// (set) Token: 0x060035A5 RID: 13733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007C4")]
		public BlackjackGameController.EStage CurrentStage
		{
			[Token(Token = "0x60035A4")]
			[Address(RVA = "0x6CAE40", Offset = "0x6C9840", VA = "0x1806CAE40")]
			[CompilerGenerated]
			get
			{
				return BlackjackGameController.EStage.WaitingForPlayers;
			}
			[Token(Token = "0x60035A5")]
			[Address(RVA = "0x6CB040", Offset = "0x6C9A40", VA = "0x1806CB040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x060035A6 RID: 13734 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060035A7 RID: 13735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007C5")]
		public Player PlayerTurn
		{
			[Token(Token = "0x60035A6")]
			[Address(RVA = "0x63D950", Offset = "0x63C350", VA = "0x18063D950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60035A7")]
			[Address(RVA = "0x71CA90", Offset = "0x71B490", VA = "0x18071CA90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x060035A8 RID: 13736 RVA: 0x0000EAC0 File Offset: 0x0000CCC0
		// (set) Token: 0x060035A9 RID: 13737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007C6")]
		public float LocalPlayerBet
		{
			[Token(Token = "0x60035A8")]
			[Address(RVA = "0x7C4710", Offset = "0x7C3110", VA = "0x1807C4710")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60035A9")]
			[Address(RVA = "0x7C4750", Offset = "0x7C3150", VA = "0x1807C4750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x060035AA RID: 13738 RVA: 0x0000EAD8 File Offset: 0x0000CCD8
		// (set) Token: 0x060035AB RID: 13739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007C7")]
		public int DealerScore
		{
			[Token(Token = "0x60035AA")]
			[Address(RVA = "0x790CD0", Offset = "0x78F6D0", VA = "0x180790CD0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60035AB")]
			[Address(RVA = "0x7C4720", Offset = "0x7C3120", VA = "0x1807C4720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x060035AC RID: 13740 RVA: 0x0000EAF0 File Offset: 0x0000CCF0
		// (set) Token: 0x060035AD RID: 13741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007C8")]
		public int LocalPlayerScore
		{
			[Token(Token = "0x60035AC")]
			[Address(RVA = "0x73B250", Offset = "0x739C50", VA = "0x18073B250")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60035AD")]
			[Address(RVA = "0x739D10", Offset = "0x738710", VA = "0x180739D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x060035AE RID: 13742 RVA: 0x0000EB08 File Offset: 0x0000CD08
		// (set) Token: 0x060035AF RID: 13743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007C9")]
		public bool IsLocalPlayerBlackjack
		{
			[Token(Token = "0x60035AE")]
			[Address(RVA = "0x7C4660", Offset = "0x7C3060", VA = "0x1807C4660")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60035AF")]
			[Address(RVA = "0x7C4730", Offset = "0x7C3130", VA = "0x1807C4730")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x060035B0 RID: 13744 RVA: 0x0000EB20 File Offset: 0x0000CD20
		// (set) Token: 0x060035B1 RID: 13745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007CA")]
		public bool IsLocalPlayerBust
		{
			[Token(Token = "0x60035B0")]
			[Address(RVA = "0x7C4670", Offset = "0x7C3070", VA = "0x1807C4670")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60035B1")]
			[Address(RVA = "0x7C4740", Offset = "0x7C3140", VA = "0x1807C4740")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x060035B2 RID: 13746 RVA: 0x0000EB38 File Offset: 0x0000CD38
		[Token(Token = "0x170007CB")]
		public bool IsLocalPlayerInCurrentRound
		{
			[Token(Token = "0x60035B2")]
			[Address(RVA = "0x7C4680", Offset = "0x7C3080", VA = "0x1807C4680")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060035B3 RID: 13747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035B3")]
		[Address(RVA = "0x7C0510", Offset = "0x7BEF10", VA = "0x1807C0510", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x060035B4 RID: 13748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035B4")]
		[Address(RVA = "0x7C1A10", Offset = "0x7C0410", VA = "0x1807C1A10", Slot = "24")]
		protected override void Open()
		{
		}

		// Token: 0x060035B5 RID: 13749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035B5")]
		[Address(RVA = "0x7C0560", Offset = "0x7BEF60", VA = "0x1807C0560", Slot = "25")]
		protected override void Close()
		{
		}

		// Token: 0x060035B6 RID: 13750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035B6")]
		[Address(RVA = "0x7C08F0", Offset = "0x7BF2F0", VA = "0x1807C08F0", Slot = "21")]
		protected override void Exit(ExitAction action)
		{
		}

		// Token: 0x060035B7 RID: 13751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035B7")]
		[Address(RVA = "0x7C0990", Offset = "0x7BF390", VA = "0x1807C0990", Slot = "23")]
		protected override void FixedUpdate()
		{
		}

		// Token: 0x060035B8 RID: 13752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035B8")]
		[Address(RVA = "0x7C0E70", Offset = "0x7BF870", VA = "0x1807C0E70")]
		private List<Player> GetClockwisePlayers()
		{
			return null;
		}

		// Token: 0x060035B9 RID: 13753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035B9")]
		[Address(RVA = "0x7C4180", Offset = "0x7C2B80", VA = "0x1807C4180")]
		[ObserversRpc(RunLocally = true)]
		private void StartGame()
		{
		}

		// Token: 0x060035BA RID: 13754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035BA")]
		[Address(RVA = "0x7C1870", Offset = "0x7C0270", VA = "0x1807C1870")]
		[ObserversRpc(RunLocally = true)]
		private void NotifyPlayerScore(NetworkObject player, int score, bool blackjack)
		{
		}

		// Token: 0x060035BB RID: 13755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035BB")]
		[Address(RVA = "0x7C1340", Offset = "0x7BFD40", VA = "0x1807C1340")]
		private Transform[] GetPlayerCardPositions(int playerIndex)
		{
			return null;
		}

		// Token: 0x060035BC RID: 13756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035BC")]
		[Address(RVA = "0x7C4040", Offset = "0x7C2A40", VA = "0x1807C4040")]
		[ObserversRpc(RunLocally = true)]
		private void SetRoundEnded(bool ended)
		{
		}

		// Token: 0x060035BD RID: 13757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035BD")]
		[Address(RVA = "0x7BFF40", Offset = "0x7BE940", VA = "0x1807BFF40")]
		private void AddCardToPlayerHand(int playerIndex, PlayingCard card)
		{
		}

		// Token: 0x060035BE RID: 13758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035BE")]
		[Address(RVA = "0x7C00B0", Offset = "0x7BEAB0", VA = "0x1807C00B0")]
		[ObserversRpc(RunLocally = true)]
		private void AddCardToPlayerHand(int playerindex, string cardID)
		{
		}

		// Token: 0x060035BF RID: 13759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035BF")]
		[Address(RVA = "0x7BFE00", Offset = "0x7BE800", VA = "0x1807BFE00")]
		[ObserversRpc(RunLocally = true)]
		private void AddCardToDealerHand(string cardID)
		{
		}

		// Token: 0x060035C0 RID: 13760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035C0")]
		[Address(RVA = "0x7C1380", Offset = "0x7BFD80", VA = "0x1807C1380")]
		private List<PlayingCard> GetPlayerCards(int playerIndex)
		{
			return null;
		}

		// Token: 0x060035C1 RID: 13761 RVA: 0x0000EB50 File Offset: 0x0000CD50
		[Token(Token = "0x60035C1")]
		[Address(RVA = "0x7C10A0", Offset = "0x7BFAA0", VA = "0x1807C10A0")]
		private int GetHandScore(List<PlayingCard> cards, bool countFaceDown = true)
		{
			return 0;
		}

		// Token: 0x060035C2 RID: 13762 RVA: 0x0000EB68 File Offset: 0x0000CD68
		[Token(Token = "0x60035C2")]
		[Address(RVA = "0x7C0E20", Offset = "0x7BF820", VA = "0x1807C0E20")]
		private int GetCardValue(PlayingCard card, bool aceAsEleven = true)
		{
			return 0;
		}

		// Token: 0x060035C3 RID: 13763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035C3")]
		[Address(RVA = "0x7C0610", Offset = "0x7BF010", VA = "0x1807C0610")]
		private PlayingCard DrawCard()
		{
			return null;
		}

		// Token: 0x060035C4 RID: 13764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C4")]
		[Address(RVA = "0x7C21B0", Offset = "0x7C0BB0", VA = "0x1807C21B0")]
		private void ResetCards()
		{
		}

		// Token: 0x060035C5 RID: 13765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C5")]
		[Address(RVA = "0x7C07B0", Offset = "0x7BF1B0", VA = "0x1807C07B0")]
		[ObserversRpc(RunLocally = true)]
		private void EndGame()
		{
		}

		// Token: 0x060035C6 RID: 13766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C6")]
		[Address(RVA = "0x7C1BF0", Offset = "0x7C05F0", VA = "0x1807C1BF0")]
		public void RemoveLocalPlayerFromGame(BlackjackGameController.EPayoutType payout, float cameraDelay = 0f)
		{
		}

		// Token: 0x060035C7 RID: 13767 RVA: 0x0000EB80 File Offset: 0x0000CD80
		[Token(Token = "0x60035C7")]
		[Address(RVA = "0x7C1310", Offset = "0x7BFD10", VA = "0x1807C1310")]
		public float GetPayout(float bet, BlackjackGameController.EPayoutType payout)
		{
			return 0f;
		}

		// Token: 0x060035C8 RID: 13768 RVA: 0x0000EB98 File Offset: 0x0000CD98
		[Token(Token = "0x60035C8")]
		[Address(RVA = "0x7C1520", Offset = "0x7BFF20", VA = "0x1807C1520")]
		private bool IsCurrentRoundEmpty()
		{
			return default(bool);
		}

		// Token: 0x060035C9 RID: 13769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C9")]
		[Address(RVA = "0x7C0220", Offset = "0x7BEC20", VA = "0x1807C0220")]
		[ObserversRpc(RunLocally = true)]
		private void AddPlayerToCurrentRound(NetworkObject player)
		{
		}

		// Token: 0x060035CA RID: 13770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035CA")]
		[Address(RVA = "0x7C2080", Offset = "0x7C0A80", VA = "0x1807C2080")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void RequestRemovePlayerFromCurrentRound(NetworkObject player)
		{
		}

		// Token: 0x060035CB RID: 13771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035CB")]
		[Address(RVA = "0x7C1F40", Offset = "0x7C0940", VA = "0x1807C1F40")]
		[ObserversRpc(RunLocally = true)]
		private void RemovePlayerFromCurrentRound(NetworkObject player)
		{
		}

		// Token: 0x060035CC RID: 13772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035CC")]
		[Address(RVA = "0x7C4000", Offset = "0x7C2A00", VA = "0x1807C4000")]
		public void SetLocalPlayerBet(float bet)
		{
		}

		// Token: 0x060035CD RID: 13773 RVA: 0x0000EBB0 File Offset: 0x0000CDB0
		[Token(Token = "0x60035CD")]
		[Address(RVA = "0x7C0360", Offset = "0x7BED60", VA = "0x1807C0360")]
		public bool AreAllPlayersReady()
		{
			return default(bool);
		}

		// Token: 0x060035CE RID: 13774 RVA: 0x0000EBC8 File Offset: 0x0000CDC8
		[Token(Token = "0x60035CE")]
		[Address(RVA = "0x7C13C0", Offset = "0x7BFDC0", VA = "0x1807C13C0")]
		public int GetPlayersReadyCount()
		{
			return 0;
		}

		// Token: 0x060035CF RID: 13775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035CF")]
		[Address(RVA = "0x7C42A0", Offset = "0x7C2CA0", VA = "0x1807C42A0")]
		public void ToggleLocalPlayerReady()
		{
		}

		// Token: 0x060035D0 RID: 13776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D0")]
		[Address(RVA = "0x7C4400", Offset = "0x7C2E00", VA = "0x1807C4400")]
		public BlackjackGameController()
		{
		}

		// Token: 0x060035D1 RID: 13777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D1")]
		[Address(RVA = "0x7C15A0", Offset = "0x7BFFA0", VA = "0x1807C15A0", Slot = "26")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060035D2 RID: 13778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D2")]
		[Address(RVA = "0x7C1570", Offset = "0x7BFF70", VA = "0x1807C1570", Slot = "27")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060035D3 RID: 13779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D3")]
		[Address(RVA = "0x75FAE0", Offset = "0x75E4E0", VA = "0x18075FAE0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060035D4 RID: 13780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D4")]
		[Address(RVA = "0x7C3DC0", Offset = "0x7C27C0", VA = "0x1807C3DC0")]
		private void RpcWriter___Observers_StartGame_2166136261()
		{
		}

		// Token: 0x060035D5 RID: 13781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D5")]
		[Address(RVA = "0x7C2D20", Offset = "0x7C1720", VA = "0x1807C2D20")]
		private void RpcLogic___StartGame_2166136261()
		{
		}

		// Token: 0x060035D6 RID: 13782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D6")]
		[Address(RVA = "0x7C33E0", Offset = "0x7C1DE0", VA = "0x1807C33E0")]
		private void RpcReader___Observers_StartGame_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060035D7 RID: 13783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D7")]
		[Address(RVA = "0x7C39C0", Offset = "0x7C23C0", VA = "0x1807C39C0")]
		private void RpcWriter___Observers_NotifyPlayerScore_2864061566(NetworkObject player, int score, bool blackjack)
		{
		}

		// Token: 0x060035D8 RID: 13784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D8")]
		[Address(RVA = "0x7C2AF0", Offset = "0x7C14F0", VA = "0x1807C2AF0")]
		private void RpcLogic___NotifyPlayerScore_2864061566(NetworkObject player, int score, bool blackjack)
		{
		}

		// Token: 0x060035D9 RID: 13785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D9")]
		[Address(RVA = "0x7C3230", Offset = "0x7C1C30", VA = "0x1807C3230")]
		private void RpcReader___Observers_NotifyPlayerScore_2864061566(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060035DA RID: 13786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035DA")]
		[Address(RVA = "0x7C3C80", Offset = "0x7C2680", VA = "0x1807C3C80")]
		private void RpcWriter___Observers_SetRoundEnded_1140765316(bool ended)
		{
		}

		// Token: 0x060035DB RID: 13787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035DB")]
		[Address(RVA = "0x7C2D10", Offset = "0x7C1710", VA = "0x1807C2D10")]
		private void RpcLogic___SetRoundEnded_1140765316(bool ended)
		{
		}

		// Token: 0x060035DC RID: 13788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035DC")]
		[Address(RVA = "0x7C3370", Offset = "0x7C1D70", VA = "0x1807C3370")]
		private void RpcReader___Observers_SetRoundEnded_1140765316(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060035DD RID: 13789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035DD")]
		[Address(RVA = "0x7C35E0", Offset = "0x7C1FE0", VA = "0x1807C35E0")]
		private void RpcWriter___Observers_AddCardToPlayerHand_2801973956(int playerindex, string cardID)
		{
		}

		// Token: 0x060035DE RID: 13790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035DE")]
		[Address(RVA = "0x7C2740", Offset = "0x7C1140", VA = "0x1807C2740")]
		private void RpcLogic___AddCardToPlayerHand_2801973956(int playerindex, string cardID)
		{
		}

		// Token: 0x060035DF RID: 13791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035DF")]
		[Address(RVA = "0x7C30D0", Offset = "0x7C1AD0", VA = "0x1807C30D0")]
		private void RpcReader___Observers_AddCardToPlayerHand_2801973956(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060035E0 RID: 13792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035E0")]
		[Address(RVA = "0x7C34A0", Offset = "0x7C1EA0", VA = "0x1807C34A0")]
		private void RpcWriter___Observers_AddCardToDealerHand_3615296227(string cardID)
		{
		}

		// Token: 0x060035E1 RID: 13793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035E1")]
		[Address(RVA = "0x7C25D0", Offset = "0x7C0FD0", VA = "0x1807C25D0")]
		private void RpcLogic___AddCardToDealerHand_3615296227(string cardID)
		{
		}

		// Token: 0x060035E2 RID: 13794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035E2")]
		[Address(RVA = "0x7C3070", Offset = "0x7C1A70", VA = "0x1807C3070")]
		private void RpcReader___Observers_AddCardToDealerHand_3615296227(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060035E3 RID: 13795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035E3")]
		[Address(RVA = "0x7C38A0", Offset = "0x7C22A0", VA = "0x1807C38A0")]
		private void RpcWriter___Observers_EndGame_2166136261()
		{
		}

		// Token: 0x060035E4 RID: 13796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035E4")]
		[Address(RVA = "0x7C2AB0", Offset = "0x7C14B0", VA = "0x1807C2AB0")]
		private void RpcLogic___EndGame_2166136261()
		{
		}

		// Token: 0x060035E5 RID: 13797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035E5")]
		[Address(RVA = "0x7C31D0", Offset = "0x7C1BD0", VA = "0x1807C31D0")]
		private void RpcReader___Observers_EndGame_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060035E6 RID: 13798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035E6")]
		[Address(RVA = "0x7C3760", Offset = "0x7C2160", VA = "0x1807C3760")]
		private void RpcWriter___Observers_AddPlayerToCurrentRound_3323014238(NetworkObject player)
		{
		}

		// Token: 0x060035E7 RID: 13799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035E7")]
		[Address(RVA = "0x7C2960", Offset = "0x7C1360", VA = "0x1807C2960")]
		private void RpcLogic___AddPlayerToCurrentRound_3323014238(NetworkObject player)
		{
		}

		// Token: 0x060035E8 RID: 13800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035E8")]
		[Address(RVA = "0x7C3160", Offset = "0x7C1B60", VA = "0x1807C3160")]
		private void RpcReader___Observers_AddPlayerToCurrentRound_3323014238(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060035E9 RID: 13801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035E9")]
		[Address(RVA = "0x7C3ED0", Offset = "0x7C28D0", VA = "0x1807C3ED0")]
		private void RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
		}

		// Token: 0x060035EA RID: 13802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035EA")]
		[Address(RVA = "0x7C1F40", Offset = "0x7C0940", VA = "0x1807C1F40")]
		private void RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
		}

		// Token: 0x060035EB RID: 13803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035EB")]
		[Address(RVA = "0x7C3420", Offset = "0x7C1E20", VA = "0x1807C3420")]
		private void RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060035EC RID: 13804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035EC")]
		[Address(RVA = "0x7C3B40", Offset = "0x7C2540", VA = "0x1807C3B40")]
		private void RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
		}

		// Token: 0x060035ED RID: 13805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035ED")]
		[Address(RVA = "0x7C2BC0", Offset = "0x7C15C0", VA = "0x1807C2BC0")]
		private void RpcLogic___RemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
		}

		// Token: 0x060035EE RID: 13806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035EE")]
		[Address(RVA = "0x7C3300", Offset = "0x7C1D00", VA = "0x1807C3300")]
		private void RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060035EF RID: 13807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035EF")]
		[Address(RVA = "0x7C04F0", Offset = "0x7BEEF0", VA = "0x1807C04F0", Slot = "29")]
		protected virtual void Awake_UserLogic_ScheduleOne.Casino.BlackjackGameController_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002571 RID: 9585
		[Token(Token = "0x4002571")]
		public const int BET_MINIMUM = 10;

		// Token: 0x04002572 RID: 9586
		[Token(Token = "0x4002572")]
		public const int BET_MAXIMUM = 1000;

		// Token: 0x04002573 RID: 9587
		[Token(Token = "0x4002573")]
		public const float PAYOUT_RATIO = 1f;

		// Token: 0x04002574 RID: 9588
		[Token(Token = "0x4002574")]
		public const float BLACKJACK_PAYOUT_RATIO = 1.5f;

		// Token: 0x0400257C RID: 9596
		[Token(Token = "0x400257C")]
		[FieldOffset(Offset = "0x168")]
		[Header("References")]
		public PlayingCard[] Cards;

		// Token: 0x0400257D RID: 9597
		[Token(Token = "0x400257D")]
		[FieldOffset(Offset = "0x170")]
		public Transform[] DefaultCardPositions;

		// Token: 0x0400257E RID: 9598
		[Token(Token = "0x400257E")]
		[FieldOffset(Offset = "0x178")]
		public Transform[] FocusedCameraTransforms;

		// Token: 0x0400257F RID: 9599
		[Token(Token = "0x400257F")]
		[FieldOffset(Offset = "0x180")]
		public Transform[] FinalCameraTransforms;

		// Token: 0x04002580 RID: 9600
		[Token(Token = "0x4002580")]
		[FieldOffset(Offset = "0x188")]
		public Transform[] Player1CardPositions;

		// Token: 0x04002581 RID: 9601
		[Token(Token = "0x4002581")]
		[FieldOffset(Offset = "0x190")]
		public Transform[] Player2CardPositions;

		// Token: 0x04002582 RID: 9602
		[Token(Token = "0x4002582")]
		[FieldOffset(Offset = "0x198")]
		public Transform[] Player3CardPositions;

		// Token: 0x04002583 RID: 9603
		[Token(Token = "0x4002583")]
		[FieldOffset(Offset = "0x1A0")]
		public Transform[] Player4CardPositions;

		// Token: 0x04002584 RID: 9604
		[Token(Token = "0x4002584")]
		[FieldOffset(Offset = "0x1A8")]
		public Transform[] DealerCardPositions;

		// Token: 0x04002585 RID: 9605
		[Token(Token = "0x4002585")]
		[FieldOffset(Offset = "0x1B0")]
		private List<Player> playersInCurrentRound;

		// Token: 0x04002586 RID: 9606
		[Token(Token = "0x4002586")]
		[FieldOffset(Offset = "0x1B8")]
		private List<PlayingCard> playStack;

		// Token: 0x04002587 RID: 9607
		[Token(Token = "0x4002587")]
		[FieldOffset(Offset = "0x1C0")]
		private List<PlayingCard> player1Hand;

		// Token: 0x04002588 RID: 9608
		[Token(Token = "0x4002588")]
		[FieldOffset(Offset = "0x1C8")]
		private List<PlayingCard> player2Hand;

		// Token: 0x04002589 RID: 9609
		[Token(Token = "0x4002589")]
		[FieldOffset(Offset = "0x1D0")]
		private List<PlayingCard> player3Hand;

		// Token: 0x0400258A RID: 9610
		[Token(Token = "0x400258A")]
		[FieldOffset(Offset = "0x1D8")]
		private List<PlayingCard> player4Hand;

		// Token: 0x0400258B RID: 9611
		[Token(Token = "0x400258B")]
		[FieldOffset(Offset = "0x1E0")]
		private List<PlayingCard> dealerHand;

		// Token: 0x0400258C RID: 9612
		[Token(Token = "0x400258C")]
		[FieldOffset(Offset = "0x1E8")]
		private List<PlayingCard.CardData> cardValuesInDeck;

		// Token: 0x0400258D RID: 9613
		[Token(Token = "0x400258D")]
		[FieldOffset(Offset = "0x1F0")]
		private List<PlayingCard.CardData> drawnCardsValues;

		// Token: 0x0400258E RID: 9614
		[Token(Token = "0x400258E")]
		[FieldOffset(Offset = "0x1F8")]
		protected Transform localFocusCameraTransform;

		// Token: 0x0400258F RID: 9615
		[Token(Token = "0x400258F")]
		[FieldOffset(Offset = "0x200")]
		protected Transform localFinalCameraTransform;

		// Token: 0x04002590 RID: 9616
		[Token(Token = "0x4002590")]
		[FieldOffset(Offset = "0x208")]
		public Action onLocalPlayerBetChange;

		// Token: 0x04002591 RID: 9617
		[Token(Token = "0x4002591")]
		[FieldOffset(Offset = "0x210")]
		public Action onLocalPlayerExitRound;

		// Token: 0x04002592 RID: 9618
		[Token(Token = "0x4002592")]
		[FieldOffset(Offset = "0x218")]
		public Action onInitialCardsDealt;

		// Token: 0x04002593 RID: 9619
		[Token(Token = "0x4002593")]
		[FieldOffset(Offset = "0x220")]
		public Action onLocalPlayerReadyForInput;

		// Token: 0x04002594 RID: 9620
		[Token(Token = "0x4002594")]
		[FieldOffset(Offset = "0x228")]
		public Action onLocalPlayerBust;

		// Token: 0x04002595 RID: 9621
		[Token(Token = "0x4002595")]
		[FieldOffset(Offset = "0x230")]
		public Action<BlackjackGameController.EPayoutType> onLocalPlayerRoundCompleted;

		// Token: 0x04002596 RID: 9622
		[Token(Token = "0x4002596")]
		[FieldOffset(Offset = "0x238")]
		private bool roundEnded;

		// Token: 0x04002597 RID: 9623
		[Token(Token = "0x4002597")]
		[FieldOffset(Offset = "0x240")]
		private Coroutine gameRoutine;

		// Token: 0x04002598 RID: 9624
		[Token(Token = "0x4002598")]
		[FieldOffset(Offset = "0x248")]
		private bool NetworkInitialize___EarlyScheduleOne.Casino.BlackjackGameControllerAssembly-CSharp.dll_Excuted;

		// Token: 0x04002599 RID: 9625
		[Token(Token = "0x4002599")]
		[FieldOffset(Offset = "0x249")]
		private bool NetworkInitialize__LateScheduleOne.Casino.BlackjackGameControllerAssembly-CSharp.dll_Excuted;

		// Token: 0x020007C8 RID: 1992
		[Token(Token = "0x20007C8")]
		public enum EStage
		{
			// Token: 0x0400259B RID: 9627
			[Token(Token = "0x400259B")]
			WaitingForPlayers,
			// Token: 0x0400259C RID: 9628
			[Token(Token = "0x400259C")]
			Dealing,
			// Token: 0x0400259D RID: 9629
			[Token(Token = "0x400259D")]
			PlayerTurn,
			// Token: 0x0400259E RID: 9630
			[Token(Token = "0x400259E")]
			DealerTurn,
			// Token: 0x0400259F RID: 9631
			[Token(Token = "0x400259F")]
			Ending
		}

		// Token: 0x020007C9 RID: 1993
		[Token(Token = "0x20007C9")]
		public enum EPayoutType
		{
			// Token: 0x040025A1 RID: 9633
			[Token(Token = "0x40025A1")]
			None,
			// Token: 0x040025A2 RID: 9634
			[Token(Token = "0x40025A2")]
			Blackjack,
			// Token: 0x040025A3 RID: 9635
			[Token(Token = "0x40025A3")]
			Win,
			// Token: 0x040025A4 RID: 9636
			[Token(Token = "0x40025A4")]
			Push
		}
	}
}
