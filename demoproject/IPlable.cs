using demoproject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace demoproject
{
    internal interface IPlable
    {
        public void Play();
    }
    class Videoplayer : IPlable
    {
        public void Play()
        {
            Console.WriteLine("Playing the video");
        }
    }
    class  MusicPlayer:IPlable
    {
        public void Play()
        {
            Console.WriteLine("Playing the Music");
        }
    }
    class Multiple
    {
        static void Main()
        {
            Videoplayer v=new Videoplayer();
            v.Play();   
            MusicPlayer m=new MusicPlayer();
            m.Play();   
        }
    }
}
 
