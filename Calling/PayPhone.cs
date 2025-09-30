using System;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Interaction;
using ScheduleOne.Lighting;
using ScheduleOne.ScriptableObjects;
using UnityEngine;

namespace ScheduleOne.Calling
{
	// Token: 0x02000818 RID: 2072
	[Token(Token = "0x2000818")]
	public class PayPhone : MonoBehaviour
	{
		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06003922 RID: 14626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000818")]
		public PhoneCallData QueuedCall
		{
			[Token(Token = "0x6003922")]
			[Address(RVA = "0x80A370", Offset = "0x808D70", VA = "0x18080A370")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06003923 RID: 14627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000819")]
		public PhoneCallData ActiveCall
		{
			[Token(Token = "0x6003923")]
			[Address(RVA = "0x80A2F0", Offset = "0x808CF0", VA = "0x18080A2F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003924 RID: 14628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003924")]
		[Address(RVA = "0x809D70", Offset = "0x808770", VA = "0x180809D70")]
		public void FixedUpdate()
		{
		}

		// Token: 0x06003925 RID: 14629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003925")]
		[Address(RVA = "0x80A000", Offset = "0x808A00", VA = "0x18080A000")]
		public void Hovered()
		{
		}

		// Token: 0x06003926 RID: 14630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003926")]
		[Address(RVA = "0x80A080", Offset = "0x808A80", VA = "0x18080A080")]
		public void Interacted()
		{
		}

		// Token: 0x06003927 RID: 14631 RVA: 0x0000F540 File Offset: 0x0000D740
		[Token(Token = "0x6003927")]
		[Address(RVA = "0x809C90", Offset = "0x808690", VA = "0x180809C90")]
		private bool CanInteract()
		{
			return default(bool);
		}

		// Token: 0x06003928 RID: 14632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003928")]
		[Address(RVA = "0x80A2E0", Offset = "0x808CE0", VA = "0x18080A2E0")]
		public PayPhone()
		{
		}

		// Token: 0x0400279D RID: 10141
		[Token(Token = "0x400279D")]
		public const float RING_INTERVAL = 4f;

		// Token: 0x0400279E RID: 10142
		[Token(Token = "0x400279E")]
		public const float RING_RANGE = 9f;

		// Token: 0x0400279F RID: 10143
		[Token(Token = "0x400279F")]
		[FieldOffset(Offset = "0x20")]
		public BlinkingLight Light;

		// Token: 0x040027A0 RID: 10144
		[Token(Token = "0x40027A0")]
		[FieldOffset(Offset = "0x28")]
		public AudioSourceController RingSound;

		// Token: 0x040027A1 RID: 10145
		[Token(Token = "0x40027A1")]
		[FieldOffset(Offset = "0x30")]
		public AudioSourceController AnswerSound;

		// Token: 0x040027A2 RID: 10146
		[Token(Token = "0x40027A2")]
		[FieldOffset(Offset = "0x38")]
		public InteractableObject IntObj;

		// Token: 0x040027A3 RID: 10147
		[Token(Token = "0x40027A3")]
		[FieldOffset(Offset = "0x40")]
		public Transform CameraPosition;

		// Token: 0x040027A4 RID: 10148
		[Token(Token = "0x40027A4")]
		[FieldOffset(Offset = "0x48")]
		private float timeSinceLastRing;

		// Token: 0x040027A5 RID: 10149
		[Token(Token = "0x40027A5")]
		private const float ringRangeSquared = 81f;
	}
}
