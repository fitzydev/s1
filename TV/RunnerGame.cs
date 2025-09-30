using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.UI;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.TV
{
	// Token: 0x020002AD RID: 685
	[Token(Token = "0x20002AD")]
	public class RunnerGame : TVApp
	{
		// Token: 0x06000E41 RID: 3649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E41")]
		[Address(RVA = "0xABEBD0", Offset = "0xABD5D0", VA = "0x180ABEBD0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E42")]
		[Address(RVA = "0xABF0D0", Offset = "0xABDAD0", VA = "0x180ABF0D0", Slot = "5")]
		public override void Open()
		{
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E43")]
		[Address(RVA = "0xABF640", Offset = "0xABE040", VA = "0x180ABF640", Slot = "9")]
		protected override void TryPause()
		{
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E44")]
		[Address(RVA = "0xABF680", Offset = "0xABE080", VA = "0x180ABF680")]
		public void Update()
		{
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E45")]
		[Address(RVA = "0xABEFB0", Offset = "0xABD9B0", VA = "0x180ABEFB0")]
		private void Jump()
		{
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E46")]
		[Address(RVA = "0xABED30", Offset = "0xABD730", VA = "0x180ABED30")]
		private void CloudSpawned(GameObject cloud)
		{
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E47")]
		[Address(RVA = "0xABEFF0", Offset = "0xABD9F0", VA = "0x180ABEFF0")]
		private void ObstacleSpawned(GameObject obstacle)
		{
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E48")]
		[Address(RVA = "0xABF130", Offset = "0xABDB30", VA = "0x180ABF130")]
		private void RefreshHighScore()
		{
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E49")]
		[Address(RVA = "0xABF0F0", Offset = "0xABDAF0", VA = "0x180ABF0F0")]
		public void PlayerCollided()
		{
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E4A")]
		[Address(RVA = "0xABEE10", Offset = "0xABD810", VA = "0x180ABEE10")]
		private void EndGame()
		{
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E4B")]
		[Address(RVA = "0xABF5F0", Offset = "0xABDFF0", VA = "0x180ABF5F0")]
		private void StartGame()
		{
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E4C")]
		[Address(RVA = "0xABF220", Offset = "0xABDC20", VA = "0x180ABF220")]
		private void ResetGame()
		{
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E4D")]
		[Address(RVA = "0xABFEF0", Offset = "0xABE8F0", VA = "0x180ABFEF0")]
		public RunnerGame()
		{
		}

		// Token: 0x04000E80 RID: 3712
		[Token(Token = "0x4000E80")]
		[FieldOffset(Offset = "0x68")]
		public float GameSpeed;

		// Token: 0x04000E81 RID: 3713
		[Token(Token = "0x4000E81")]
		[FieldOffset(Offset = "0x6C")]
		public float MinGameSpeed;

		// Token: 0x04000E82 RID: 3714
		[Token(Token = "0x4000E82")]
		[FieldOffset(Offset = "0x70")]
		public float MaxGameSpeed;

		// Token: 0x04000E83 RID: 3715
		[Token(Token = "0x4000E83")]
		[FieldOffset(Offset = "0x74")]
		public float SpeedIncreaseRate;

		// Token: 0x04000E84 RID: 3716
		[Token(Token = "0x4000E84")]
		[FieldOffset(Offset = "0x78")]
		public int ScoreRate;

		// Token: 0x04000E85 RID: 3717
		[Token(Token = "0x4000E85")]
		[FieldOffset(Offset = "0x7C")]
		public float Gravity;

		// Token: 0x04000E86 RID: 3718
		[Token(Token = "0x4000E86")]
		[FieldOffset(Offset = "0x80")]
		public float JumpForce;

		// Token: 0x04000E87 RID: 3719
		[Token(Token = "0x4000E87")]
		[FieldOffset(Offset = "0x84")]
		public float GlobalForceMultiplier;

		// Token: 0x04000E88 RID: 3720
		[Token(Token = "0x4000E88")]
		[FieldOffset(Offset = "0x88")]
		public float DropForce;

		// Token: 0x04000E89 RID: 3721
		[Token(Token = "0x4000E89")]
		[FieldOffset(Offset = "0x90")]
		public RectTransform Character;

		// Token: 0x04000E8A RID: 3722
		[Token(Token = "0x4000E8A")]
		[FieldOffset(Offset = "0x98")]
		public Flipboard CharacterFlipboard;

		// Token: 0x04000E8B RID: 3723
		[Token(Token = "0x4000E8B")]
		[FieldOffset(Offset = "0xA0")]
		public SlidingRect Ground;

		// Token: 0x04000E8C RID: 3724
		[Token(Token = "0x4000E8C")]
		[FieldOffset(Offset = "0xA8")]
		public UISpawner CloudSpawner;

		// Token: 0x04000E8D RID: 3725
		[Token(Token = "0x4000E8D")]
		[FieldOffset(Offset = "0xB0")]
		public UISpawner ObstacleSpawner;

		// Token: 0x04000E8E RID: 3726
		[Token(Token = "0x4000E8E")]
		[FieldOffset(Offset = "0xB8")]
		public TextMeshProUGUI ScoreLabel;

		// Token: 0x04000E8F RID: 3727
		[Token(Token = "0x4000E8F")]
		[FieldOffset(Offset = "0xC0")]
		public TextMeshProUGUI HighScoreLabel;

		// Token: 0x04000E90 RID: 3728
		[Token(Token = "0x4000E90")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject StartScreen;

		// Token: 0x04000E91 RID: 3729
		[Token(Token = "0x4000E91")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject GameOverScreen;

		// Token: 0x04000E92 RID: 3730
		[Token(Token = "0x4000E92")]
		[FieldOffset(Offset = "0xD8")]
		public Animation NewHighScoreAnimation;

		// Token: 0x04000E93 RID: 3731
		[Token(Token = "0x4000E93")]
		[FieldOffset(Offset = "0xE0")]
		public Sprite JumpSprite;

		// Token: 0x04000E94 RID: 3732
		[Token(Token = "0x4000E94")]
		[FieldOffset(Offset = "0xE8")]
		private bool isJumping;

		// Token: 0x04000E95 RID: 3733
		[Token(Token = "0x4000E95")]
		[FieldOffset(Offset = "0xE9")]
		private bool isGrounded;

		// Token: 0x04000E96 RID: 3734
		[Token(Token = "0x4000E96")]
		[FieldOffset(Offset = "0xEA")]
		private bool isReady;

		// Token: 0x04000E97 RID: 3735
		[Token(Token = "0x4000E97")]
		[FieldOffset(Offset = "0xEC")]
		private float score;

		// Token: 0x04000E98 RID: 3736
		[Token(Token = "0x4000E98")]
		[FieldOffset(Offset = "0xF0")]
		private float yVelocity;

		// Token: 0x04000E99 RID: 3737
		[Token(Token = "0x4000E99")]
		[FieldOffset(Offset = "0xF4")]
		private float defaultCharacterY;

		// Token: 0x04000E9A RID: 3738
		[Token(Token = "0x4000E9A")]
		[FieldOffset(Offset = "0xF8")]
		private List<UIMover> clouds;

		// Token: 0x04000E9B RID: 3739
		[Token(Token = "0x4000E9B")]
		[FieldOffset(Offset = "0x100")]
		private List<UIMover> obstacles;

		// Token: 0x04000E9C RID: 3740
		[Token(Token = "0x4000E9C")]
		[FieldOffset(Offset = "0x108")]
		public UnityEvent onJump;

		// Token: 0x04000E9D RID: 3741
		[Token(Token = "0x4000E9D")]
		[FieldOffset(Offset = "0x110")]
		public UnityEvent onHit;

		// Token: 0x04000E9E RID: 3742
		[Token(Token = "0x4000E9E")]
		[FieldOffset(Offset = "0x118")]
		public UnityEvent onNewHighScore;
	}
}
