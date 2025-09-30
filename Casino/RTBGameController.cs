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
	// Token: 0x020007DF RID: 2015
	[Token(Token = "0x20007DF")]
	public class RTBGameController : CasinoGameController
	{
		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x060036A0 RID: 13984 RVA: 0x0000ED60 File Offset: 0x0000CF60
		// (set) Token: 0x060036A1 RID: 13985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007DB")]
		public RTBGameController.EStage CurrentStage
		{
			[Token(Token = "0x60036A0")]
			[Address(RVA = "0x7D25F0", Offset = "0x7D0FF0", VA = "0x1807D25F0")]
			[CompilerGenerated]
			get
			{
				return RTBGameController.EStage.WaitingForPlayers;
			}
			[Token(Token = "0x60036A1")]
			[Address(RVA = "0x7D26E0", Offset = "0x7D10E0", VA = "0x1807D26E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x060036A2 RID: 13986 RVA: 0x0000ED78 File Offset: 0x0000CF78
		// (set) Token: 0x060036A3 RID: 13987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007DC")]
		public bool IsQuestionActive
		{
			[Token(Token = "0x60036A2")]
			[Address(RVA = "0x796B00", Offset = "0x795500", VA = "0x180796B00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60036A3")]
			[Address(RVA = "0x796B20", Offset = "0x795520", VA = "0x180796B20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x060036A4 RID: 13988 RVA: 0x0000ED90 File Offset: 0x0000CF90
		// (set) Token: 0x060036A5 RID: 13989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007DD")]
		public float LocalPlayerBet
		{
			[Token(Token = "0x60036A4")]
			[Address(RVA = "0x7D26A0", Offset = "0x7D10A0", VA = "0x1807D26A0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60036A5")]
			[Address(RVA = "0x7D26F0", Offset = "0x7D10F0", VA = "0x1807D26F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x060036A6 RID: 13990 RVA: 0x0000EDA8 File Offset: 0x0000CFA8
		// (set) Token: 0x060036A7 RID: 13991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007DE")]
		public float LocalPlayerBetMultiplier
		{
			[Token(Token = "0x60036A6")]
			[Address(RVA = "0x7D2690", Offset = "0x7D1090", VA = "0x1807D2690")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60036A7")]
			[Address(RVA = "0x7D0FD0", Offset = "0x7CF9D0", VA = "0x1807D0FD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x060036A8 RID: 13992 RVA: 0x0000EDC0 File Offset: 0x0000CFC0
		[Token(Token = "0x170007DF")]
		public float MultipliedLocalPlayerBet
		{
			[Token(Token = "0x60036A8")]
			[Address(RVA = "0x7D26B0", Offset = "0x7D10B0", VA = "0x1807D26B0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x060036A9 RID: 13993 RVA: 0x0000EDD8 File Offset: 0x0000CFD8
		// (set) Token: 0x060036AA RID: 13994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007E0")]
		public float RemainingAnswerTime
		{
			[Token(Token = "0x60036A9")]
			[Address(RVA = "0x7D26D0", Offset = "0x7D10D0", VA = "0x1807D26D0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60036AA")]
			[Address(RVA = "0x7D2700", Offset = "0x7D1100", VA = "0x1807D2700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x060036AB RID: 13995 RVA: 0x0000EDF0 File Offset: 0x0000CFF0
		[Token(Token = "0x170007E1")]
		public bool IsLocalPlayerInCurrentRound
		{
			[Token(Token = "0x60036AB")]
			[Address(RVA = "0x7D2600", Offset = "0x7D1000", VA = "0x1807D2600")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060036AC RID: 13996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036AC")]
		[Address(RVA = "0x7CEB20", Offset = "0x7CD520", VA = "0x1807CEB20", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x060036AD RID: 13997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036AD")]
		[Address(RVA = "0x7CFF70", Offset = "0x7CE970", VA = "0x1807CFF70", Slot = "24")]
		protected override void Open()
		{
		}

		// Token: 0x060036AE RID: 13998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036AE")]
		[Address(RVA = "0x7CEB70", Offset = "0x7CD570", VA = "0x1807CEB70", Slot = "25")]
		protected override void Close()
		{
		}

		// Token: 0x060036AF RID: 13999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036AF")]
		[Address(RVA = "0x7CED70", Offset = "0x7CD770", VA = "0x1807CED70", Slot = "21")]
		protected override void Exit(ExitAction action)
		{
		}

		// Token: 0x060036B0 RID: 14000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036B0")]
		[Address(RVA = "0x7CEE10", Offset = "0x7CD810", VA = "0x1807CEE10", Slot = "23")]
		protected override void FixedUpdate()
		{
		}

		// Token: 0x060036B1 RID: 14001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036B1")]
		[Address(RVA = "0x7D2240", Offset = "0x7D0C40", VA = "0x1807D2240")]
		[ObserversRpc(RunLocally = true)]
		private void SetStage(RTBGameController.EStage stage)
		{
		}

		// Token: 0x060036B2 RID: 14002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036B2")]
		[Address(RVA = "0x7D1EB0", Offset = "0x7D08B0", VA = "0x1807D1EB0")]
		private void RunRound(RTBGameController.EStage stage)
		{
		}

		// Token: 0x060036B3 RID: 14003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036B3")]
		[Address(RVA = "0x7D1FE0", Offset = "0x7D09E0", VA = "0x1807D1FE0")]
		[ObserversRpc(RunLocally = true)]
		private void SetBetMultiplier(float multiplier)
		{
		}

		// Token: 0x060036B4 RID: 14004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036B4")]
		[Address(RVA = "0x7CEC20", Offset = "0x7CD620", VA = "0x1807CEC20")]
		[ObserversRpc(RunLocally = true)]
		private void EndGame()
		{
		}

		// Token: 0x060036B5 RID: 14005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036B5")]
		[Address(RVA = "0x7D0240", Offset = "0x7CEC40", VA = "0x1807D0240")]
		public void RemoveLocalPlayerFromGame(bool payout, float cameraDelay = 0f)
		{
		}

		// Token: 0x060036B6 RID: 14006 RVA: 0x0000EE08 File Offset: 0x0000D008
		[Token(Token = "0x60036B6")]
		[Address(RVA = "0x7CFB30", Offset = "0x7CE530", VA = "0x1807CFB30")]
		private bool IsCurrentRoundEmpty()
		{
			return default(bool);
		}

		// Token: 0x060036B7 RID: 14007 RVA: 0x0000EE20 File Offset: 0x0000D020
		[Token(Token = "0x60036B7")]
		[Address(RVA = "0x7CF1A0", Offset = "0x7CDBA0", VA = "0x1807CF1A0")]
		private float GetAnswerIndex(RTBGameController.EStage stage, PlayingCard.CardData card)
		{
			return 0f;
		}

		// Token: 0x060036B8 RID: 14008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036B8")]
		[Address(RVA = "0x7CFE30", Offset = "0x7CE830", VA = "0x1807CFE30")]
		[ObserversRpc(RunLocally = true)]
		private void NotifyAnswer(float answerIndex)
		{
		}

		// Token: 0x060036B9 RID: 14009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036B9")]
		[Address(RVA = "0x7D0120", Offset = "0x7CEB20", VA = "0x1807D0120")]
		[ObserversRpc(RunLocally = true)]
		private void QuestionDone()
		{
		}

		// Token: 0x060036BA RID: 14010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036BA")]
		[Address(RVA = "0x7CF800", Offset = "0x7CE200", VA = "0x1807CF800")]
		private void GetQuestionsAndAnswers(RTBGameController.EStage stage, out string question, out string[] answers)
		{
		}

		// Token: 0x060036BB RID: 14011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036BB")]
		[Address(RVA = "0x7D07C0", Offset = "0x7CF1C0", VA = "0x1807D07C0")]
		private void ResetCards()
		{
		}

		// Token: 0x060036BC RID: 14012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036BC")]
		[Address(RVA = "0x7CE830", Offset = "0x7CD230", VA = "0x1807CE830")]
		[ObserversRpc(RunLocally = true)]
		private void AddPlayerToCurrentRound(NetworkObject player)
		{
		}

		// Token: 0x060036BD RID: 14013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036BD")]
		[Address(RVA = "0x7D0690", Offset = "0x7CF090", VA = "0x1807D0690")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void RequestRemovePlayerFromCurrentRound(NetworkObject player)
		{
		}

		// Token: 0x060036BE RID: 14014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036BE")]
		[Address(RVA = "0x7D0550", Offset = "0x7CEF50", VA = "0x1807D0550")]
		[ObserversRpc(RunLocally = true)]
		private void RemovePlayerFromCurrentRound(NetworkObject player)
		{
		}

		// Token: 0x060036BF RID: 14015 RVA: 0x0000EE38 File Offset: 0x0000D038
		[Token(Token = "0x60036BF")]
		[Address(RVA = "0x7D0000", Offset = "0x7CEA00", VA = "0x1807D0000")]
		private PlayingCard.CardData PullCardFromDeck()
		{
			return default(PlayingCard.CardData);
		}

		// Token: 0x060036C0 RID: 14016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036C0")]
		[Address(RVA = "0x7D2200", Offset = "0x7D0C00", VA = "0x1807D2200")]
		public void SetLocalPlayerBet(float bet)
		{
		}

		// Token: 0x060036C1 RID: 14017 RVA: 0x0000EE50 File Offset: 0x0000D050
		[Token(Token = "0x60036C1")]
		[Address(RVA = "0x7CE970", Offset = "0x7CD370", VA = "0x1807CE970")]
		public bool AreAllPlayersReady()
		{
			return default(bool);
		}

		// Token: 0x060036C2 RID: 14018 RVA: 0x0000EE68 File Offset: 0x0000D068
		[Token(Token = "0x60036C2")]
		[Address(RVA = "0x7CF6A0", Offset = "0x7CE0A0", VA = "0x1807CF6A0")]
		public int GetPlayersReadyCount()
		{
			return 0;
		}

		// Token: 0x060036C3 RID: 14019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036C3")]
		[Address(RVA = "0x7D2120", Offset = "0x7D0B20", VA = "0x1807D2120")]
		public void SetLocalPlayerAnswer(float answer)
		{
		}

		// Token: 0x060036C4 RID: 14020 RVA: 0x0000EE80 File Offset: 0x0000D080
		[Token(Token = "0x60036C4")]
		[Address(RVA = "0x7CF480", Offset = "0x7CDE80", VA = "0x1807CF480")]
		public int GetAnsweredPlayersCount()
		{
			return 0;
		}

		// Token: 0x060036C5 RID: 14021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036C5")]
		[Address(RVA = "0x7D2370", Offset = "0x7D0D70", VA = "0x1807D2370")]
		public void ToggleLocalPlayerReady()
		{
		}

		// Token: 0x060036C6 RID: 14022 RVA: 0x0000EE98 File Offset: 0x0000D098
		[Token(Token = "0x60036C6")]
		[Address(RVA = "0x7CF630", Offset = "0x7CE030", VA = "0x1807CF630")]
		private int GetCardNumberValue(PlayingCard.CardData card)
		{
			return 0;
		}

		// Token: 0x060036C7 RID: 14023 RVA: 0x0000EEB0 File Offset: 0x0000D0B0
		[Token(Token = "0x60036C7")]
		[Address(RVA = "0x7CF650", Offset = "0x7CE050", VA = "0x1807CF650")]
		public static float GetNetBetMultiplier(RTBGameController.EStage stage)
		{
			return 0f;
		}

		// Token: 0x060036C8 RID: 14024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036C8")]
		[Address(RVA = "0x7D24D0", Offset = "0x7D0ED0", VA = "0x1807D24D0")]
		public RTBGameController()
		{
		}

		// Token: 0x060036C9 RID: 14025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036C9")]
		[Address(RVA = "0x7CFBB0", Offset = "0x7CE5B0", VA = "0x1807CFBB0", Slot = "26")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060036CA RID: 14026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036CA")]
		[Address(RVA = "0x7CFB80", Offset = "0x7CE580", VA = "0x1807CFB80", Slot = "27")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060036CB RID: 14027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036CB")]
		[Address(RVA = "0x75FAE0", Offset = "0x75E4E0", VA = "0x18075FAE0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060036CC RID: 14028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036CC")]
		[Address(RVA = "0x7D1C40", Offset = "0x7D0640", VA = "0x1807D1C40")]
		private void RpcWriter___Observers_SetStage_2502303021(RTBGameController.EStage stage)
		{
		}

		// Token: 0x060036CD RID: 14029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036CD")]
		[Address(RVA = "0x7D0FE0", Offset = "0x7CF9E0", VA = "0x1807D0FE0")]
		private void RpcLogic___SetStage_2502303021(RTBGameController.EStage stage)
		{
		}

		// Token: 0x060036CE RID: 14030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036CE")]
		[Address(RVA = "0x7D1410", Offset = "0x7CFE10", VA = "0x1807D1410")]
		private void RpcReader___Observers_SetStage_2502303021(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060036CF RID: 14031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036CF")]
		[Address(RVA = "0x7D1AF0", Offset = "0x7D04F0", VA = "0x1807D1AF0")]
		private void RpcWriter___Observers_SetBetMultiplier_431000436(float multiplier)
		{
		}

		// Token: 0x060036D0 RID: 14032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D0")]
		[Address(RVA = "0x7D0FD0", Offset = "0x7CF9D0", VA = "0x1807D0FD0")]
		private void RpcLogic___SetBetMultiplier_431000436(float multiplier)
		{
		}

		// Token: 0x060036D1 RID: 14033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D1")]
		[Address(RVA = "0x7D13B0", Offset = "0x7CFDB0", VA = "0x1807D13B0")]
		private void RpcReader___Observers_SetBetMultiplier_431000436(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060036D2 RID: 14034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D2")]
		[Address(RVA = "0x7D1620", Offset = "0x7D0020", VA = "0x1807D1620")]
		private void RpcWriter___Observers_EndGame_2166136261()
		{
		}

		// Token: 0x060036D3 RID: 14035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D3")]
		[Address(RVA = "0x7D0B40", Offset = "0x7CF540", VA = "0x1807D0B40")]
		private void RpcLogic___EndGame_2166136261()
		{
		}

		// Token: 0x060036D4 RID: 14036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D4")]
		[Address(RVA = "0x7D1220", Offset = "0x7CFC20", VA = "0x1807D1220")]
		private void RpcReader___Observers_EndGame_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060036D5 RID: 14037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D5")]
		[Address(RVA = "0x7D1740", Offset = "0x7D0140", VA = "0x1807D1740")]
		private void RpcWriter___Observers_NotifyAnswer_431000436(float answerIndex)
		{
		}

		// Token: 0x060036D6 RID: 14038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D6")]
		[Address(RVA = "0x7D0B80", Offset = "0x7CF580", VA = "0x1807D0B80")]
		private void RpcLogic___NotifyAnswer_431000436(float answerIndex)
		{
		}

		// Token: 0x060036D7 RID: 14039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D7")]
		[Address(RVA = "0x7D1290", Offset = "0x7CFC90", VA = "0x1807D1290")]
		private void RpcReader___Observers_NotifyAnswer_431000436(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060036D8 RID: 14040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D8")]
		[Address(RVA = "0x7D1890", Offset = "0x7D0290", VA = "0x1807D1890")]
		private void RpcWriter___Observers_QuestionDone_2166136261()
		{
		}

		// Token: 0x060036D9 RID: 14041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D9")]
		[Address(RVA = "0x7D0D50", Offset = "0x7CF750", VA = "0x1807D0D50")]
		private void RpcLogic___QuestionDone_2166136261()
		{
		}

		// Token: 0x060036DA RID: 14042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036DA")]
		[Address(RVA = "0x7D1300", Offset = "0x7CFD00", VA = "0x1807D1300")]
		private void RpcReader___Observers_QuestionDone_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060036DB RID: 14043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036DB")]
		[Address(RVA = "0x7D14E0", Offset = "0x7CFEE0", VA = "0x1807D14E0")]
		private void RpcWriter___Observers_AddPlayerToCurrentRound_3323014238(NetworkObject player)
		{
		}

		// Token: 0x060036DC RID: 14044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036DC")]
		[Address(RVA = "0x7D0A60", Offset = "0x7CF460", VA = "0x1807D0A60")]
		private void RpcLogic___AddPlayerToCurrentRound_3323014238(NetworkObject player)
		{
		}

		// Token: 0x060036DD RID: 14045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036DD")]
		[Address(RVA = "0x7D11B0", Offset = "0x7CFBB0", VA = "0x1807D11B0")]
		private void RpcReader___Observers_AddPlayerToCurrentRound_3323014238(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060036DE RID: 14046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036DE")]
		[Address(RVA = "0x7D1D80", Offset = "0x7D0780", VA = "0x1807D1D80")]
		private void RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
		}

		// Token: 0x060036DF RID: 14047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036DF")]
		[Address(RVA = "0x7D0550", Offset = "0x7CEF50", VA = "0x1807D0550")]
		private void RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
		}

		// Token: 0x060036E0 RID: 14048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E0")]
		[Address(RVA = "0x7D1460", Offset = "0x7CFE60", VA = "0x1807D1460")]
		private void RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060036E1 RID: 14049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E1")]
		[Address(RVA = "0x7D19B0", Offset = "0x7D03B0", VA = "0x1807D19B0")]
		private void RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
		}

		// Token: 0x060036E2 RID: 14050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E2")]
		[Address(RVA = "0x7D0ED0", Offset = "0x7CF8D0", VA = "0x1807D0ED0")]
		private void RpcLogic___RemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
		}

		// Token: 0x060036E3 RID: 14051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E3")]
		[Address(RVA = "0x7D1340", Offset = "0x7CFD40", VA = "0x1807D1340")]
		private void RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060036E4 RID: 14052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E4")]
		[Address(RVA = "0x7CEB00", Offset = "0x7CD500", VA = "0x1807CEB00", Slot = "29")]
		protected virtual void Awake_UserLogic_ScheduleOne.Casino.RTBGameController_Assembly-CSharp.dll()
		{
		}

		// Token: 0x0400260D RID: 9741
		[Token(Token = "0x400260D")]
		public const int BET_MINIMUM = 10;

		// Token: 0x0400260E RID: 9742
		[Token(Token = "0x400260E")]
		public const int BET_MAXIMUM = 500;

		// Token: 0x0400260F RID: 9743
		[Token(Token = "0x400260F")]
		public const float ANSWER_MAX_TIME = 6f;

		// Token: 0x04002610 RID: 9744
		[Token(Token = "0x4002610")]
		[FieldOffset(Offset = "0x148")]
		[Header("References")]
		public Transform PlayCameraTransform;

		// Token: 0x04002611 RID: 9745
		[Token(Token = "0x4002611")]
		[FieldOffset(Offset = "0x150")]
		public Transform FocusedCameraTransform;

		// Token: 0x04002612 RID: 9746
		[Token(Token = "0x4002612")]
		[FieldOffset(Offset = "0x158")]
		public PlayingCard[] Cards;

		// Token: 0x04002613 RID: 9747
		[Token(Token = "0x4002613")]
		[FieldOffset(Offset = "0x160")]
		public Transform[] CardDefaultPositions;

		// Token: 0x04002614 RID: 9748
		[Token(Token = "0x4002614")]
		[FieldOffset(Offset = "0x168")]
		public Transform ActiveCardPosition;

		// Token: 0x04002615 RID: 9749
		[Token(Token = "0x4002615")]
		[FieldOffset(Offset = "0x170")]
		public Transform[] DockedCardPositions;

		// Token: 0x04002617 RID: 9751
		[Token(Token = "0x4002617")]
		[FieldOffset(Offset = "0x180")]
		public Action<RTBGameController.EStage> onStageChange;

		// Token: 0x04002618 RID: 9752
		[Token(Token = "0x4002618")]
		[FieldOffset(Offset = "0x188")]
		public Action<string, string[]> onQuestionReady;

		// Token: 0x04002619 RID: 9753
		[Token(Token = "0x4002619")]
		[FieldOffset(Offset = "0x190")]
		public Action onQuestionDone;

		// Token: 0x0400261A RID: 9754
		[Token(Token = "0x400261A")]
		[FieldOffset(Offset = "0x198")]
		public Action onLocalPlayerCorrect;

		// Token: 0x0400261B RID: 9755
		[Token(Token = "0x400261B")]
		[FieldOffset(Offset = "0x1A0")]
		public Action onLocalPlayerIncorrect;

		// Token: 0x0400261C RID: 9756
		[Token(Token = "0x400261C")]
		[FieldOffset(Offset = "0x1A8")]
		public Action onLocalPlayerBetChange;

		// Token: 0x0400261D RID: 9757
		[Token(Token = "0x400261D")]
		[FieldOffset(Offset = "0x1B0")]
		public Action onLocalPlayerExitRound;

		// Token: 0x04002622 RID: 9762
		[Token(Token = "0x4002622")]
		[FieldOffset(Offset = "0x1C8")]
		private List<Player> playersInCurrentRound;

		// Token: 0x04002623 RID: 9763
		[Token(Token = "0x4002623")]
		[FieldOffset(Offset = "0x1D0")]
		private List<PlayingCard.CardData> cardsInDeck;

		// Token: 0x04002624 RID: 9764
		[Token(Token = "0x4002624")]
		[FieldOffset(Offset = "0x1D8")]
		private List<PlayingCard.CardData> drawnCards;

		// Token: 0x04002625 RID: 9765
		[Token(Token = "0x4002625")]
		[FieldOffset(Offset = "0x1E0")]
		private bool NetworkInitialize___EarlyScheduleOne.Casino.RTBGameControllerAssembly-CSharp.dll_Excuted;

		// Token: 0x04002626 RID: 9766
		[Token(Token = "0x4002626")]
		[FieldOffset(Offset = "0x1E1")]
		private bool NetworkInitialize__LateScheduleOne.Casino.RTBGameControllerAssembly-CSharp.dll_Excuted;

		// Token: 0x020007E0 RID: 2016
		[Token(Token = "0x20007E0")]
		public enum EStage
		{
			// Token: 0x04002628 RID: 9768
			[Token(Token = "0x4002628")]
			WaitingForPlayers,
			// Token: 0x04002629 RID: 9769
			[Token(Token = "0x4002629")]
			RedOrBlack,
			// Token: 0x0400262A RID: 9770
			[Token(Token = "0x400262A")]
			HigherOrLower,
			// Token: 0x0400262B RID: 9771
			[Token(Token = "0x400262B")]
			InsideOrOutside,
			// Token: 0x0400262C RID: 9772
			[Token(Token = "0x400262C")]
			Suit
		}
	}
}
