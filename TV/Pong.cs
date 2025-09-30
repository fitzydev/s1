using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.TV
{
	// Token: 0x020002A7 RID: 679
	[Token(Token = "0x20002A7")]
	public class Pong : TVApp
	{
		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000E23 RID: 3619 RVA: 0x00007110 File Offset: 0x00005310
		// (set) Token: 0x06000E24 RID: 3620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700030C")]
		public Pong.EGameMode GameMode
		{
			[Token(Token = "0x6000E23")]
			[Address(RVA = "0x4873C0", Offset = "0x485DC0", VA = "0x1804873C0")]
			[CompilerGenerated]
			get
			{
				return Pong.EGameMode.SinglePlayer;
			}
			[Token(Token = "0x6000E24")]
			[Address(RVA = "0x4874F0", Offset = "0x485EF0", VA = "0x1804874F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000E25 RID: 3621 RVA: 0x00007128 File Offset: 0x00005328
		// (set) Token: 0x06000E26 RID: 3622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700030D")]
		public Pong.EState State
		{
			[Token(Token = "0x6000E25")]
			[Address(RVA = "0xABE810", Offset = "0xABD210", VA = "0x180ABE810")]
			[CompilerGenerated]
			get
			{
				return Pong.EState.Ready;
			}
			[Token(Token = "0x6000E26")]
			[Address(RVA = "0xABE830", Offset = "0xABD230", VA = "0x180ABE830")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000E27 RID: 3623 RVA: 0x00007140 File Offset: 0x00005340
		// (set) Token: 0x06000E28 RID: 3624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700030E")]
		public int LeftScore
		{
			[Token(Token = "0x6000E27")]
			[Address(RVA = "0x526820", Offset = "0x525220", VA = "0x180526820")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000E28")]
			[Address(RVA = "0x65E700", Offset = "0x65D100", VA = "0x18065E700")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000E29 RID: 3625 RVA: 0x00007158 File Offset: 0x00005358
		// (set) Token: 0x06000E2A RID: 3626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700030F")]
		public int RightScore
		{
			[Token(Token = "0x6000E29")]
			[Address(RVA = "0xABE800", Offset = "0xABD200", VA = "0x180ABE800")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000E2A")]
			[Address(RVA = "0xABE820", Offset = "0xABD220", VA = "0x180ABE820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E2B")]
		[Address(RVA = "0xABE540", Offset = "0xABCF40", VA = "0x180ABE540")]
		private void Update()
		{
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E2C")]
		[Address(RVA = "0xABD610", Offset = "0xABC010", VA = "0x180ABD610")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E2D")]
		[Address(RVA = "0xABDF40", Offset = "0xABC940", VA = "0x180ABDF40", Slot = "9")]
		protected override void TryPause()
		{
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E2E")]
		[Address(RVA = "0xABE160", Offset = "0xABCB60", VA = "0x180ABE160")]
		public void UpdateInputs()
		{
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E2F")]
		[Address(RVA = "0xABDFB0", Offset = "0xABC9B0", VA = "0x180ABDFB0")]
		private void UpdateAI()
		{
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E30")]
		[Address(RVA = "0xABD8C0", Offset = "0xABC2C0", VA = "0x180ABD8C0")]
		public void GoalHit(Pong.ESide side)
		{
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E31")]
		[Address(RVA = "0xABE580", Offset = "0xABCF80", VA = "0x180ABE580")]
		private void Win(Pong.ESide winner)
		{
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E32")]
		[Address(RVA = "0xABDA70", Offset = "0xABC470", VA = "0x180ABDA70")]
		private void ResetBall()
		{
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E33")]
		[Address(RVA = "0xABDDF0", Offset = "0xABC7F0", VA = "0x180ABDDF0")]
		private void ServeBall()
		{
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E34")]
		[Address(RVA = "0xABDC70", Offset = "0xABC670", VA = "0x180ABDC70")]
		private void ResetGame()
		{
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E35")]
		[Address(RVA = "0xABDF10", Offset = "0xABC910", VA = "0x180ABDF10")]
		public void SetPaddleTargetY(Pong.ESide player, float y)
		{
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E36")]
		[Address(RVA = "0xABDD80", Offset = "0xABC780", VA = "0x180ABDD80", Slot = "7")]
		public override void Resume()
		{
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E37")]
		[Address(RVA = "0xABE750", Offset = "0xABD150", VA = "0x180ABE750")]
		public Pong()
		{
		}

		// Token: 0x04000E55 RID: 3669
		[Token(Token = "0x4000E55")]
		[FieldOffset(Offset = "0x78")]
		public RectTransform Rect;

		// Token: 0x04000E56 RID: 3670
		[Token(Token = "0x4000E56")]
		[FieldOffset(Offset = "0x80")]
		public PongPaddle LeftPaddle;

		// Token: 0x04000E57 RID: 3671
		[Token(Token = "0x4000E57")]
		[FieldOffset(Offset = "0x88")]
		public PongPaddle RightPaddle;

		// Token: 0x04000E58 RID: 3672
		[Token(Token = "0x4000E58")]
		[FieldOffset(Offset = "0x90")]
		public PongBall Ball;

		// Token: 0x04000E59 RID: 3673
		[Token(Token = "0x4000E59")]
		[FieldOffset(Offset = "0x98")]
		public TextMeshProUGUI LeftScoreLabel;

		// Token: 0x04000E5A RID: 3674
		[Token(Token = "0x4000E5A")]
		[FieldOffset(Offset = "0xA0")]
		public TextMeshProUGUI RightScoreLabel;

		// Token: 0x04000E5B RID: 3675
		[Token(Token = "0x4000E5B")]
		[FieldOffset(Offset = "0xA8")]
		public TextMeshProUGUI WinnerLabel;

		// Token: 0x04000E5C RID: 3676
		[Token(Token = "0x4000E5C")]
		[FieldOffset(Offset = "0xB0")]
		[Header("Settings")]
		public float InitialVelocity;

		// Token: 0x04000E5D RID: 3677
		[Token(Token = "0x4000E5D")]
		[FieldOffset(Offset = "0xB4")]
		public float VelocityGainPerSecond;

		// Token: 0x04000E5E RID: 3678
		[Token(Token = "0x4000E5E")]
		[FieldOffset(Offset = "0xB8")]
		public float MaxVelocity;

		// Token: 0x04000E5F RID: 3679
		[Token(Token = "0x4000E5F")]
		[FieldOffset(Offset = "0xBC")]
		public int GoalsToWin;

		// Token: 0x04000E60 RID: 3680
		[Token(Token = "0x4000E60")]
		[FieldOffset(Offset = "0xC0")]
		[Header("AI")]
		public float ReactionTime;

		// Token: 0x04000E61 RID: 3681
		[Token(Token = "0x4000E61")]
		[FieldOffset(Offset = "0xC4")]
		public float TargetRandomization;

		// Token: 0x04000E62 RID: 3682
		[Token(Token = "0x4000E62")]
		[FieldOffset(Offset = "0xC8")]
		public float SpeedMultiplier;

		// Token: 0x04000E63 RID: 3683
		[Token(Token = "0x4000E63")]
		[FieldOffset(Offset = "0xD0")]
		public UnityEvent onServe;

		// Token: 0x04000E64 RID: 3684
		[Token(Token = "0x4000E64")]
		[FieldOffset(Offset = "0xD8")]
		public UnityEvent onLeftScore;

		// Token: 0x04000E65 RID: 3685
		[Token(Token = "0x4000E65")]
		[FieldOffset(Offset = "0xE0")]
		public UnityEvent onRightScore;

		// Token: 0x04000E66 RID: 3686
		[Token(Token = "0x4000E66")]
		[FieldOffset(Offset = "0xE8")]
		public UnityEvent onGameOver;

		// Token: 0x04000E67 RID: 3687
		[Token(Token = "0x4000E67")]
		[FieldOffset(Offset = "0xF0")]
		public UnityEvent onLocalPlayerWin;

		// Token: 0x04000E68 RID: 3688
		[Token(Token = "0x4000E68")]
		[FieldOffset(Offset = "0xF8")]
		public UnityEvent onReset;

		// Token: 0x04000E69 RID: 3689
		[Token(Token = "0x4000E69")]
		[FieldOffset(Offset = "0x100")]
		private Pong.ESide nextBallSide;

		// Token: 0x04000E6A RID: 3690
		[Token(Token = "0x4000E6A")]
		[FieldOffset(Offset = "0x104")]
		private Vector3 ballVelocity;

		// Token: 0x04000E6B RID: 3691
		[Token(Token = "0x4000E6B")]
		[FieldOffset(Offset = "0x110")]
		private float reactionTimer;

		// Token: 0x020002A8 RID: 680
		[Token(Token = "0x20002A8")]
		public enum EGameMode
		{
			// Token: 0x04000E6D RID: 3693
			[Token(Token = "0x4000E6D")]
			SinglePlayer,
			// Token: 0x04000E6E RID: 3694
			[Token(Token = "0x4000E6E")]
			MultiPlayer
		}

		// Token: 0x020002A9 RID: 681
		[Token(Token = "0x20002A9")]
		public enum ESide
		{
			// Token: 0x04000E70 RID: 3696
			[Token(Token = "0x4000E70")]
			Left,
			// Token: 0x04000E71 RID: 3697
			[Token(Token = "0x4000E71")]
			Right
		}

		// Token: 0x020002AA RID: 682
		[Token(Token = "0x20002AA")]
		public enum EState
		{
			// Token: 0x04000E73 RID: 3699
			[Token(Token = "0x4000E73")]
			Ready,
			// Token: 0x04000E74 RID: 3700
			[Token(Token = "0x4000E74")]
			Playing,
			// Token: 0x04000E75 RID: 3701
			[Token(Token = "0x4000E75")]
			GameOver
		}
	}
}
