using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000AA5 RID: 2725
	[Token(Token = "0x2000AA5")]
	public class GenericSelectionModule : Singleton<GenericSelectionModule>
	{
		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06004A11 RID: 18961 RVA: 0x000134E8 File Offset: 0x000116E8
		// (set) Token: 0x06004A12 RID: 18962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A68")]
		public bool isOpen
		{
			[Token(Token = "0x6004A11")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004A12")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06004A13 RID: 18963 RVA: 0x00013500 File Offset: 0x00011700
		// (set) Token: 0x06004A14 RID: 18964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A69")]
		[HideInInspector]
		public int ChosenOptionIndex
		{
			[Token(Token = "0x6004A13")]
			[Address(RVA = "0x4873D0", Offset = "0x485DD0", VA = "0x1804873D0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004A14")]
			[Address(RVA = "0x917330", Offset = "0x915D30", VA = "0x180917330")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06004A15 RID: 18965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A15")]
		[Address(RVA = "0x916D00", Offset = "0x915700", VA = "0x180916D00", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06004A16 RID: 18966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A16")]
		[Address(RVA = "0x917240", Offset = "0x915C40", VA = "0x180917240", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06004A17 RID: 18967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A17")]
		[Address(RVA = "0x916EA0", Offset = "0x9158A0", VA = "0x180916EA0")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06004A18 RID: 18968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A18")]
		[Address(RVA = "0x916F50", Offset = "0x915950", VA = "0x180916F50")]
		public void Open(string title, List<string> options)
		{
		}

		// Token: 0x06004A19 RID: 18969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A19")]
		[Address(RVA = "0x916E60", Offset = "0x915860", VA = "0x180916E60")]
		public void Close()
		{
		}

		// Token: 0x06004A1A RID: 18970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A1A")]
		[Address(RVA = "0x916D60", Offset = "0x915760", VA = "0x180916D60")]
		public void Cancel()
		{
		}

		// Token: 0x06004A1B RID: 18971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A1B")]
		[Address(RVA = "0x916DA0", Offset = "0x9157A0", VA = "0x180916DA0")]
		private void ClearOptions()
		{
		}

		// Token: 0x06004A1C RID: 18972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A1C")]
		[Address(RVA = "0x916F10", Offset = "0x915910", VA = "0x180916F10")]
		private void ListOptionClicked(int index)
		{
		}

		// Token: 0x06004A1D RID: 18973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A1D")]
		[Address(RVA = "0x9172F0", Offset = "0x915CF0", VA = "0x1809172F0")]
		public GenericSelectionModule()
		{
		}

		// Token: 0x040034E0 RID: 13536
		[Token(Token = "0x40034E0")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas canvas;

		// Token: 0x040034E1 RID: 13537
		[Token(Token = "0x40034E1")]
		[FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI TitleText;

		// Token: 0x040034E2 RID: 13538
		[Token(Token = "0x40034E2")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform OptionContainer;

		// Token: 0x040034E3 RID: 13539
		[Token(Token = "0x40034E3")]
		[FieldOffset(Offset = "0x48")]
		public Button CloseButton;

		// Token: 0x040034E4 RID: 13540
		[Token(Token = "0x40034E4")]
		[FieldOffset(Offset = "0x50")]
		[Header("Prefabs")]
		public GameObject ListOptionPrefab;

		// Token: 0x040034E5 RID: 13541
		[Token(Token = "0x40034E5")]
		[FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public bool OptionChosen;
	}
}
