using System;
using System.IO;
using Xamarin.Forms;
using DfTSites.Droid;



[assembly: Dependency(typeof(SqliteDB))]

namespace DfTSites.Droid
{
    public class SqliteDB : ISqliteDB
    {
        public string GetLocalFilePath(string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            return Path.Combine(path, filename);

            //return NSBundle.MainBundle.PathForResource("DfTSites", "sqlite"); //iOS method


        }


        //private static void CopyDB(string dbPath)
        //{
        //	using (var br = new BinaryReader(Android.App.Application.Context.Assets.Open("DfTSites.sqlite")))
        //	{
        //		using (var bw = new BinaryWriter(new FileStream(dbPath, FileMode.Create)))
        //		{
        //			byte[] buffer = new byte[2048];
        //			int length = 0;
        //			while ((length = br.Read(buffer, 0, buffer.Length)) > 0)
        //			{
        //				bw.Write(buffer, 0, length);
        //			}
        //		}

        //	}
        //}

    }


}
