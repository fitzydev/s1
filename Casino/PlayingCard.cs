using System;
using System.Runtime.CompilerServices;
using EasyButtons;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.Casino
{
	// Token: 0x020007D7 RID: 2007
	[Token(Token = "0x20007D7")]
	public class PlayingCard : MonoBehaviour
	{
		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06003683 RID: 13955 RVA: 0x0000ECE8 File Offset: 0x0000CEE8
		// (set) Token: 0x06003684 RID: 13956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007D5")]
		public bool IsFaceUp
		{
			[Token(Token = "0x6003683")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003684")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x06003685 RID: 13957 RVA: 0x0000ED00 File Offset: 0x0000CF00
		// (set) Token: 0x06003686 RID: 13958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007D6")]
		public PlayingCard.ECardSuit Suit
		{
			[Token(Token = "0x6003685")]
			[Address(RVA = "0x47D5D0", Offset = "0x47BFD0", VA = "0x18047D5D0")]
			[CompilerGenerated]
			get
			{
				return PlayingCard.ECardSuit.Spades;
			}
			[Token(Token = "0x6003686")]
			[Address(RVA = "0x47D7A0", Offset = "0x47C1A0", VA = "0x18047D7A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06003687 RID: 13959 RVA: 0x0000ED18 File Offset: 0x0000CF18
		// (set) Token: 0x06003688 RID: 13960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007D7")]
		public PlayingCard.ECardValue Value
		{
			[Token(Token = "0x6003687")]
			[Address(RVA = "0x47D760", Offset = "0x47C160", VA = "0x18047D760")]
			[CompilerGenerated]
			get
			{
				return PlayingCard.ECardValue.Blank;
			}
			[Token(Token = "0x6003688")]
			[Address(RVA = "0x47D820", Offset = "0x47C220", VA = "0x18047D820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06003689 RID: 13961 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600368A RID: 13962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007D8")]
		public CardController CardController
		{
			[Token(Token = "0x6003689")]
			[Address(RVA = "0x4423A0", Offset = "0x440DA0", VA = "0x1804423A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600368A")]
			[Address(RVA = "0x4423D0", Offset = "0x440DD0", VA = "0x1804423D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600368B RID: 13963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600368B")]
		[Address(RVA = "0x7CDE30", Offset = "0x7CC830", VA = "0x1807CDE30")]
		private void OnValidate()
		{
		}

		// Token: 0x0600368C RID: 13964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600368C")]
		[Address(RVA = "0x4423D0", Offset = "0x440DD0", VA = "0x1804423D0")]
		public void SetCardController(CardController cardController)
		{
		}

		// Token: 0x0600368D RID: 13965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600368D")]
		[Address(RVA = "0x7CDEB0", Offset = "0x7CC8B0", VA = "0x1807CDEB0")]
		public void SetCard(PlayingCard.ECardSuit suit, PlayingCard.ECardValue value, bool network = true)
		{
		}

		// Token: 0x0600368E RID: 13966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600368E")]
		[Address(RVA = "0x7CD970", Offset = "0x7CC370", VA = "0x1807CD970")]
		public void ClearCard()
		{
		}

		// Token: 0x0600368F RID: 13967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600368F")]
		[Address(RVA = "0x7CE0C0", Offset = "0x7CCAC0", VA = "0x1807CE0C0")]
		public void SetFaceUp(bool faceUp, bool network = true)
		{
		}

		// Token: 0x06003690 RID: 13968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003690")]
		[Address(RVA = "0x7CDA70", Offset = "0x7CC470", VA = "0x1807CDA70")]
		public void GlideTo(Vector3 position, Quaternion rotation, float duration = 0.5f, bool network = true)
		{
		}

		// Token: 0x06003691 RID: 13969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003691")]
		[Address(RVA = "0x7CD990", Offset = "0x7CC390", VA = "0x1807CD990")]
		private PlayingCard.CardSprite GetCardSprite(PlayingCard.ECardSuit suit, PlayingCard.ECardValue val)
		{
			return null;
		}

		// Token: 0x06003692 RID: 13970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003692")]
		[Address(RVA = "0x7CE2E0", Offset = "0x7CCCE0", VA = "0x1807CE2E0")]
		[Button]
		public void VerifyCardSprites()
		{
		}

		// Token: 0x06003693 RID: 13971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003693")]
		[Address(RVA = "0x7CE7E0", Offset = "0x7CD1E0", VA = "0x1807CE7E0")]
		public PlayingCard()
		{
		}

		// Token: 0x040025DD RID: 9693
		[Token(Token = "0x40025DD")]
		[FieldOffset(Offset = "0x38")]
		public string CardID;

		// Token: 0x040025DE RID: 9694
		[Token(Token = "0x40025DE")]
		[FieldOffset(Offset = "0x40")]
		[Header("References")]
		public SpriteRenderer CardSpriteRenderer;

		// Token: 0x040025DF RID: 9695
		[Token(Token = "0x40025DF")]
		[FieldOffset(Offset = "0x48")]
		public PlayingCard.CardSprite[] CardSprites;

		// Token: 0x040025E0 RID: 9696
		[Token(Token = "0x40025E0")]
		[FieldOffset(Offset = "0x50")]
		public Animation FlipAnimation;

		// Token: 0x040025E1 RID: 9697
		[Token(Token = "0x40025E1")]
		[FieldOffset(Offset = "0x58")]
		public AnimationClip FlipFaceUpClip;

		// Token: 0x040025E2 RID: 9698
		[Token(Token = "0x40025E2")]
		[FieldOffset(Offset = "0x60")]
		public AnimationClip FlipFaceDownClip;

		// Token: 0x040025E3 RID: 9699
		[Token(Token = "0x40025E3")]
		[FieldOffset(Offset = "0x68")]
		[Header("Sound")]
		public AudioSourceController FlipSound;

		// Token: 0x040025E4 RID: 9700
		[Token(Token = "0x40025E4")]
		[FieldOffset(Offset = "0x70")]
		public AudioSourceController LandSound;

		// Token: 0x040025E5 RID: 9701
		[Token(Token = "0x40025E5")]
		[FieldOffset(Offset = "0x78")]
		private Coroutine moveRoutine;

		// Token: 0x040025E6 RID: 9702
		[Token(Token = "0x40025E6")]
		[FieldOffset(Offset = "0x80")]
		private Tuple<Vector3, Quaternion> lastGlideTarget;

		// Token: 0x020007D8 RID: 2008
		[Token(Token = "0x20007D8")]
		[Serializable]
		public class CardSprite
		{
			// Token: 0x06003694 RID: 13972 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003694")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public CardSprite()
			{
			}

			// Token: 0x040025E7 RID: 9703
			[Token(Token = "0x40025E7")]
			[FieldOffset(Offset = "0x10")]
			public PlayingCard.ECardSuit Suit;

			// Token: 0x040025E8 RID: 9704
			[Token(Token = "0x40025E8")]
			[FieldOffset(Offset = "0x14")]
			public PlayingCard.ECardValue Value;

			// Token: 0x040025E9 RID: 9705
			[Token(Token = "0x40025E9")]
			[FieldOffset(Offset = "0x18")]
			public Sprite Sprite;
		}

		// Token: 0x020007D9 RID: 2009
		[Token(Token = "0x20007D9")]
		public struct CardData
		{
			// Token: 0x06003695 RID: 13973 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003695")]
			[Address(RVA = "0x47BE70", Offset = "0x47A870", VA = "0x18047BE70")]
			public CardData(PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
			{
			}

			// Token: 0x040025EA RID: 9706
			[Token(Token = "0x40025EA")]
			[FieldOffset(Offset = "0x0")]
			public PlayingCard.ECardSuit Suit;

			// Token: 0x040025EB RID: 9707
			[Token(Token = "0x40025EB")]
			[FieldOffset(Offset = "0x4")]
			public PlayingCard.ECardValue Value;
		}

		// Token: 0x020007DA RID: 2010
		[Token(Token = "0x20007DA")]
		public enum ECardSuit
		{
			// Token: 0x040025ED RID: 9709
			[Token(Token = "0x40025ED")]
			Spades,
			// Token: 0x040025EE RID: 9710
			[Token(Token = "0x40025EE")]
			Hearts,
			// Token: 0x040025EF RID: 9711
			[Token(Token = "0x40025EF")]
			Diamonds,
			// Token: 0x040025F0 RID: 9712
			[Token(Token = "0x40025F0")]
			Clubs
		}

		// Token: 0x020007DB RID: 2011
		[Token(Token = "0x20007DB")]
		public enum ECardValue
		{
			// Token: 0x040025F2 RID: 9714
			[Token(Token = "0x40025F2")]
			Blank,
			// Token: 0x040025F3 RID: 9715
			[Token(Token = "0x40025F3")]
			Ace,
			// Token: 0x040025F4 RID: 9716
			[Token(Token = "0x40025F4")]
			Two,
			// Token: 0x040025F5 RID: 9717
			[Token(Token = "0x40025F5")]
			Three,
			// Token: 0x040025F6 RID: 9718
			[Token(Token = "0x40025F6")]
			Four,
			// Token: 0x040025F7 RID: 9719
			[Token(Token = "0x40025F7")]
			Five,
			// Token: 0x040025F8 RID: 9720
			[Token(Token = "0x40025F8")]
			Six,
			// Token: 0x040025F9 RID: 9721
			[Token(Token = "0x40025F9")]
			Seven,
			// Token: 0x040025FA RID: 9722
			[Token(Token = "0x40025FA")]
			Eight,
			// Token: 0x040025FB RID: 9723
			[Token(Token = "0x40025FB")]
			Nine,
			// Token: 0x040025FC RID: 9724
			[Token(Token = "0x40025FC")]
			Ten,
			// Token: 0x040025FD RID: 9725
			[Token(Token = "0x40025FD")]
			Jack,
			// Token: 0x040025FE RID: 9726
			[Token(Token = "0x40025FE")]
			Queen,
			// Token: 0x040025FF RID: 9727
			[Token(Token = "0x40025FF")]
			King
		}
	}
}
