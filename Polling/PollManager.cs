using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Steamworks;
using UnityEngine;

namespace ScheduleOne.Polling
{
	// Token: 0x02000343 RID: 835
	[Token(Token = "0x2000343")]
	public class PollManager : MonoBehaviour
	{
		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06001259 RID: 4697 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600125A RID: 4698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700037F")]
		public PollData ActivePoll
		{
			[Token(Token = "0x6001259")]
			[Address(RVA = "0x42FFC0", Offset = "0x42E9C0", VA = "0x18042FFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600125A")]
			[Address(RVA = "0x42FFF0", Offset = "0x42E9F0", VA = "0x18042FFF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x0600125B RID: 4699 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600125C RID: 4700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000380")]
		public PollData ConfirmedPoll
		{
			[Token(Token = "0x600125B")]
			[Address(RVA = "0x4423C0", Offset = "0x440DC0", VA = "0x1804423C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600125C")]
			[Address(RVA = "0x4423F0", Offset = "0x440DF0", VA = "0x1804423F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x0600125D RID: 4701 RVA: 0x00007E30 File Offset: 0x00006030
		// (set) Token: 0x0600125E RID: 4702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000381")]
		public PollManager.EPollSubmissionResult SubmissionResult
		{
			[Token(Token = "0x600125D")]
			[Address(RVA = "0x486270", Offset = "0x484C70", VA = "0x180486270")]
			[CompilerGenerated]
			get
			{
				return PollManager.EPollSubmissionResult.InProgress;
			}
			[Token(Token = "0x600125E")]
			[Address(RVA = "0x487600", Offset = "0x486000", VA = "0x180487600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x0600125F RID: 4703 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001260 RID: 4704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000382")]
		public string SubmisssionFailedMesssage
		{
			[Token(Token = "0x600125F")]
			[Address(RVA = "0x4423B0", Offset = "0x440DB0", VA = "0x1804423B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001260")]
			[Address(RVA = "0x4423E0", Offset = "0x440DE0", VA = "0x1804423E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001261")]
		[Address(RVA = "0x59AB60", Offset = "0x599560", VA = "0x18059AB60")]
		private void Start()
		{
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001262")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80")]
		private void Update()
		{
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001263")]
		[Address(RVA = "0x599EE0", Offset = "0x5988E0", VA = "0x180599EE0")]
		public void GenerateAppTicket()
		{
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001264")]
		[Address(RVA = "0x59A9A0", Offset = "0x5993A0", VA = "0x18059A9A0")]
		public void SelectPollResponse(int responseIndex)
		{
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001265")]
		[Address(RVA = "0x59A140", Offset = "0x598B40", VA = "0x18059A140")]
		private Task InitAppTicket()
		{
			return null;
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001266")]
		[Address(RVA = "0x59AC70", Offset = "0x599670", VA = "0x18059AC70")]
		private IEnumerator SubmitAnswerToServer(PollAnswer answer)
		{
			return null;
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001267")]
		[Address(RVA = "0x59A450", Offset = "0x598E50", VA = "0x18059A450")]
		private IEnumerator RequestPoll(string url, [Optional] Action<string> callback)
		{
			return null;
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001268")]
		[Address(RVA = "0x59A4E0", Offset = "0x598EE0", VA = "0x18059A4E0")]
		private void ResponseCallback(string data)
		{
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001269")]
		[Address(RVA = "0x59A210", Offset = "0x598C10", VA = "0x18059A210")]
		private void OnEncryptedAppTicketResponse(EncryptedAppTicketResponse_t response, bool ioFailure)
		{
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600126A")]
		[Address(RVA = "0x59A020", Offset = "0x598A20", VA = "0x18059A020")]
		private Task<string> GetAppTicket()
		{
			return null;
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600126B")]
		[Address(RVA = "0x599E80", Offset = "0x598880", VA = "0x180599E80")]
		private static string CleanTicket(string ticket)
		{
			return null;
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x00007E48 File Offset: 0x00006048
		[Token(Token = "0x600126C")]
		[Address(RVA = "0x59AD00", Offset = "0x599700", VA = "0x18059AD00")]
		public static bool TryGetExistingPollResponse(int pollId, out int response)
		{
			return default(bool);
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600126D")]
		[Address(RVA = "0x59A3A0", Offset = "0x598DA0", VA = "0x18059A3A0")]
		private static void RecordSubmission(int pollId, int response)
		{
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600126E")]
		[Address(RVA = "0x59ADF0", Offset = "0x5997F0", VA = "0x18059ADF0")]
		public PollManager()
		{
		}

		// Token: 0x04001182 RID: 4482
		[Token(Token = "0x4001182")]
		public const string SERVER_URL = "https://us-central1-s1-polling-987345.cloudfunctions.net/poll";

		// Token: 0x04001187 RID: 4487
		[Token(Token = "0x4001187")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CallResult<EncryptedAppTicketResponse_t> appTicketCallbackResponse;

		// Token: 0x04001188 RID: 4488
		[Token(Token = "0x4001188")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskCompletionSource<string> tokenCompletion;

		// Token: 0x04001189 RID: 4489
		[Token(Token = "0x4001189")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private PollResponse receivedPollResponse;

		// Token: 0x0400118A RID: 4490
		[Token(Token = "0x400118A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int sentResponse;

		// Token: 0x0400118B RID: 4491
		[Token(Token = "0x400118B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string appTicket;

		// Token: 0x0400118C RID: 4492
		[Token(Token = "0x400118C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Action<PollData> onActivePollReceived;

		// Token: 0x0400118D RID: 4493
		[Token(Token = "0x400118D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Action<PollData> onConfirmedPollReceived;

		// Token: 0x0400118E RID: 4494
		[Token(Token = "0x400118E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool appTicketRequested;

		// Token: 0x02000344 RID: 836
		[Token(Token = "0x2000344")]
		public enum EPollSubmissionResult
		{
			// Token: 0x04001190 RID: 4496
			[Token(Token = "0x4001190")]
			InProgress,
			// Token: 0x04001191 RID: 4497
			[Token(Token = "0x4001191")]
			Success,
			// Token: 0x04001192 RID: 4498
			[Token(Token = "0x4001192")]
			Failed
		}
	}
}
