using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EasyButtons;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.TV
{
	// Token: 0x020002AF RID: 687
	[Token(Token = "0x20002AF")]
	public class Snake : TVApp
	{
		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000E50 RID: 3664 RVA: 0x00007188 File Offset: 0x00005388
		// (set) Token: 0x06000E51 RID: 3665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000311")]
		public Vector2 HeadPosition
		{
			[Token(Token = "0x6000E50")]
			[Address(RVA = "0x7BA9A0", Offset = "0x7B93A0", VA = "0x1807BA9A0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000E51")]
			[Address(RVA = "0xAC6410", Offset = "0xAC4E10", VA = "0x180AC6410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000E52 RID: 3666 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000E53 RID: 3667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000312")]
		public List<Vector2> Tail
		{
			[Token(Token = "0x6000E52")]
			[Address(RVA = "0x5904C0", Offset = "0x58EEC0", VA = "0x1805904C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E53")]
			[Address(RVA = "0x5904E0", Offset = "0x58EEE0", VA = "0x1805904E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000E54 RID: 3668 RVA: 0x000071A0 File Offset: 0x000053A0
		// (set) Token: 0x06000E55 RID: 3669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000313")]
		public Vector2 LastTailPosition
		{
			[Token(Token = "0x6000E54")]
			[Address(RVA = "0xAC63A0", Offset = "0xAC4DA0", VA = "0x180AC63A0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000E55")]
			[Address(RVA = "0xAC6420", Offset = "0xAC4E20", VA = "0x180AC6420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000E56 RID: 3670 RVA: 0x000071B8 File Offset: 0x000053B8
		// (set) Token: 0x06000E57 RID: 3671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000314")]
		public Vector2 Direction
		{
			[Token(Token = "0x6000E56")]
			[Address(RVA = "0xAC6380", Offset = "0xAC4D80", VA = "0x180AC6380")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000E57")]
			[Address(RVA = "0xAC6400", Offset = "0xAC4E00", VA = "0x180AC6400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x000071D0 File Offset: 0x000053D0
		// (set) Token: 0x06000E59 RID: 3673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000315")]
		public Vector2 QueuedDirection
		{
			[Token(Token = "0x6000E58")]
			[Address(RVA = "0xAC63E0", Offset = "0xAC4DE0", VA = "0x180AC63E0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000E59")]
			[Address(RVA = "0xAC6440", Offset = "0xAC4E40", VA = "0x180AC6440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000E5A RID: 3674 RVA: 0x000071E8 File Offset: 0x000053E8
		// (set) Token: 0x06000E5B RID: 3675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000316")]
		public Vector2 NextDirection
		{
			[Token(Token = "0x6000E5A")]
			[Address(RVA = "0xAC63C0", Offset = "0xAC4DC0", VA = "0x180AC63C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000E5B")]
			[Address(RVA = "0xAC6430", Offset = "0xAC4E30", VA = "0x180AC6430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000E5C RID: 3676 RVA: 0x00007200 File Offset: 0x00005400
		// (set) Token: 0x06000E5D RID: 3677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000317")]
		public Snake.EGameState GameState
		{
			[Token(Token = "0x6000E5C")]
			[Address(RVA = "0x5178E0", Offset = "0x5162E0", VA = "0x1805178E0")]
			[CompilerGenerated]
			get
			{
				return Snake.EGameState.Ready;
			}
			[Token(Token = "0x6000E5D")]
			[Address(RVA = "0x517A90", Offset = "0x516490", VA = "0x180517A90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E5E")]
		[Address(RVA = "0xAC4BA0", Offset = "0xAC35A0", VA = "0x180AC4BA0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E5F")]
		[Address(RVA = "0xAC6040", Offset = "0xAC4A40", VA = "0x180AC6040")]
		private void Update()
		{
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E60")]
		[Address(RVA = "0xAC5B40", Offset = "0xAC4540", VA = "0x180AC5B40")]
		private void UpdateInput()
		{
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E61")]
		[Address(RVA = "0xAC5FE0", Offset = "0xAC49E0", VA = "0x180AC5FE0")]
		private void UpdateMovement()
		{
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E62")]
		[Address(RVA = "0xAC4FB0", Offset = "0xAC39B0", VA = "0x180AC4FB0")]
		private void MoveSnake()
		{
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E63")]
		[Address(RVA = "0xAC4F30", Offset = "0xAC3930", VA = "0x180AC4F30")]
		private SnakeTile GetTile(Vector2 position)
		{
			return null;
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E64")]
		[Address(RVA = "0xAC57E0", Offset = "0xAC41E0", VA = "0x180AC57E0")]
		private void StartGame(Vector2 initialDir)
		{
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E65")]
		[Address(RVA = "0xAC4E30", Offset = "0xAC3830", VA = "0x180AC4E30")]
		private void Eat()
		{
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E66")]
		[Address(RVA = "0xAC5600", Offset = "0xAC4000", VA = "0x180AC5600")]
		private void SpawnFood()
		{
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E67")]
		[Address(RVA = "0xAC4F00", Offset = "0xAC3900", VA = "0x180AC4F00")]
		private void GameOver()
		{
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E68")]
		[Address(RVA = "0xAC6150", Offset = "0xAC4B50", VA = "0x180AC6150")]
		private void Win()
		{
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E69")]
		[Address(RVA = "0xAC5B00", Offset = "0xAC4500", VA = "0x180AC5B00", Slot = "9")]
		protected override void TryPause()
		{
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E6A")]
		[Address(RVA = "0xAC4BB0", Offset = "0xAC35B0", VA = "0x180AC4BB0")]
		[Button]
		public void CreateTiles()
		{
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E6B")]
		[Address(RVA = "0xAC6180", Offset = "0xAC4B80", VA = "0x180AC6180")]
		public Snake()
		{
		}

		// Token: 0x04000EA1 RID: 3745
		[Token(Token = "0x4000EA1")]
		public const int SIZE_X = 20;

		// Token: 0x04000EA2 RID: 3746
		[Token(Token = "0x4000EA2")]
		public const int SIZE_Y = 12;

		// Token: 0x04000EA3 RID: 3747
		[Token(Token = "0x4000EA3")]
		[FieldOffset(Offset = "0x68")]
		[Header("Settings")]
		public SnakeTile TilePrefab;

		// Token: 0x04000EA4 RID: 3748
		[Token(Token = "0x4000EA4")]
		[FieldOffset(Offset = "0x70")]
		public float TimePerTile;

		// Token: 0x04000EA5 RID: 3749
		[Token(Token = "0x4000EA5")]
		[FieldOffset(Offset = "0x78")]
		[Header("References")]
		public RectTransform PlaySpace;

		// Token: 0x04000EA6 RID: 3750
		[Token(Token = "0x4000EA6")]
		[FieldOffset(Offset = "0x80")]
		public SnakeTile[] Tiles;

		// Token: 0x04000EA7 RID: 3751
		[Token(Token = "0x4000EA7")]
		[FieldOffset(Offset = "0x88")]
		public TextMeshProUGUI ScoreText;

		// Token: 0x04000EAE RID: 3758
		[Token(Token = "0x4000EAE")]
		[FieldOffset(Offset = "0xC0")]
		private Vector2 lastFoodPosition;

		// Token: 0x04000EB0 RID: 3760
		[Token(Token = "0x4000EB0")]
		[FieldOffset(Offset = "0xCC")]
		private float _timeSinceLastMove;

		// Token: 0x04000EB1 RID: 3761
		[Token(Token = "0x4000EB1")]
		[FieldOffset(Offset = "0xD0")]
		private float _timeOnGameOver;

		// Token: 0x04000EB2 RID: 3762
		[Token(Token = "0x4000EB2")]
		[FieldOffset(Offset = "0xD8")]
		public UnityEvent onStart;

		// Token: 0x04000EB3 RID: 3763
		[Token(Token = "0x4000EB3")]
		[FieldOffset(Offset = "0xE0")]
		public UnityEvent onEat;

		// Token: 0x04000EB4 RID: 3764
		[Token(Token = "0x4000EB4")]
		[FieldOffset(Offset = "0xE8")]
		public UnityEvent onGameOver;

		// Token: 0x04000EB5 RID: 3765
		[Token(Token = "0x4000EB5")]
		[FieldOffset(Offset = "0xF0")]
		public UnityEvent onWin;

		// Token: 0x020002B0 RID: 688
		[Token(Token = "0x20002B0")]
		public enum EGameState
		{
			// Token: 0x04000EB7 RID: 3767
			[Token(Token = "0x4000EB7")]
			Ready,
			// Token: 0x04000EB8 RID: 3768
			[Token(Token = "0x4000EB8")]
			Playing
		}
	}
}
