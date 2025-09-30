using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Casino
{
	// Token: 0x020007EA RID: 2026
	[Token(Token = "0x20007EA")]
	public class SlotReel : MonoBehaviour
	{
		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06003729 RID: 14121 RVA: 0x0000EFE8 File Offset: 0x0000D1E8
		// (set) Token: 0x0600372A RID: 14122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007EA")]
		public bool IsSpinning
		{
			[Token(Token = "0x6003729")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600372A")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x0600372B RID: 14123 RVA: 0x0000F000 File Offset: 0x0000D200
		// (set) Token: 0x0600372C RID: 14124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007EB")]
		public SlotMachine.ESymbol CurrentSymbol
		{
			[Token(Token = "0x600372B")]
			[Address(RVA = "0x47D5D0", Offset = "0x47BFD0", VA = "0x18047D5D0")]
			[CompilerGenerated]
			get
			{
				return SlotMachine.ESymbol.Cherry;
			}
			[Token(Token = "0x600372C")]
			[Address(RVA = "0x47D7A0", Offset = "0x47C1A0", VA = "0x18047D7A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x0600372D RID: 14125 RVA: 0x0000F018 File Offset: 0x0000D218
		// (set) Token: 0x0600372E RID: 14126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007EC")]
		public float CurrentRotation
		{
			[Token(Token = "0x600372D")]
			[Address(RVA = "0x485C70", Offset = "0x484670", VA = "0x180485C70")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600372E")]
			[Address(RVA = "0x485CB0", Offset = "0x4846B0", VA = "0x180485CB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600372F RID: 14127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600372F")]
		[Address(RVA = "0x7EFA30", Offset = "0x7EE430", VA = "0x1807EFA30")]
		private void Awake()
		{
		}

		// Token: 0x06003730 RID: 14128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003730")]
		[Address(RVA = "0x7EFCA0", Offset = "0x7EE6A0", VA = "0x1807EFCA0")]
		private void Update()
		{
		}

		// Token: 0x06003731 RID: 14129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003731")]
		[Address(RVA = "0x7EFC30", Offset = "0x7EE630", VA = "0x1807EFC30")]
		public void Spin()
		{
		}

		// Token: 0x06003732 RID: 14130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003732")]
		[Address(RVA = "0x7EFC50", Offset = "0x7EE650", VA = "0x1807EFC50")]
		public void Stop(SlotMachine.ESymbol endSymbol)
		{
		}

		// Token: 0x06003733 RID: 14131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003733")]
		[Address(RVA = "0x47D7A0", Offset = "0x47C1A0", VA = "0x18047D7A0")]
		public void SetSymbol(SlotMachine.ESymbol symbol)
		{
		}

		// Token: 0x06003734 RID: 14132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003734")]
		[Address(RVA = "0x7EFB90", Offset = "0x7EE590", VA = "0x1807EFB90")]
		private void SetReelRotation(float rotation)
		{
		}

		// Token: 0x06003735 RID: 14133 RVA: 0x0000F030 File Offset: 0x0000D230
		[Token(Token = "0x6003735")]
		[Address(RVA = "0x7EFA80", Offset = "0x7EE480", VA = "0x1807EFA80")]
		private float GetSymbolRotation(SlotMachine.ESymbol symbol)
		{
			return 0f;
		}

		// Token: 0x06003736 RID: 14134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003736")]
		[Address(RVA = "0x7EFE00", Offset = "0x7EE800", VA = "0x1807EFE00")]
		public SlotReel()
		{
		}

		// Token: 0x0400266A RID: 9834
		[Token(Token = "0x400266A")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public SlotReel.SymbolRotation[] SymbolRotations;

		// Token: 0x0400266B RID: 9835
		[Token(Token = "0x400266B")]
		[FieldOffset(Offset = "0x38")]
		public float SpinSpeed;

		// Token: 0x0400266C RID: 9836
		[Token(Token = "0x400266C")]
		[FieldOffset(Offset = "0x40")]
		[Header("References")]
		public AudioSourceController StopSound;

		// Token: 0x0400266D RID: 9837
		[Token(Token = "0x400266D")]
		[FieldOffset(Offset = "0x48")]
		public UnityEvent onStart;

		// Token: 0x0400266E RID: 9838
		[Token(Token = "0x400266E")]
		[FieldOffset(Offset = "0x50")]
		public UnityEvent onStop;

		// Token: 0x020007EB RID: 2027
		[Token(Token = "0x20007EB")]
		[Serializable]
		public class SymbolRotation
		{
			// Token: 0x06003737 RID: 14135 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003737")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public SymbolRotation()
			{
			}

			// Token: 0x0400266F RID: 9839
			[Token(Token = "0x400266F")]
			[FieldOffset(Offset = "0x10")]
			public SlotMachine.ESymbol Symbol;

			// Token: 0x04002670 RID: 9840
			[Token(Token = "0x4002670")]
			[FieldOffset(Offset = "0x14")]
			public float Rotation;
		}
	}
}
