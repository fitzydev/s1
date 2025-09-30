using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000C9D RID: 3229
	[Token(Token = "0x2000C9D")]
	public class BunsenBurner : MonoBehaviour
	{
		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x06005889 RID: 22665 RVA: 0x00015CC0 File Offset: 0x00013EC0
		// (set) Token: 0x0600588A RID: 22666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C42")]
		public bool Interactable
		{
			[Token(Token = "0x6005889")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600588A")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x0600588B RID: 22667 RVA: 0x00015CD8 File Offset: 0x00013ED8
		// (set) Token: 0x0600588C RID: 22668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C43")]
		public bool IsDialHeld
		{
			[Token(Token = "0x600588B")]
			[Address(RVA = "0x570DF0", Offset = "0x56F7F0", VA = "0x180570DF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600588C")]
			[Address(RVA = "0x570E40", Offset = "0x56F840", VA = "0x180570E40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x0600588D RID: 22669 RVA: 0x00015CF0 File Offset: 0x00013EF0
		// (set) Token: 0x0600588E RID: 22670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C44")]
		public float CurrentDialValue
		{
			[Token(Token = "0x600588D")]
			[Address(RVA = "0x485C90", Offset = "0x484690", VA = "0x180485C90")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600588E")]
			[Address(RVA = "0x485CD0", Offset = "0x4846D0", VA = "0x180485CD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x0600588F RID: 22671 RVA: 0x00015D08 File Offset: 0x00013F08
		// (set) Token: 0x06005890 RID: 22672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C45")]
		public float CurrentHeat
		{
			[Token(Token = "0x600588F")]
			[Address(RVA = "0x485C70", Offset = "0x484670", VA = "0x180485C70")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6005890")]
			[Address(RVA = "0x485CB0", Offset = "0x4846B0", VA = "0x180485CB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005891 RID: 22673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005891")]
		[Address(RVA = "0xA0B600", Offset = "0xA0A000", VA = "0x180A0B600")]
		private void Start()
		{
		}

		// Token: 0x06005892 RID: 22674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005892")]
		[Address(RVA = "0xA0B8D0", Offset = "0xA0A2D0", VA = "0x180A0B8D0")]
		private void Update()
		{
		}

		// Token: 0x06005893 RID: 22675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005893")]
		[Address(RVA = "0xA0B750", Offset = "0xA0A150", VA = "0x180A0B750")]
		private void UpdateEffects()
		{
		}

		// Token: 0x06005894 RID: 22676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005894")]
		[Address(RVA = "0xA0B4D0", Offset = "0xA09ED0", VA = "0x180A0B4D0")]
		public void SetDialPosition(float pos)
		{
		}

		// Token: 0x06005895 RID: 22677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005895")]
		[Address(RVA = "0xA0B5B0", Offset = "0xA09FB0", VA = "0x180A0B5B0")]
		public void SetInteractable(bool e)
		{
		}

		// Token: 0x06005896 RID: 22678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005896")]
		[Address(RVA = "0x81D8C0", Offset = "0x81C2C0", VA = "0x18081D8C0")]
		public void ClickStart(RaycastHit hit)
		{
		}

		// Token: 0x06005897 RID: 22679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005897")]
		[Address(RVA = "0x81D8B0", Offset = "0x81C2B0", VA = "0x18081D8B0")]
		public void ClickEnd()
		{
		}

		// Token: 0x06005898 RID: 22680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005898")]
		[Address(RVA = "0xA0BB40", Offset = "0xA0A540", VA = "0x180A0BB40")]
		public BunsenBurner()
		{
		}

		// Token: 0x0400413C RID: 16700
		[Token(Token = "0x400413C")]
		[FieldOffset(Offset = "0x2C")]
		public bool LockDial;

		// Token: 0x0400413D RID: 16701
		[Token(Token = "0x400413D")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public Gradient FlameColor;

		// Token: 0x0400413E RID: 16702
		[Token(Token = "0x400413E")]
		[FieldOffset(Offset = "0x38")]
		public AnimationCurve LightIntensity;

		// Token: 0x0400413F RID: 16703
		[Token(Token = "0x400413F")]
		[FieldOffset(Offset = "0x40")]
		public float HandleRotationSpeed;

		// Token: 0x04004140 RID: 16704
		[Token(Token = "0x4004140")]
		[FieldOffset(Offset = "0x48")]
		public AnimationCurve FlamePitch;

		// Token: 0x04004141 RID: 16705
		[Token(Token = "0x4004141")]
		[FieldOffset(Offset = "0x50")]
		[Header("References")]
		public ParticleSystem Flame;

		// Token: 0x04004142 RID: 16706
		[Token(Token = "0x4004142")]
		[FieldOffset(Offset = "0x58")]
		public Light Light;

		// Token: 0x04004143 RID: 16707
		[Token(Token = "0x4004143")]
		[FieldOffset(Offset = "0x60")]
		public Transform Handle;

		// Token: 0x04004144 RID: 16708
		[Token(Token = "0x4004144")]
		[FieldOffset(Offset = "0x68")]
		public Clickable HandleClickable;

		// Token: 0x04004145 RID: 16709
		[Token(Token = "0x4004145")]
		[FieldOffset(Offset = "0x70")]
		public Transform Handle_Min;

		// Token: 0x04004146 RID: 16710
		[Token(Token = "0x4004146")]
		[FieldOffset(Offset = "0x78")]
		public Transform Handle_Max;

		// Token: 0x04004147 RID: 16711
		[Token(Token = "0x4004147")]
		[FieldOffset(Offset = "0x80")]
		public Transform Highlight;

		// Token: 0x04004148 RID: 16712
		[Token(Token = "0x4004148")]
		[FieldOffset(Offset = "0x88")]
		public Animation Anim;

		// Token: 0x04004149 RID: 16713
		[Token(Token = "0x4004149")]
		[FieldOffset(Offset = "0x90")]
		public AudioSourceController FlameSound;
	}
}
