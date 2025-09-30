using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Product;
using ScheduleOne.Properties;
using ScheduleOne.Storage;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A86 RID: 2694
	[Token(Token = "0x2000A86")]
	public class CreateMixInterface : Singleton<CreateMixInterface>
	{
		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x0600492E RID: 18734 RVA: 0x00013218 File Offset: 0x00011418
		// (set) Token: 0x0600492F RID: 18735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A45")]
		public bool IsOpen
		{
			[Token(Token = "0x600492E")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600492F")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06004930 RID: 18736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A46")]
		private ItemSlot beanSlot
		{
			[Token(Token = "0x6004930")]
			[Address(RVA = "0x905F40", Offset = "0x904940", VA = "0x180905F40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06004931 RID: 18737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A47")]
		private ItemSlot mixerSlot
		{
			[Token(Token = "0x6004931")]
			[Address(RVA = "0x905FA0", Offset = "0x9049A0", VA = "0x180905FA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06004932 RID: 18738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A48")]
		private ItemSlot outputSlot
		{
			[Token(Token = "0x6004932")]
			[Address(RVA = "0x906000", Offset = "0x904A00", VA = "0x180906000")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06004933 RID: 18739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A49")]
		private ItemSlot productSlot
		{
			[Token(Token = "0x6004933")]
			[Address(RVA = "0x906060", Offset = "0x904A60", VA = "0x180906060")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004934 RID: 18740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004934")]
		[Address(RVA = "0x902D20", Offset = "0x901720", VA = "0x180902D20", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06004935 RID: 18741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004935")]
		[Address(RVA = "0x9040A0", Offset = "0x902AA0", VA = "0x1809040A0")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06004936 RID: 18742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004936")]
		[Address(RVA = "0x904A80", Offset = "0x903480", VA = "0x180904A80")]
		public void Open()
		{
		}

		// Token: 0x06004937 RID: 18743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004937")]
		[Address(RVA = "0x904080", Offset = "0x902A80", VA = "0x180904080")]
		private void ContentsChanged()
		{
		}

		// Token: 0x06004938 RID: 18744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004938")]
		[Address(RVA = "0x905270", Offset = "0x903C70", VA = "0x180905270")]
		private void UpdateCanBegin()
		{
		}

		// Token: 0x06004939 RID: 18745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004939")]
		[Address(RVA = "0x905650", Offset = "0x904050", VA = "0x180905650")]
		private void UpdateOutput()
		{
		}

		// Token: 0x0600493A RID: 18746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600493A")]
		[Address(RVA = "0x903360", Offset = "0x901D60", VA = "0x180903360")]
		private void BeginPressed()
		{
		}

		// Token: 0x0600493B RID: 18747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600493B")]
		[Address(RVA = "0x9042D0", Offset = "0x902CD0", VA = "0x1809042D0")]
		private List<Property> GetOutputProperties(ProductDefinition product, PropertyItemDefinition mixer)
		{
			return null;
		}

		// Token: 0x0600493C RID: 18748 RVA: 0x00013230 File Offset: 0x00011430
		[Token(Token = "0x600493C")]
		[Address(RVA = "0x9048A0", Offset = "0x9032A0", VA = "0x1809048A0")]
		private bool IsOutputKnown(out ProductDefinition knownProduct)
		{
			return default(bool);
		}

		// Token: 0x0600493D RID: 18749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600493D")]
		[Address(RVA = "0x904490", Offset = "0x902E90", VA = "0x180904490")]
		private string GetPropertyListString(List<Property> properties)
		{
			return null;
		}

		// Token: 0x0600493E RID: 18750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600493E")]
		[Address(RVA = "0x904640", Offset = "0x903040", VA = "0x180904640")]
		private string GetPropertyString(Property property)
		{
			return null;
		}

		// Token: 0x0600493F RID: 18751 RVA: 0x00013248 File Offset: 0x00011448
		[Token(Token = "0x600493F")]
		[Address(RVA = "0x9035B0", Offset = "0x901FB0", VA = "0x1809035B0")]
		private bool CanBegin()
		{
			return default(bool);
		}

		// Token: 0x06004940 RID: 18752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004940")]
		[Address(RVA = "0x903700", Offset = "0x902100", VA = "0x180903700")]
		public void Close()
		{
		}

		// Token: 0x06004941 RID: 18753 RVA: 0x00013260 File Offset: 0x00011460
		[Token(Token = "0x6004941")]
		[Address(RVA = "0x904840", Offset = "0x903240", VA = "0x180904840")]
		private bool HasProduct()
		{
			return default(bool);
		}

		// Token: 0x06004942 RID: 18754 RVA: 0x00013278 File Offset: 0x00011478
		[Token(Token = "0x6004942")]
		[Address(RVA = "0x904770", Offset = "0x903170", VA = "0x180904770")]
		private bool HasBeans()
		{
			return default(bool);
		}

		// Token: 0x06004943 RID: 18755 RVA: 0x00013290 File Offset: 0x00011490
		[Token(Token = "0x6004943")]
		[Address(RVA = "0x9047E0", Offset = "0x9031E0", VA = "0x1809047E0")]
		private bool HasMixer()
		{
			return default(bool);
		}

		// Token: 0x06004944 RID: 18756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004944")]
		[Address(RVA = "0x904360", Offset = "0x902D60", VA = "0x180904360")]
		private ProductDefinition GetProduct()
		{
			return null;
		}

		// Token: 0x06004945 RID: 18757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004945")]
		[Address(RVA = "0x9040F0", Offset = "0x902AF0", VA = "0x1809040F0")]
		private PropertyItemDefinition GetMixer()
		{
			return null;
		}

		// Token: 0x06004946 RID: 18758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004946")]
		[Address(RVA = "0x905F00", Offset = "0x904900", VA = "0x180905F00")]
		public CreateMixInterface()
		{
		}

		// Token: 0x04003415 RID: 13333
		[Token(Token = "0x4003415")]
		public const int BEAN_REQUIREMENT = 5;

		// Token: 0x04003417 RID: 13335
		[Token(Token = "0x4003417")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003418 RID: 13336
		[Token(Token = "0x4003418")]
		[FieldOffset(Offset = "0x38")]
		public ItemSlotUI BeansSlot;

		// Token: 0x04003419 RID: 13337
		[Token(Token = "0x4003419")]
		[FieldOffset(Offset = "0x40")]
		public ItemSlotUI ProductSlot;

		// Token: 0x0400341A RID: 13338
		[Token(Token = "0x400341A")]
		[FieldOffset(Offset = "0x48")]
		public ItemSlotUI MixerSlot;

		// Token: 0x0400341B RID: 13339
		[Token(Token = "0x400341B")]
		[FieldOffset(Offset = "0x50")]
		public ItemSlotUI OutputSlot;

		// Token: 0x0400341C RID: 13340
		[Token(Token = "0x400341C")]
		[FieldOffset(Offset = "0x58")]
		public Image OutputIcon;

		// Token: 0x0400341D RID: 13341
		[Token(Token = "0x400341D")]
		[FieldOffset(Offset = "0x60")]
		public Button BeginButton;

		// Token: 0x0400341E RID: 13342
		[Token(Token = "0x400341E")]
		[FieldOffset(Offset = "0x68")]
		public WorldStorageEntity Storage;

		// Token: 0x0400341F RID: 13343
		[Token(Token = "0x400341F")]
		[FieldOffset(Offset = "0x70")]
		public TextMeshProUGUI ProductPropertiesLabel;

		// Token: 0x04003420 RID: 13344
		[Token(Token = "0x4003420")]
		[FieldOffset(Offset = "0x78")]
		public TextMeshProUGUI OutputPropertiesLabel;

		// Token: 0x04003421 RID: 13345
		[Token(Token = "0x4003421")]
		[FieldOffset(Offset = "0x80")]
		public TextMeshProUGUI BeanProblemLabel;

		// Token: 0x04003422 RID: 13346
		[Token(Token = "0x4003422")]
		[FieldOffset(Offset = "0x88")]
		public TextMeshProUGUI ProductProblemLabel;

		// Token: 0x04003423 RID: 13347
		[Token(Token = "0x4003423")]
		[FieldOffset(Offset = "0x90")]
		public TextMeshProUGUI MixerProblemLabel;

		// Token: 0x04003424 RID: 13348
		[Token(Token = "0x4003424")]
		[FieldOffset(Offset = "0x98")]
		public TextMeshProUGUI OutputProblemLabel;

		// Token: 0x04003425 RID: 13349
		[Token(Token = "0x4003425")]
		[FieldOffset(Offset = "0xA0")]
		public Transform CameraPosition;

		// Token: 0x04003426 RID: 13350
		[Token(Token = "0x4003426")]
		[FieldOffset(Offset = "0xA8")]
		public RectTransform UnknownOutputIcon;

		// Token: 0x04003427 RID: 13351
		[Token(Token = "0x4003427")]
		[FieldOffset(Offset = "0xB0")]
		public UnityEvent onOpen;

		// Token: 0x04003428 RID: 13352
		[Token(Token = "0x4003428")]
		[FieldOffset(Offset = "0xB8")]
		public UnityEvent onClose;
	}
}
