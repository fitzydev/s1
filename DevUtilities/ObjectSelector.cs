using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ConstructableScripts;
using ScheduleOne.EntityFramework;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x0200075B RID: 1883
	[Token(Token = "0x200075B")]
	public class ObjectSelector : Singleton<ObjectSelector>
	{
		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x0600330F RID: 13071 RVA: 0x0000E130 File Offset: 0x0000C330
		// (set) Token: 0x06003310 RID: 13072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700076D")]
		public bool isSelecting
		{
			[Token(Token = "0x600330F")]
			[Address(RVA = "0x4BE260", Offset = "0x4BCC60", VA = "0x1804BE260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003310")]
			[Address(RVA = "0x4F3A70", Offset = "0x4F2470", VA = "0x1804F3A70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003311 RID: 13073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003311")]
		[Address(RVA = "0x7839D0", Offset = "0x7823D0", VA = "0x1807839D0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06003312 RID: 13074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003312")]
		[Address(RVA = "0x783D10", Offset = "0x782710", VA = "0x180783D10", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x06003313 RID: 13075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003313")]
		[Address(RVA = "0x7830A0", Offset = "0x781AA0", VA = "0x1807830A0", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06003314 RID: 13076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003314")]
		[Address(RVA = "0x782D80", Offset = "0x781780", VA = "0x180782D80")]
		private BuildableItem GetHoveredBuildable()
		{
			return null;
		}

		// Token: 0x06003315 RID: 13077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003315")]
		[Address(RVA = "0x782F10", Offset = "0x781910", VA = "0x180782F10")]
		private Constructable GetHoveredConstructable()
		{
			return null;
		}

		// Token: 0x06003316 RID: 13078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003316")]
		[Address(RVA = "0x782D40", Offset = "0x781740", VA = "0x180782D40")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06003317 RID: 13079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003317")]
		[Address(RVA = "0x783630", Offset = "0x782030", VA = "0x180783630")]
		public void StartSelecting(string selectionTitle, List<Type> _typeRestriction, ref List<BuildableItem> initialSelection_Objects, ref List<Constructable> initalSelection_Constructables, int _selectionLimit, bool _exitOnSelectionLimit)
		{
		}

		// Token: 0x06003318 RID: 13080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003318")]
		[Address(RVA = "0x783A80", Offset = "0x782480", VA = "0x180783A80")]
		public void StopSelecting()
		{
		}

		// Token: 0x06003319 RID: 13081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003319")]
		[Address(RVA = "0x784670", Offset = "0x783070", VA = "0x180784670")]
		public ObjectSelector()
		{
		}

		// Token: 0x0400235F RID: 9055
		[Token(Token = "0x400235F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Header("Settings")]
		protected float detectionRange;

		// Token: 0x04002360 RID: 9056
		[Token(Token = "0x4002360")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected LayerMask detectionMask;

		// Token: 0x04002362 RID: 9058
		[Token(Token = "0x4002362")]
		[FieldOffset(Offset = "0x38")]
		private List<Type> allowedTypes;

		// Token: 0x04002363 RID: 9059
		[Token(Token = "0x4002363")]
		[FieldOffset(Offset = "0x40")]
		private List<BuildableItem> selectedObjects;

		// Token: 0x04002364 RID: 9060
		[Token(Token = "0x4002364")]
		[FieldOffset(Offset = "0x48")]
		private List<Constructable> selectedConstructables;

		// Token: 0x04002365 RID: 9061
		[Token(Token = "0x4002365")]
		[FieldOffset(Offset = "0x50")]
		public Action onClose;

		// Token: 0x04002366 RID: 9062
		[Token(Token = "0x4002366")]
		[FieldOffset(Offset = "0x58")]
		private int selectionLimit;

		// Token: 0x04002367 RID: 9063
		[Token(Token = "0x4002367")]
		[FieldOffset(Offset = "0x5C")]
		private bool exitOnSelectionLimit;

		// Token: 0x04002368 RID: 9064
		[Token(Token = "0x4002368")]
		[FieldOffset(Offset = "0x60")]
		private BuildableItem hoveredBuildable;

		// Token: 0x04002369 RID: 9065
		[Token(Token = "0x4002369")]
		[FieldOffset(Offset = "0x68")]
		private Constructable hoveredConstructable;

		// Token: 0x0400236A RID: 9066
		[Token(Token = "0x400236A")]
		[FieldOffset(Offset = "0x70")]
		private List<BuildableItem> outlinedObjects;

		// Token: 0x0400236B RID: 9067
		[Token(Token = "0x400236B")]
		[FieldOffset(Offset = "0x78")]
		private List<Constructable> outlinedConstructables;
	}
}
