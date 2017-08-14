using System;
using System.IO;
using Xamarin.Forms;
using DfTSites.iOS;
using Foundation;

[assembly: Dependency(typeof(SqliteDB))]

namespace DfTSites.iOS
{
    public class SqliteDB : ISqliteDB
    {
        public string GetLocalFilePath(string fileName)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");
            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }
            //return Path.Combine(libFolder, fileName);
            return NSBundle.MainBundle.PathForResource("DfTSites", "sqlite");
            // only works if sqlite database is a BundleResource under Build Action
        }

        private static void CopyDB(string dbPath)
        {

            var existingDb = NSBundle.MainBundle.PathForResource("DfTSites", "sqlite");
            File.Copy(existingDb, dbPath);

        }
    }



}


