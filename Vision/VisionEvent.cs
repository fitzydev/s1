using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace ScheduleOne.Vision
{
	// Token: 0x02000383 RID: 899
	[Token(Token = "0x2000383")]
	public class VisionEvent
	{
		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001415 RID: 5141 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001416 RID: 5142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003C2")]
		public ISightable Target
		{
			[Token(Token = "0x6001415")]
			[Address(RVA = "0x42FFD0", Offset = "0x42E9D0", VA = "0x18042FFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001416")]
			[Address(RVA = "0x4A4990", Offset = "0x4A3390", VA = "0x1804A4990")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06001417 RID: 5143 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001418 RID: 5144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003C3")]
		public EntityVisualState State
		{
			[Token(Token = "0x6001417")]
			[Address(RVA = "0x42FFB0", Offset = "0x42E9B0", VA = "0x18042FFB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001418")]
			[Address(RVA = "0x42FFE0", Offset = "0x42E9E0", VA = "0x18042FFE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06001419 RID: 5145 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600141A RID: 5146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003C4")]
		public VisionCone Owner
		{
			[Token(Token = "0x6001419")]
			[Address(RVA = "0x42FFC0", Offset = "0x42E9C0", VA = "0x18042FFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600141A")]
			[Address(RVA = "0x42FFF0", Offset = "0x42E9F0", VA = "0x18042FFF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x0600141B RID: 5147 RVA: 0x00008340 File Offset: 0x00006540
		// (set) Token: 0x0600141C RID: 5148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003C5")]
		public float FullNoticeTime
		{
			[Token(Token = "0x600141B")]
			[Address(RVA = "0x485C70", Offset = "0x484670", VA = "0x180485C70")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600141C")]
			[Address(RVA = "0x485CB0", Offset = "0x4846B0", VA = "0x180485CB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x0600141D RID: 5149 RVA: 0x00008358 File Offset: 0x00006558
		[Token(Token = "0x170003C6")]
		public float NormalizedNoticeLevel
		{
			[Token(Token = "0x600141D")]
			[Address(RVA = "0x5C54E0", Offset = "0x5C3EE0", VA = "0x1805C54E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600141E")]
		[Address(RVA = "0x5C5390", Offset = "0x5C3D90", VA = "0x1805C5390")]
		public VisionEvent(VisionCone _owner, ISightable _target, EntityVisualState _state, float _noticeTime)
		{
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600141F")]
		[Address(RVA = "0x5C5010", Offset = "0x5C3A10", VA = "0x1805C5010")]
		public void UpdateEvent(float visionDeltaThisFrame, float tickTime)
		{
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001420")]
		[Address(RVA = "0x5C4F80", Offset = "0x5C3980", VA = "0x1805C4F80")]
		public void EndEvent()
		{
		}

		// Token: 0x040012F8 RID: 4856
		[Token(Token = "0x40012F8")]
		private const float NOTICE_DROP_THRESHOLD = 1f;

		// Token: 0x040012FD RID: 4861
		[Token(Token = "0x40012FD")]
		[FieldOffset(Offset = "0x2C")]
		private float timeSinceSighted;

		// Token: 0x040012FE RID: 4862
		[Token(Token = "0x40012FE")]
		[FieldOffset(Offset = "0x30")]
		private float currentNoticeTime;
	}
}
