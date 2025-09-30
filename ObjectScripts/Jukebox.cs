using System;
using EasyButtons;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.EntityFramework;
using ScheduleOne.Persistence.Datas;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000C6C RID: 3180
	[Token(Token = "0x2000C6C")]
	public class Jukebox : GridItem
	{
		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x060055C5 RID: 21957 RVA: 0x00015450 File Offset: 0x00013650
		[Token(Token = "0x17000BC6")]
		public int CurrentVolume
		{
			[Token(Token = "0x60055C5")]
			[Address(RVA = "0x9CA110", Offset = "0x9C8B10", VA = "0x1809CA110")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x060055C6 RID: 21958 RVA: 0x00015468 File Offset: 0x00013668
		[Token(Token = "0x17000BC7")]
		public float NormalizedVolume
		{
			[Token(Token = "0x60055C6")]
			[Address(RVA = "0x9CA150", Offset = "0x9C8B50", VA = "0x1809CA150")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x060055C7 RID: 21959 RVA: 0x00015480 File Offset: 0x00013680
		[Token(Token = "0x17000BC8")]
		public bool IsPlaying
		{
			[Token(Token = "0x60055C7")]
			[Address(RVA = "0x9CA130", Offset = "0x9C8B30", VA = "0x1809CA130")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x060055C8 RID: 21960 RVA: 0x00015498 File Offset: 0x00013698
		[Token(Token = "0x17000BC9")]
		public float CurrentTrackTime
		{
			[Token(Token = "0x60055C8")]
			[Address(RVA = "0x9CA0F0", Offset = "0x9C8AF0", VA = "0x1809CA0F0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x060055C9 RID: 21961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BCA")]
		private int[] TrackOrder
		{
			[Token(Token = "0x60055C9")]
			[Address(RVA = "0x9CA1E0", Offset = "0x9C8BE0", VA = "0x1809CA1E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x060055CA RID: 21962 RVA: 0x000154B0 File Offset: 0x000136B0
		[Token(Token = "0x17000BCB")]
		public int CurrentTrackOrderIndex
		{
			[Token(Token = "0x60055CA")]
			[Address(RVA = "0x9CA0D0", Offset = "0x9C8AD0", VA = "0x1809CA0D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x060055CB RID: 21963 RVA: 0x000154C8 File Offset: 0x000136C8
		[Token(Token = "0x17000BCC")]
		public bool Shuffle
		{
			[Token(Token = "0x60055CB")]
			[Address(RVA = "0x9CA1A0", Offset = "0x9C8BA0", VA = "0x1809CA1A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x060055CC RID: 21964 RVA: 0x000154E0 File Offset: 0x000136E0
		[Token(Token = "0x17000BCD")]
		public Jukebox.ERepeatMode RepeatMode
		{
			[Token(Token = "0x60055CC")]
			[Address(RVA = "0x9CA180", Offset = "0x9C8B80", VA = "0x1809CA180")]
			get
			{
				return Jukebox.ERepeatMode.None;
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x060055CD RID: 21965 RVA: 0x000154F8 File Offset: 0x000136F8
		[Token(Token = "0x17000BCE")]
		public bool Sync
		{
			[Token(Token = "0x60055CD")]
			[Address(RVA = "0x9CA1C0", Offset = "0x9C8BC0", VA = "0x1809CA1C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x060055CE RID: 21966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BCF")]
		public Jukebox.Track currentTrack
		{
			[Token(Token = "0x60055CE")]
			[Address(RVA = "0x9CA230", Offset = "0x9C8C30", VA = "0x1809CA230")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x060055CF RID: 21967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD0")]
		private AudioClip currentClip
		{
			[Token(Token = "0x60055CF")]
			[Address(RVA = "0x9CA200", Offset = "0x9C8C00", VA = "0x1809CA200")]
			get
			{
				return null;
			}
		}

		// Token: 0x060055D0 RID: 21968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055D0")]
		[Address(RVA = "0x9C7F50", Offset = "0x9C6950", VA = "0x1809C7F50", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x060055D1 RID: 21969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055D1")]
		[Address(RVA = "0x9C8080", Offset = "0x9C6A80", VA = "0x1809C8080")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060055D2 RID: 21970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055D2")]
		[Address(RVA = "0x9C85E0", Offset = "0x9C6FE0", VA = "0x1809C85E0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060055D3 RID: 21971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055D3")]
		[Address(RVA = "0x9C8050", Offset = "0x9C6A50", VA = "0x1809C8050")]
		public void ChangeVolume(int change)
		{
		}

		// Token: 0x060055D4 RID: 21972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055D4")]
		[Address(RVA = "0x9C99C0", Offset = "0x9C83C0", VA = "0x1809C99C0")]
		public void SetVolume(int volume, bool replicate)
		{
		}

		// Token: 0x060055D5 RID: 21973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055D5")]
		[Address(RVA = "0x9C7BD0", Offset = "0x9C65D0", VA = "0x1809C7BD0")]
		private void ApplyVolume()
		{
		}

		// Token: 0x060055D6 RID: 21974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055D6")]
		[Address(RVA = "0x9C9AD0", Offset = "0x9C84D0", VA = "0x1809C9AD0")]
		[Button]
		public void TogglePlay()
		{
		}

		// Token: 0x060055D7 RID: 21975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055D7")]
		[Address(RVA = "0x9C7FA0", Offset = "0x9C69A0", VA = "0x1809C7FA0")]
		[Button]
		public void Back()
		{
		}

		// Token: 0x060055D8 RID: 21976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055D8")]
		[Address(RVA = "0x9C8540", Offset = "0x9C6F40", VA = "0x1809C8540")]
		[Button]
		public void Next()
		{
		}

		// Token: 0x060055D9 RID: 21977 RVA: 0x00015510 File Offset: 0x00013710
		[Token(Token = "0x60055D9")]
		[Address(RVA = "0x9C82B0", Offset = "0x9C6CB0", VA = "0x1809C82B0")]
		private int GetPreviousTrackOrderIndex()
		{
			return 0;
		}

		// Token: 0x060055DA RID: 21978 RVA: 0x00015528 File Offset: 0x00013728
		[Token(Token = "0x60055DA")]
		[Address(RVA = "0x9C8270", Offset = "0x9C6C70", VA = "0x1809C8270")]
		private int GetNextTrackOrderIndex()
		{
			return 0;
		}

		// Token: 0x060055DB RID: 21979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055DB")]
		[Address(RVA = "0x9C9BE0", Offset = "0x9C85E0", VA = "0x1809C9BE0")]
		[Button]
		public void ToggleShuffle()
		{
		}

		// Token: 0x060055DC RID: 21980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055DC")]
		[Address(RVA = "0x9C9B50", Offset = "0x9C8550", VA = "0x1809C9B50")]
		[Button]
		public void ToggleRepeatMode()
		{
		}

		// Token: 0x060055DD RID: 21981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055DD")]
		[Address(RVA = "0x9C9EB0", Offset = "0x9C88B0", VA = "0x1809C9EB0")]
		[Button]
		public void ToggleSync()
		{
		}

		// Token: 0x060055DE RID: 21982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055DE")]
		[Address(RVA = "0x9C8640", Offset = "0x9C7040", VA = "0x1809C8640")]
		public void PlayTrack(int trackID)
		{
		}

		// Token: 0x060055DF RID: 21983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055DF")]
		[Address(RVA = "0x9C9110", Offset = "0x9C7B10", VA = "0x1809C9110")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendJukeboxState(Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
		}

		// Token: 0x060055E0 RID: 21984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055E0")]
		[Address(RVA = "0x9C92A0", Offset = "0x9C7CA0", VA = "0x1809C92A0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetJukeboxState(NetworkConnection conn, Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
		}

		// Token: 0x060055E1 RID: 21985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055E1")]
		[Address(RVA = "0x9C9560", Offset = "0x9C7F60", VA = "0x1809C9560")]
		public void SetJukeboxState(Jukebox.JukeboxState state, bool setTrackTime)
		{
		}

		// Token: 0x060055E2 RID: 21986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055E2")]
		[Address(RVA = "0x9C82F0", Offset = "0x9C6CF0", VA = "0x1809C82F0")]
		private Jukebox.Track GetTrack(int orderIndex)
		{
			return null;
		}

		// Token: 0x060055E3 RID: 21987 RVA: 0x00015540 File Offset: 0x00013740
		[Token(Token = "0x60055E3")]
		[Address(RVA = "0x9C9F10", Offset = "0x9C8910", VA = "0x1809C9F10")]
		private bool ValidateQueue(int[] queue)
		{
			return default(bool);
		}

		// Token: 0x060055E4 RID: 21988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055E4")]
		[Address(RVA = "0x9C8850", Offset = "0x9C7250", VA = "0x1809C8850")]
		private void ReplicateStateToOtherClients(bool setTrackTime)
		{
		}

		// Token: 0x060055E5 RID: 21989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055E5")]
		[Address(RVA = "0x9C8880", Offset = "0x9C7280", VA = "0x1809C8880")]
		private void ReplicateStateToOtherJukeboxes(bool setTrackTime)
		{
		}

		// Token: 0x060055E6 RID: 21990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055E6")]
		[Address(RVA = "0x9C8170", Offset = "0x9C6B70", VA = "0x1809C8170", Slot = "60")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x060055E7 RID: 21991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055E7")]
		[Address(RVA = "0x9C5880", Offset = "0x9C4280", VA = "0x1809C5880")]
		public Jukebox()
		{
		}

		// Token: 0x060055E8 RID: 21992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055E8")]
		[Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410", Slot = "62")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060055E9 RID: 21993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055E9")]
		[Address(RVA = "0x9C83F0", Offset = "0x9C6DF0", VA = "0x1809C83F0", Slot = "63")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060055EA RID: 21994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055EA")]
		[Address(RVA = "0x669880", Offset = "0x668280", VA = "0x180669880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060055EB RID: 21995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055EB")]
		[Address(RVA = "0x9C8E40", Offset = "0x9C7840", VA = "0x1809C8E40")]
		private void RpcWriter___Server_SendJukeboxState_1728100027(Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
		}

		// Token: 0x060055EC RID: 21996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055EC")]
		[Address(RVA = "0x9C8A20", Offset = "0x9C7420", VA = "0x1809C8A20")]
		public void RpcLogic___SendJukeboxState_1728100027(Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
		}

		// Token: 0x060055ED RID: 21997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055ED")]
		[Address(RVA = "0x9C8B20", Offset = "0x9C7520", VA = "0x1809C8B20")]
		private void RpcReader___Server_SendJukeboxState_1728100027(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060055EE RID: 21998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055EE")]
		[Address(RVA = "0x9C8CC0", Offset = "0x9C76C0", VA = "0x1809C8CC0")]
		private void RpcWriter___Observers_SetJukeboxState_2499833112(NetworkConnection conn, Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
		}

		// Token: 0x060055EF RID: 21999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055EF")]
		[Address(RVA = "0x9C8A50", Offset = "0x9C7450", VA = "0x1809C8A50")]
		public void RpcLogic___SetJukeboxState_2499833112(NetworkConnection conn, Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
		}

		// Token: 0x060055F0 RID: 22000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055F0")]
		[Address(RVA = "0x9C8A70", Offset = "0x9C7470", VA = "0x1809C8A70")]
		private void RpcReader___Observers_SetJukeboxState_2499833112(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060055F1 RID: 22001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055F1")]
		[Address(RVA = "0x9C8FA0", Offset = "0x9C79A0", VA = "0x1809C8FA0")]
		private void RpcWriter___Target_SetJukeboxState_2499833112(NetworkConnection conn, Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
		}

		// Token: 0x060055F2 RID: 22002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055F2")]
		[Address(RVA = "0x9C8C10", Offset = "0x9C7610", VA = "0x1809C8C10")]
		private void RpcReader___Target_SetJukeboxState_2499833112(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060055F3 RID: 22003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055F3")]
		[Address(RVA = "0x9C7CC0", Offset = "0x9C66C0", VA = "0x1809C7CC0", Slot = "71")]
		protected virtual void Awake_UserLogic_ScheduleOne.ObjectScripts.Jukebox_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04003F99 RID: 16281
		[Token(Token = "0x4003F99")]
		public const float MUSIC_FADE_MULTIPLIER = 0.4f;

		// Token: 0x04003F9A RID: 16282
		[Token(Token = "0x4003F9A")]
		public const int TRACK_COUNT = 27;

		// Token: 0x04003F9B RID: 16283
		[Token(Token = "0x4003F9B")]
		[FieldOffset(Offset = "0x218")]
		private Jukebox.JukeboxState _jukeboxState;

		// Token: 0x04003F9C RID: 16284
		[Token(Token = "0x4003F9C")]
		[FieldOffset(Offset = "0x220")]
		[Header("References")]
		public Jukebox.Track[] TrackList;

		// Token: 0x04003F9D RID: 16285
		[Token(Token = "0x4003F9D")]
		[FieldOffset(Offset = "0x228")]
		public GameObject[] VolumeIndicatorBars;

		// Token: 0x04003F9E RID: 16286
		[Token(Token = "0x4003F9E")]
		[FieldOffset(Offset = "0x230")]
		public AudioSourceController AudioSourceController;

		// Token: 0x04003F9F RID: 16287
		[Token(Token = "0x4003F9F")]
		[FieldOffset(Offset = "0x238")]
		public Action onStateChanged;

		// Token: 0x04003FA0 RID: 16288
		[Token(Token = "0x4003FA0")]
		[FieldOffset(Offset = "0x240")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.JukeboxAssembly-CSharp.dll_Excuted;

		// Token: 0x04003FA1 RID: 16289
		[Token(Token = "0x4003FA1")]
		[FieldOffset(Offset = "0x241")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.JukeboxAssembly-CSharp.dll_Excuted;

		// Token: 0x02000C6D RID: 3181
		[Token(Token = "0x2000C6D")]
		[Serializable]
		public class Track
		{
			// Token: 0x060055F4 RID: 22004 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60055F4")]
			[Address(RVA = "0x9DAE30", Offset = "0x9D9830", VA = "0x1809DAE30")]
			public Track()
			{
			}

			// Token: 0x04003FA2 RID: 16290
			[Token(Token = "0x4003FA2")]
			[FieldOffset(Offset = "0x10")]
			public string TrackName;

			// Token: 0x04003FA3 RID: 16291
			[Token(Token = "0x4003FA3")]
			[FieldOffset(Offset = "0x18")]
			public AudioClip Clip;

			// Token: 0x04003FA4 RID: 16292
			[Token(Token = "0x4003FA4")]
			[FieldOffset(Offset = "0x20")]
			public string ArtistName;
		}

		// Token: 0x02000C6E RID: 3182
		[Token(Token = "0x2000C6E")]
		[Serializable]
		public class JukeboxState
		{
			// Token: 0x060055F5 RID: 22005 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60055F5")]
			[Address(RVA = "0x9C7BB0", Offset = "0x9C65B0", VA = "0x1809C7BB0")]
			public JukeboxState()
			{
			}

			// Token: 0x04003FA5 RID: 16293
			[Token(Token = "0x4003FA5")]
			[FieldOffset(Offset = "0x10")]
			public int CurrentVolume;

			// Token: 0x04003FA6 RID: 16294
			[Token(Token = "0x4003FA6")]
			[FieldOffset(Offset = "0x14")]
			public bool IsPlaying;

			// Token: 0x04003FA7 RID: 16295
			[Token(Token = "0x4003FA7")]
			[FieldOffset(Offset = "0x18")]
			public float CurrentTrackTime;

			// Token: 0x04003FA8 RID: 16296
			[Token(Token = "0x4003FA8")]
			[FieldOffset(Offset = "0x20")]
			public int[] TrackOrder;

			// Token: 0x04003FA9 RID: 16297
			[Token(Token = "0x4003FA9")]
			[FieldOffset(Offset = "0x28")]
			public int CurrentTrackOrderIndex;

			// Token: 0x04003FAA RID: 16298
			[Token(Token = "0x4003FAA")]
			[FieldOffset(Offset = "0x2C")]
			public bool Shuffle;

			// Token: 0x04003FAB RID: 16299
			[Token(Token = "0x4003FAB")]
			[FieldOffset(Offset = "0x30")]
			public Jukebox.ERepeatMode RepeatMode;

			// Token: 0x04003FAC RID: 16300
			[Token(Token = "0x4003FAC")]
			[FieldOffset(Offset = "0x34")]
			public bool Sync;
		}

		// Token: 0x02000C6F RID: 3183
		[Token(Token = "0x2000C6F")]
		public enum ERepeatMode
		{
			// Token: 0x04003FAE RID: 16302
			[Token(Token = "0x4003FAE")]
			None,
			// Token: 0x04003FAF RID: 16303
			[Token(Token = "0x4003FAF")]
			RepeatQueue,
			// Token: 0x04003FB0 RID: 16304
			[Token(Token = "0x4003FB0")]
			RepeatTrack
		}
	}
}
