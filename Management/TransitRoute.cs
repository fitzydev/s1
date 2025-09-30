using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace ScheduleOne.Management
{
	// Token: 0x02000500 RID: 1280
	[Token(Token = "0x2000500")]
	public class TransitRoute
	{
		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06001A0D RID: 6669 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001A0E RID: 6670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000498")]
		public ITransitEntity Source
		{
			[Token(Token = "0x6001A0D")]
			[Address(RVA = "0x42FFD0", Offset = "0x42E9D0", VA = "0x18042FFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A0E")]
			[Address(RVA = "0x4A4990", Offset = "0x4A3390", VA = "0x1804A4990")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06001A0F RID: 6671 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001A10 RID: 6672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000499")]
		public ITransitEntity Destination
		{
			[Token(Token = "0x6001A0F")]
			[Address(RVA = "0x42FFB0", Offset = "0x42E9B0", VA = "0x18042FFB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A10")]
			[Address(RVA = "0x42FFE0", Offset = "0x42E9E0", VA = "0x18042FFE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A11")]
		[Address(RVA = "0x64E890", Offset = "0x64D290", VA = "0x18064E890")]
		public TransitRoute(ITransitEntity source, ITransitEntity destination)
		{
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A12")]
		[Address(RVA = "0x64E170", Offset = "0x64CB70", VA = "0x18064E170")]
		public void Destroy()
		{
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A13")]
		[Address(RVA = "0x64E3B0", Offset = "0x64CDB0", VA = "0x18064E3B0")]
		public void SetVisualsActive(bool active)
		{
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A14")]
		[Address(RVA = "0x64E570", Offset = "0x64CF70", VA = "0x18064E570")]
		private void Update()
		{
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A15")]
		[Address(RVA = "0x64E370", Offset = "0x64CD70", VA = "0x18064E370", Slot = "4")]
		public virtual void SetSource(ITransitEntity source)
		{
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x00009318 File Offset: 0x00007518
		[Token(Token = "0x6001A16")]
		[Address(RVA = "0x64E140", Offset = "0x64CB40", VA = "0x18064E140")]
		public bool AreEntitiesNonNull()
		{
			return default(bool);
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A17")]
		[Address(RVA = "0x64E330", Offset = "0x64CD30", VA = "0x18064E330", Slot = "5")]
		public virtual void SetDestination(ITransitEntity destination)
		{
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A18")]
		[Address(RVA = "0x64E7E0", Offset = "0x64D1E0", VA = "0x18064E7E0")]
		private void ValidateEntities()
		{
		}

		// Token: 0x04001697 RID: 5783
		[Token(Token = "0x4001697")]
		[FieldOffset(Offset = "0x20")]
		protected TransitLineVisuals visuals;

		// Token: 0x04001698 RID: 5784
		[Token(Token = "0x4001698")]
		[FieldOffset(Offset = "0x28")]
		public Action<ITransitEntity> onSourceChange;

		// Token: 0x04001699 RID: 5785
		[Token(Token = "0x4001699")]
		[FieldOffset(Offset = "0x30")]
		public Action<ITransitEntity> onDestinationChange;
	}
}
