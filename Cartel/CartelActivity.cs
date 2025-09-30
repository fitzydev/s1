using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Map;
using UnityEngine;

namespace ScheduleOne.Cartel
{
	// Token: 0x020007FD RID: 2045
	[Token(Token = "0x20007FD")]
	public class CartelActivity : MonoBehaviour
	{
		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x0600380D RID: 14349 RVA: 0x0000F210 File Offset: 0x0000D410
		// (set) Token: 0x0600380E RID: 14350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007FD")]
		public bool IsActive
		{
			[Token(Token = "0x600380D")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600380E")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x0600380F RID: 14351 RVA: 0x0000F228 File Offset: 0x0000D428
		// (set) Token: 0x06003810 RID: 14352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007FE")]
		public int MinsSinceActivation
		{
			[Token(Token = "0x600380F")]
			[Address(RVA = "0x47D5D0", Offset = "0x47BFD0", VA = "0x18047D5D0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003810")]
			[Address(RVA = "0x47D7A0", Offset = "0x47C1A0", VA = "0x18047D7A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06003811 RID: 14353 RVA: 0x0000F240 File Offset: 0x0000D440
		// (set) Token: 0x06003812 RID: 14354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007FF")]
		public EMapRegion Region
		{
			[Token(Token = "0x6003811")]
			[Address(RVA = "0x47D760", Offset = "0x47C160", VA = "0x18047D760")]
			[CompilerGenerated]
			get
			{
				return EMapRegion.Northtown;
			}
			[Token(Token = "0x6003812")]
			[Address(RVA = "0x47D820", Offset = "0x47C220", VA = "0x18047D820")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003813 RID: 14355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003813")]
		[Address(RVA = "0x7DE3E0", Offset = "0x7DCDE0", VA = "0x1807DE3E0")]
		private void Start()
		{
		}

		// Token: 0x06003814 RID: 14356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003814")]
		[Address(RVA = "0x7DE100", Offset = "0x7DCB00", VA = "0x1807DE100", Slot = "4")]
		public virtual void Activate(EMapRegion region)
		{
		}

		// Token: 0x06003815 RID: 14357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003815")]
		[Address(RVA = "0x7DE3D0", Offset = "0x7DCDD0", VA = "0x1807DE3D0", Slot = "5")]
		protected virtual void MinPassed()
		{
		}

		// Token: 0x06003816 RID: 14358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003816")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "6")]
		protected virtual void HourPassed()
		{
		}

		// Token: 0x06003817 RID: 14359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003817")]
		[Address(RVA = "0x7DE210", Offset = "0x7DCC10", VA = "0x1807DE210", Slot = "7")]
		protected virtual void Deactivate()
		{
		}

		// Token: 0x06003818 RID: 14360 RVA: 0x0000F258 File Offset: 0x0000D458
		[Token(Token = "0x6003818")]
		[Address(RVA = "0x7DE310", Offset = "0x7DCD10", VA = "0x1807DE310", Slot = "8")]
		public virtual bool IsRegionValidForActivity(EMapRegion region)
		{
			return default(bool);
		}

		// Token: 0x06003819 RID: 14361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003819")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public CartelActivity()
		{
		}

		// Token: 0x04002715 RID: 10005
		[Token(Token = "0x4002715")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		[Header("Settings")]
		public float InfluenceRequirement;

		// Token: 0x04002716 RID: 10006
		[Token(Token = "0x4002716")]
		[FieldOffset(Offset = "0x30")]
		public Action onActivated;

		// Token: 0x04002717 RID: 10007
		[Token(Token = "0x4002717")]
		[FieldOffset(Offset = "0x38")]
		public Action onDeactivated;
	}
}
