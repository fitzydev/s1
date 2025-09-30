using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Product;
using ScheduleOne.Properties;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000AC8 RID: 2760
	[Token(Token = "0x2000AC8")]
	public class NewMixScreen : Singleton<NewMixScreen>
	{
		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06004AEA RID: 19178 RVA: 0x000136F8 File Offset: 0x000118F8
		[Token(Token = "0x17000A87")]
		public bool IsOpen
		{
			[Token(Token = "0x6004AEA")]
			[Address(RVA = "0x921AD0", Offset = "0x9204D0", VA = "0x180921AD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004AEB RID: 19179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AEB")]
		[Address(RVA = "0x9208B0", Offset = "0x91F2B0", VA = "0x1809208B0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06004AEC RID: 19180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AEC")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06004AED RID: 19181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AED")]
		[Address(RVA = "0x921970", Offset = "0x920370", VA = "0x180921970", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x06004AEE RID: 19182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AEE")]
		[Address(RVA = "0x9212C0", Offset = "0x91FCC0", VA = "0x1809212C0")]
		public void Open(List<Property> properties, EDrugType drugType, float productMarketValue)
		{
		}

		// Token: 0x06004AEF RID: 19183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AEF")]
		[Address(RVA = "0x920A20", Offset = "0x91F420", VA = "0x180920A20")]
		public void Close()
		{
		}

		// Token: 0x06004AF0 RID: 19184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF0")]
		[Address(RVA = "0x921800", Offset = "0x920200", VA = "0x180921800")]
		public void RandomizeButtonClicked()
		{
		}

		// Token: 0x06004AF1 RID: 19185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF1")]
		[Address(RVA = "0x920B00", Offset = "0x91F500", VA = "0x180920B00")]
		public void ConfirmButtonClicked()
		{
		}

		// Token: 0x06004AF2 RID: 19186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AF2")]
		[Address(RVA = "0x920C60", Offset = "0x91F660", VA = "0x180920C60")]
		public string GenerateUniqueName([Optional] Property[] properties, EDrugType drugType = EDrugType.Marijuana)
		{
			return null;
		}

		// Token: 0x06004AF3 RID: 19187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF3")]
		[Address(RVA = "0x921840", Offset = "0x920240", VA = "0x180921840")]
		protected void RefreshNameButtons()
		{
		}

		// Token: 0x06004AF4 RID: 19188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF4")]
		[Address(RVA = "0x921000", Offset = "0x91FA00", VA = "0x180921000")]
		public void OnNameValueChanged(string newVal)
		{
		}

		// Token: 0x06004AF5 RID: 19189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF5")]
		[Address(RVA = "0x921A00", Offset = "0x920400", VA = "0x180921A00")]
		public NewMixScreen()
		{
		}

		// Token: 0x040035D9 RID: 13785
		[Token(Token = "0x40035D9")]
		public const int MAX_PROPERTIES_DISPLAYED = 5;

		// Token: 0x040035DA RID: 13786
		[Token(Token = "0x40035DA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Header("References")]
		protected Canvas canvas;

		// Token: 0x040035DB RID: 13787
		[Token(Token = "0x40035DB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public RectTransform Container;

		// Token: 0x040035DC RID: 13788
		[Token(Token = "0x40035DC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected TMP_InputField nameInputField;

		// Token: 0x040035DD RID: 13789
		[Token(Token = "0x40035DD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected GameObject mixAlreadyExistsText;

		// Token: 0x040035DE RID: 13790
		[Token(Token = "0x40035DE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected RectTransform editIcon;

		// Token: 0x040035DF RID: 13791
		[Token(Token = "0x40035DF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected Button randomizeNameButton;

		// Token: 0x040035E0 RID: 13792
		[Token(Token = "0x40035E0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected Button confirmButton;

		// Token: 0x040035E1 RID: 13793
		[Token(Token = "0x40035E1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected TextMeshProUGUI PropertiesLabel;

		// Token: 0x040035E2 RID: 13794
		[Token(Token = "0x40035E2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected TextMeshProUGUI MarketValueLabel;

		// Token: 0x040035E3 RID: 13795
		[Token(Token = "0x40035E3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AudioSourceController Sound;

		// Token: 0x040035E4 RID: 13796
		[Token(Token = "0x40035E4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Header("Prefabs")]
		protected GameObject attributeEntryPrefab;

		// Token: 0x040035E5 RID: 13797
		[Token(Token = "0x40035E5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Header("Name Library")]
		[SerializeField]
		protected List<string> name1Library;

		// Token: 0x040035E6 RID: 13798
		[Token(Token = "0x40035E6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		protected List<string> name2Library;

		// Token: 0x040035E7 RID: 13799
		[Token(Token = "0x40035E7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Action<string> onMixNamed;
	}
}
