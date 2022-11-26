using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActorSampleAkka
{
    public interface IMusicSongService

    {

        Song GetSongByName(string songName);

    }

    public class MusicSongService : IMusicSongService

    {

        public Song GetSongByName(string songName)

        {

            return new Song(songName, new byte[0]);

        }

    }

    public class Song

    {

        public Song(string songName, byte[] rowFormat)

        {

            SongName = songName;

            RowFormat = rowFormat;

        }

        public string SongName { get; }

        public byte[] RowFormat { get; }

    }
    public class MusicActor : ReceiveActor

    {

        private IMusicSongService SongService { get; }

        public MusicActor(IMusicSongService songService)

        {

            SongService = songService;

            Receive<string>(s => HandleSongRetrieval(s));

        }



        public void HandleSongRetrieval(string songName)

        {

            var song = SongService.GetSongByName(songName);

            /* do something with this song*/

        }

    }
}
