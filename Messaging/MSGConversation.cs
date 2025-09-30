using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.UI.Phone.Messages;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.Messaging
{
	// Token: 0x020004B1 RID: 1201
	[Token(Token = "0x20004B1")]
	[Serializable]
	public class MSGConversation : ISaveable
	{
		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x060017A6 RID: 6054 RVA: 0x00008B98 File Offset: 0x00006D98
		// (set) Token: 0x060017A7 RID: 6055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000439")]
		public bool IsSenderKnown
		{
			[Token(Token = "0x60017A6")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60017A7")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x060017A8 RID: 6056 RVA: 0x00008BB0 File Offset: 0x00006DB0
		// (set) Token: 0x060017A9 RID: 6057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700043A")]
		public bool Read
		{
			[Token(Token = "0x60017A8")]
			[Address(RVA = "0x4FA8A0", Offset = "0x4F92A0", VA = "0x1804FA8A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60017A9")]
			[Address(RVA = "0x4FAC50", Offset = "0x4F9650", VA = "0x1804FAC50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x060017AA RID: 6058 RVA: 0x00008BC8 File Offset: 0x00006DC8
		// (set) Token: 0x060017AB RID: 6059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700043B")]
		public int index
		{
			[Token(Token = "0x60017AA")]
			[Address(RVA = "0x4FA890", Offset = "0x4F9290", VA = "0x1804FA890")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60017AB")]
			[Address(RVA = "0x506F70", Offset = "0x505970", VA = "0x180506F70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x060017AC RID: 6060 RVA: 0x00008BE0 File Offset: 0x00006DE0
		// (set) Token: 0x060017AD RID: 6061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700043C")]
		public bool isOpen
		{
			[Token(Token = "0x60017AC")]
			[Address(RVA = "0x4A4A60", Offset = "0x4A3460", VA = "0x1804A4A60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60017AD")]
			[Address(RVA = "0x4A4A90", Offset = "0x4A3490", VA = "0x1804A4A90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x060017AE RID: 6062 RVA: 0x00008BF8 File Offset: 0x00006DF8
		// (set) Token: 0x060017AF RID: 6063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700043D")]
		public bool rollingOut
		{
			[Token(Token = "0x60017AE")]
			[Address(RVA = "0x52FCE0", Offset = "0x52E6E0", VA = "0x18052FCE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60017AF")]
			[Address(RVA = "0x60C880", Offset = "0x60B280", VA = "0x18060C880")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x060017B0 RID: 6064 RVA: 0x00008C10 File Offset: 0x00006E10
		// (set) Token: 0x060017B1 RID: 6065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700043E")]
		public bool EntryVisible
		{
			[Token(Token = "0x60017B0")]
			[Address(RVA = "0x60C7A0", Offset = "0x60B1A0", VA = "0x18060C7A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60017B1")]
			[Address(RVA = "0x60C820", Offset = "0x60B220", VA = "0x18060C820")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x060017B2 RID: 6066 RVA: 0x00008C28 File Offset: 0x00006E28
		[Token(Token = "0x1700043F")]
		public bool AreResponsesActive
		{
			[Token(Token = "0x60017B2")]
			[Address(RVA = "0x60C750", Offset = "0x60B150", VA = "0x18060C750")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x060017B3 RID: 6067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000440")]
		public string SaveFolderName
		{
			[Token(Token = "0x60017B3")]
			[Address(RVA = "0x60C7F0", Offset = "0x60B1F0", VA = "0x18060C7F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x060017B4 RID: 6068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000441")]
		public string SaveFileName
		{
			[Token(Token = "0x60017B4")]
			[Address(RVA = "0x60C7C0", Offset = "0x60B1C0", VA = "0x18060C7C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x060017B5 RID: 6069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000442")]
		public Loader Loader
		{
			[Token(Token = "0x60017B5")]
			[Address(RVA = "0x4AAD70", Offset = "0x4A9770", VA = "0x1804AAD70", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x060017B6 RID: 6070 RVA: 0x00008C40 File Offset: 0x00006E40
		[Token(Token = "0x17000443")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x60017B6")]
			[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x060017B7 RID: 6071 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060017B8 RID: 6072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000444")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x60017B7")]
			[Address(RVA = "0x53B830", Offset = "0x53A230", VA = "0x18053B830", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60017B8")]
			[Address(RVA = "0x60C840", Offset = "0x60B240", VA = "0x18060C840", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x060017B9 RID: 6073 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060017BA RID: 6074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000445")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x60017B9")]
			[Address(RVA = "0x60C7B0", Offset = "0x60B1B0", VA = "0x18060C7B0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60017BA")]
			[Address(RVA = "0x60C860", Offset = "0x60B260", VA = "0x18060C860", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x060017BB RID: 6075 RVA: 0x00008C58 File Offset: 0x00006E58
		// (set) Token: 0x060017BC RID: 6076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000446")]
		public bool HasChanged
		{
			[Token(Token = "0x60017BB")]
			[Address(RVA = "0x548990", Offset = "0x547390", VA = "0x180548990", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60017BC")]
			[Address(RVA = "0x60C830", Offset = "0x60B230", VA = "0x18060C830", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017BD")]
		[Address(RVA = "0x60C350", Offset = "0x60AD50", VA = "0x18060C350")]
		public MSGConversation(NPC _npc, string _contactName)
		{
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017BE")]
		[Address(RVA = "0x6090B0", Offset = "0x607AB0", VA = "0x1806090B0", Slot = "27")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017BF")]
		[Address(RVA = "0x4BEDE0", Offset = "0x4BD7E0", VA = "0x1804BEDE0")]
		public void SetCategories(List<EConversationCategory> cat)
		{
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C0")]
		[Address(RVA = "0x6095D0", Offset = "0x607FD0", VA = "0x1806095D0")]
		public void MoveToTop()
		{
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C1")]
		[Address(RVA = "0x608380", Offset = "0x606D80", VA = "0x180608380")]
		protected void CreateUI()
		{
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C2")]
		[Address(RVA = "0x608B60", Offset = "0x607560", VA = "0x180608B60")]
		public void EnsureUIExists()
		{
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C3")]
		[Address(RVA = "0x6096F0", Offset = "0x6080F0", VA = "0x1806096F0")]
		protected void RefreshPreviewText()
		{
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C4")]
		[Address(RVA = "0x60A270", Offset = "0x608C70", VA = "0x18060A270")]
		public void RepositionEntry()
		{
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C5")]
		[Address(RVA = "0x60AD50", Offset = "0x609750", VA = "0x18060AD50")]
		public void SetIsKnown(bool known)
		{
		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C6")]
		[Address(RVA = "0x608B80", Offset = "0x607580", VA = "0x180608B80")]
		public void EntryClicked()
		{
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C7")]
		[Address(RVA = "0x60AEF0", Offset = "0x6098F0", VA = "0x18060AEF0")]
		public void SetOpen(bool open)
		{
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C8")]
		[Address(RVA = "0x609A00", Offset = "0x608400", VA = "0x180609A00", Slot = "28")]
		protected virtual void RenderMessage(Message m)
		{
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C9")]
		[Address(RVA = "0x60ACD0", Offset = "0x6096D0", VA = "0x18060ACD0")]
		public void SetEntryVisibility(bool v)
		{
		}

		// Token: 0x060017CA RID: 6090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017CA")]
		[Address(RVA = "0x60BB80", Offset = "0x60A580", VA = "0x18060BB80")]
		public void SetRead(bool r)
		{
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017CB")]
		[Address(RVA = "0x60A820", Offset = "0x609220", VA = "0x18060A820")]
		public void SendMessage(Message message, bool notify = true, bool network = true)
		{
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017CC")]
		[Address(RVA = "0x60A550", Offset = "0x608F50", VA = "0x18060A550")]
		public void SendMessageChain(MessageChain messages, float initialDelay = 0f, bool notify = true, bool network = true)
		{
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017CD")]
		[Address(RVA = "0x608C70", Offset = "0x607670", VA = "0x180608C70")]
		public MSGConversationData GetSaveData()
		{
			return null;
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017CE")]
		[Address(RVA = "0x609070", Offset = "0x607A70", VA = "0x180609070", Slot = "29")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017CF")]
		[Address(RVA = "0x609140", Offset = "0x607B40", VA = "0x180609140", Slot = "30")]
		public virtual void Load(MSGConversationData data)
		{
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017D0")]
		[Address(RVA = "0x60BED0", Offset = "0x60A8D0", VA = "0x18060BED0")]
		public void SetSliderValue(float value, Color color)
		{
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017D1")]
		[Address(RVA = "0x608B90", Offset = "0x607590", VA = "0x180608B90")]
		public Response GetResponse(string label)
		{
			return null;
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017D2")]
		[Address(RVA = "0x60BFD0", Offset = "0x60A9D0", VA = "0x18060BFD0")]
		public void ShowResponses(List<Response> _responses, float showResponseDelay = 0f, bool network = true)
		{
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017D3")]
		[Address(RVA = "0x607D50", Offset = "0x606750", VA = "0x180607D50")]
		protected void CreateResponseUI(Response r)
		{
		}

		// Token: 0x060017D4 RID: 6100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017D4")]
		[Address(RVA = "0x6097D0", Offset = "0x6081D0", VA = "0x1806097D0")]
		private void RefreshResponseContainer()
		{
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017D5")]
		[Address(RVA = "0x607B30", Offset = "0x606530", VA = "0x180607B30")]
		protected void ClearResponseUI()
		{
		}

		// Token: 0x060017D6 RID: 6102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017D6")]
		[Address(RVA = "0x60BDC0", Offset = "0x60A7C0", VA = "0x18060BDC0")]
		public void SetResponseContainerVisible(bool v)
		{
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017D7")]
		[Address(RVA = "0x60A340", Offset = "0x608D40", VA = "0x18060A340")]
		public void ResponseChosen(Response r, bool network)
		{
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017D8")]
		[Address(RVA = "0x607C50", Offset = "0x606650", VA = "0x180607C50")]
		public void ClearResponses(bool network = false)
		{
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017D9")]
		[Address(RVA = "0x608200", Offset = "0x606C00", VA = "0x180608200")]
		public SendableMessage CreateSendableMessage(string text)
		{
			return null;
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017DA")]
		[Address(RVA = "0x60ABB0", Offset = "0x6095B0", VA = "0x18060ABB0")]
		public void SendPlayerMessage(int sendableIndex, int sentIndex, bool network)
		{
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017DB")]
		[Address(RVA = "0x60A1D0", Offset = "0x608BD0", VA = "0x18060A1D0")]
		public void RenderPlayerMessage(SendableMessage sendable)
		{
		}

		// Token: 0x060017DC RID: 6108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017DC")]
		[Address(RVA = "0x607A40", Offset = "0x606440", VA = "0x180607A40")]
		private void CheckSendLoop()
		{
		}

		// Token: 0x060017DD RID: 6109 RVA: 0x00008C70 File Offset: 0x00006E70
		[Token(Token = "0x60017DD")]
		[Address(RVA = "0x6078D0", Offset = "0x6062D0", VA = "0x1806078D0")]
		private bool CanSendNewMessage()
		{
			return default(bool);
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017DF")]
		[Address(RVA = "0x60C270", Offset = "0x60AC70", VA = "0x18060C270")]
		[CompilerGenerated]
		private IEnumerator <CheckSendLoop>g__Loop|103_0()
		{
			return null;
		}

		// Token: 0x04001561 RID: 5473
		[Token(Token = "0x4001561")]
		public const int MAX_MESSAGE_HISTORY = 10;

		// Token: 0x04001562 RID: 5474
		[Token(Token = "0x4001562")]
		[FieldOffset(Offset = "0x10")]
		public string contactName;

		// Token: 0x04001563 RID: 5475
		[Token(Token = "0x4001563")]
		[FieldOffset(Offset = "0x18")]
		public NPC sender;

		// Token: 0x04001565 RID: 5477
		[Token(Token = "0x4001565")]
		[FieldOffset(Offset = "0x28")]
		public List<Message> messageHistory;

		// Token: 0x04001566 RID: 5478
		[Token(Token = "0x4001566")]
		[FieldOffset(Offset = "0x30")]
		public List<MessageChain> messageChainHistory;

		// Token: 0x04001567 RID: 5479
		[Token(Token = "0x4001567")]
		[FieldOffset(Offset = "0x38")]
		public List<MessageBubble> bubbles;

		// Token: 0x04001568 RID: 5480
		[Token(Token = "0x4001568")]
		[FieldOffset(Offset = "0x40")]
		public List<SendableMessage> Sendables;

		// Token: 0x0400156E RID: 5486
		[Token(Token = "0x400156E")]
		[FieldOffset(Offset = "0x58")]
		public List<EConversationCategory> Categories;

		// Token: 0x0400156F RID: 5487
		[Token(Token = "0x400156F")]
		[FieldOffset(Offset = "0x60")]
		public RectTransform entry;

		// Token: 0x04001570 RID: 5488
		[Token(Token = "0x4001570")]
		[FieldOffset(Offset = "0x68")]
		protected RectTransform container;

		// Token: 0x04001571 RID: 5489
		[Token(Token = "0x4001571")]
		[FieldOffset(Offset = "0x70")]
		protected RectTransform bubbleContainer;

		// Token: 0x04001572 RID: 5490
		[Token(Token = "0x4001572")]
		[FieldOffset(Offset = "0x78")]
		protected RectTransform scrollRectContainer;

		// Token: 0x04001573 RID: 5491
		[Token(Token = "0x4001573")]
		[FieldOffset(Offset = "0x80")]
		protected ScrollRect scrollRect;

		// Token: 0x04001574 RID: 5492
		[Token(Token = "0x4001574")]
		[FieldOffset(Offset = "0x88")]
		protected Text entryPreviewText;

		// Token: 0x04001575 RID: 5493
		[Token(Token = "0x4001575")]
		[FieldOffset(Offset = "0x90")]
		protected RectTransform unreadDot;

		// Token: 0x04001576 RID: 5494
		[Token(Token = "0x4001576")]
		[FieldOffset(Offset = "0x98")]
		protected Slider slider;

		// Token: 0x04001577 RID: 5495
		[Token(Token = "0x4001577")]
		[FieldOffset(Offset = "0xA0")]
		protected Image sliderFill;

		// Token: 0x04001578 RID: 5496
		[Token(Token = "0x4001578")]
		[FieldOffset(Offset = "0xA8")]
		protected RectTransform responseContainer;

		// Token: 0x04001579 RID: 5497
		[Token(Token = "0x4001579")]
		[FieldOffset(Offset = "0xB0")]
		protected MessageSenderInterface senderInterface;

		// Token: 0x0400157A RID: 5498
		[Token(Token = "0x400157A")]
		[FieldOffset(Offset = "0xB8")]
		private bool uiCreated;

		// Token: 0x0400157B RID: 5499
		[Token(Token = "0x400157B")]
		[FieldOffset(Offset = "0xC0")]
		public Action onMessageRendered;

		// Token: 0x0400157C RID: 5500
		[Token(Token = "0x400157C")]
		[FieldOffset(Offset = "0xC8")]
		public Action onLoaded;

		// Token: 0x0400157D RID: 5501
		[Token(Token = "0x400157D")]
		[FieldOffset(Offset = "0xD0")]
		public Action onResponsesShown;

		// Token: 0x0400157E RID: 5502
		[Token(Token = "0x400157E")]
		[FieldOffset(Offset = "0xD8")]
		public Action onConversationOpened;

		// Token: 0x0400157F RID: 5503
		[Token(Token = "0x400157F")]
		[FieldOffset(Offset = "0xE0")]
		public List<Response> currentResponses;

		// Token: 0x04001580 RID: 5504
		[Token(Token = "0x4001580")]
		[FieldOffset(Offset = "0xE8")]
		private List<RectTransform> responseRects;
	}
}
