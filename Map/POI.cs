using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.Map
{
	// Token: 0x02000D06 RID: 3334
	[Token(Token = "0x2000D06")]
	public class POI : MonoBehaviour
	{
		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06005E3B RID: 24123 RVA: 0x00016A70 File Offset: 0x00014C70
		// (set) Token: 0x06005E3C RID: 24124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D1E")]
		public bool UISetup
		{
			[Token(Token = "0x6005E3B")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005E3C")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x06005E3D RID: 24125 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005E3E RID: 24126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D1F")]
		public string MainText
		{
			[Token(Token = "0x6005E3D")]
			[Address(RVA = "0x4423B0", Offset = "0x440DB0", VA = "0x1804423B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005E3E")]
			[Address(RVA = "0x4423E0", Offset = "0x440DE0", VA = "0x1804423E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x06005E3F RID: 24127 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005E40 RID: 24128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D20")]
		public RectTransform UI
		{
			[Token(Token = "0x6005E3F")]
			[Address(RVA = "0x47D5A0", Offset = "0x47BFA0", VA = "0x18047D5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005E40")]
			[Address(RVA = "0x5CDA00", Offset = "0x5CC400", VA = "0x1805CDA00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x06005E41 RID: 24129 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005E42 RID: 24130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D21")]
		public RectTransform IconContainer
		{
			[Token(Token = "0x6005E41")]
			[Address(RVA = "0x432BA0", Offset = "0x4315A0", VA = "0x180432BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005E42")]
			[Address(RVA = "0x4BEDD0", Offset = "0x4BD7D0", VA = "0x1804BEDD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005E43 RID: 24131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E43")]
		[Address(RVA = "0xA62540", Offset = "0xA60F40", VA = "0x180A62540")]
		private void OnEnable()
		{
		}

		// Token: 0x06005E44 RID: 24132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E44")]
		[Address(RVA = "0xA62490", Offset = "0xA60E90", VA = "0x180A62490")]
		private void OnDisable()
		{
		}

		// Token: 0x06005E45 RID: 24133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E45")]
		[Address(RVA = "0xA62C30", Offset = "0xA61630", VA = "0x180A62C30")]
		private void Update()
		{
		}

		// Token: 0x06005E46 RID: 24134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E46")]
		[Address(RVA = "0xA62760", Offset = "0xA61160", VA = "0x180A62760")]
		public void SetMainText(string text)
		{
		}

		// Token: 0x06005E47 RID: 24135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E47")]
		[Address(RVA = "0xA628A0", Offset = "0xA612A0", VA = "0x180A628A0", Slot = "4")]
		public virtual void UpdatePosition()
		{
		}

		// Token: 0x06005E48 RID: 24136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E48")]
		[Address(RVA = "0xA61F40", Offset = "0xA60940", VA = "0x180A61F40", Slot = "5")]
		public virtual void InitializeUI()
		{
		}

		// Token: 0x06005E49 RID: 24137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E49")]
		[Address(RVA = "0xA61F10", Offset = "0xA60910", VA = "0x180A61F10", Slot = "6")]
		protected virtual void HoverStart()
		{
		}

		// Token: 0x06005E4A RID: 24138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E4A")]
		[Address(RVA = "0xA61EE0", Offset = "0xA608E0", VA = "0x180A61EE0", Slot = "7")]
		protected virtual void HoverEnd()
		{
		}

		// Token: 0x06005E4B RID: 24139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E4B")]
		[Address(RVA = "0xA61E40", Offset = "0xA60840", VA = "0x180A61E40", Slot = "8")]
		protected virtual void Clicked()
		{
		}

		// Token: 0x06005E4C RID: 24140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E4C")]
		[Address(RVA = "0xA61520", Offset = "0xA5FF20", VA = "0x180A61520")]
		public POI()
		{
		}

		// Token: 0x06005E4D RID: 24141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E4D")]
		[Address(RVA = "0xA62830", Offset = "0xA61230", VA = "0x180A62830")]
		[CompilerGenerated]
		private IEnumerator <OnEnable>g__Wait|27_0()
		{
			return null;
		}

		// Token: 0x04004480 RID: 17536
		[Token(Token = "0x4004480")]
		[FieldOffset(Offset = "0x24")]
		public POI.TextShowMode MainTextVisibility;

		// Token: 0x04004481 RID: 17537
		[Token(Token = "0x4004481")]
		[FieldOffset(Offset = "0x28")]
		public string DefaultMainText;

		// Token: 0x04004482 RID: 17538
		[Token(Token = "0x4004482")]
		[FieldOffset(Offset = "0x30")]
		public bool AutoUpdatePosition;

		// Token: 0x04004483 RID: 17539
		[Token(Token = "0x4004483")]
		[FieldOffset(Offset = "0x31")]
		public bool Rotate;

		// Token: 0x04004485 RID: 17541
		[Token(Token = "0x4004485")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected GameObject UIPrefab;

		// Token: 0x04004488 RID: 17544
		[Token(Token = "0x4004488")]
		[FieldOffset(Offset = "0x58")]
		protected Text mainLabel;

		// Token: 0x04004489 RID: 17545
		[Token(Token = "0x4004489")]
		[FieldOffset(Offset = "0x60")]
		protected Button button;

		// Token: 0x0400448A RID: 17546
		[Token(Token = "0x400448A")]
		[FieldOffset(Offset = "0x68")]
		protected EventTrigger eventTrigger;

		// Token: 0x0400448B RID: 17547
		[Token(Token = "0x400448B")]
		[FieldOffset(Offset = "0x70")]
		private bool mainTextSet;

		// Token: 0x0400448C RID: 17548
		[Token(Token = "0x400448C")]
		[FieldOffset(Offset = "0x78")]
		public UnityEvent onUICreated;

		// Token: 0x02000D07 RID: 3335
		[Token(Token = "0x2000D07")]
		public enum TextShowMode
		{
			// Token: 0x0400448E RID: 17550
			[Token(Token = "0x400448E")]
			Off,
			// Token: 0x0400448F RID: 17551
			[Token(Token = "0x400448F")]
			Always,
			// Token: 0x04004490 RID: 17552
			[Token(Token = "0x4004490")]
			OnHover
		}
	}
}
